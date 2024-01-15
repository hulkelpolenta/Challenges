using AuctionGrpcService;
using AuctionGrpcService.Models;
using AuctionGrpcService.Protos;
using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.EntityFrameworkCore;

namespace AuctionGrpcService.Services
{
    public class AuctionService : AuctionServ.AuctionServBase
    {
        private readonly ILogger<AuctionService> _logger;

        private AuctionContext _context;
        private int _clientid;
        public AuctionService(ILogger<AuctionService> logger, AuctionContext context)
        {
            _logger = logger;
            _context = context;
            //var appSettings = cont.RequestServices.GetRequiredService<IConfiguration>();
            //var _clientid = int.Parse(appSettings.GetValue<string>("ClientId"));
            _clientid = 1;
        }

        // Creates a new auction for the owner
        //rpc AuctionNew(AuctionNewRequest) returns(AuctionBasicReply);
        public override async Task<AuctionBasicReply> AuctionNew(AuctionNewRequest request, ServerCallContext context)
        {

            var auc = new Auction();
            auc.AuctionPicId = int.Parse(request.Auctionpicid);
            auc.AuctionPrice = decimal.Parse(request.Auctionprice);
            auc.ActionIsOver = false;
            auc.ClientId = _clientid;

            _context.Add(auc);
            try
            {
                await _context.SaveChangesAsync();
                var list = await _context.Clients.Where(c=> c.ClientId != _clientid).ToListAsync();
                foreach (var item in list)
                {
                    using (var channel = GrpcChannel.ForAddress(item.ClientDir))
                    {
                        var client = new AuctionCli.AuctionCliClient(channel);
                        var addAucr = new AuctionAddRequestC();
                        addAucr.Auctionpicid = request.Auctionpicid;
                        addAucr.Auctionprice = request.Auctionprice;
                        addAucr.Auctionid = auc.AuctionId.ToString();
                        addAucr.Clientid = auc.ClientId.ToString();


                        var reply =  client.AuctionAdd(addAucr);
                    }
                }
                return new AuctionBasicReply { Message = "OK" };
            }
            catch (Exception e)
            {
                return new AuctionBasicReply { Message = e.Message };
            }
        }

        // Add a new auction for oher users
        //rpc AuctionAdd(AuctionAddRequest) returns(AuctionBasicReply);
        public override async Task<AuctionBasicReply> AuctionAdd(AuctionAddRequest request, ServerCallContext context)
        {
            var auc = new Auction();
            auc.AuctionPicId = int.Parse(request.Auctionpicid);
            auc.AuctionPrice = decimal.Parse(request.Auctionprice);
            auc.ActionIsOver = false;
            auc.ClientId = int.Parse(request.Clientid);

            _context.Add(auc);
            try
            {
                await _context.SaveChangesAsync();
                return new AuctionBasicReply { Message = "OK" };
            }
            catch (Exception e)
            {
                return new AuctionBasicReply { Message = e.Message };
            }

        }

        // get the list of auction and winners
        //rpc AuctionGet(AuctionRequest) returns(AuctionGetReply);

        public override async Task<AuctionGetReply> AuctionGet(AuctionRequest request, ServerCallContext context)
        {
            var list = await _context.Auctions.ToListAsync();
            var reply = new AuctionGetReply();
            foreach (var item in list)
            {
                string txt ="";

                txt += "Auction number: " + item.AuctionId.ToString(); 
                txt += " - Pic number: " + item.AuctionPicId.ToString();
                txt += " - Price: " + item.AuctionPrice.ToString();

                if (item.ActionIsOver)
                {
                    var listBid = await _context.Bids.Where(c => c.AuctionId == item.AuctionId && (bool)c.BidIsWinner ).FirstOrDefaultAsync();

                    if (item.ClientId > 0) txt += " - The winner is the Client Number: " + listBid.ClientId.ToString();
                    txt += " - Auction is over";
                }


                reply.Data.Add("txt");
                    
            }
            return reply;
        }

        // Creates a new bid
        //rpc AuctionBidNew (AuctionBidRequest) returns (AuctionBasicReply);

        public override async Task<AuctionBasicReply> AuctionBidNew(AuctionBidRequest request, ServerCallContext context)
        {

            var bid = new Bid();
            bid.AuctionId = int.Parse(request.Auctionid);
            bid.BidPrice = decimal.Parse(request.Bidprice);
            bid.BidIsWinner = false;
            bid.ClientId = _clientid;

            _context.Add(bid);
            try
            {
                await _context.SaveChangesAsync();

                if (_context.Bids.Where(c => c.AuctionId == bid.AuctionId).Count() > 2)
                { 

                    var winner = await _context.Bids.Include(c=> c.Auction).Where(c => c.AuctionId == bid.AuctionId).OrderByDescending(c => c.BidPrice).FirstOrDefaultAsync();

                    winner.BidIsWinner = true;
                    winner.Auction.ActionIsOver = true;

                    var list = await _context.Clients.Where(c => c.ClientId != _clientid).ToListAsync();
                    foreach (var item in list)
                    {
                        using (var channel = GrpcChannel.ForAddress(item.ClientDir))
                        {
                            var client = new AuctionCli.AuctionCliClient(channel);
                            var addAucr = new AuctionBidUsersRequestC();
                            addAucr.Auctionid = winner.AuctionId.ToString();
                            addAucr.Bidprice = winner.BidPrice.ToString();
                            addAucr.Clientid = winner.ClientId.ToString();


                            var reply = client.AuctionBidAdd(addAucr);
                        }
                    }
                }
                return new AuctionBasicReply { Message = "OK" };
            }
            catch (Exception e)
            {
                return new AuctionBasicReply { Message = e.Message };
            }
        }

        // Add a new bid for oher users
        //rpc AuctionBidAdd (AuctionBidUsersRequest) returns (AuctionBasicReply);

        public override async Task<AuctionBasicReply> AuctionBidAdd(AuctionBidUsersRequest request, ServerCallContext context)
        {
            var auc = new Bid();
            auc.BidPrice = int.Parse(request.Bidprice);
            auc.ClientId = int.Parse(request.Clientid);
            auc.BidIsWinner = true;
            auc.AuctionId = int.Parse(request.Auctionid);

            _context.Add(auc);
            try
            {
                await _context.SaveChangesAsync();
                return new AuctionBasicReply { Message = "OK" };
            }
            catch (Exception e)
            {
                return new AuctionBasicReply { Message = e.Message };
            }

        }
    }
}
