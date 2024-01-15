// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using AuctionClient;
using Grpc.Net.Client;

while (true)
{
    Console.WriteLine("1. New Auction");
    Console.WriteLine("2. List Auction");
    Console.WriteLine("3. Bid Auction");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");
    var choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            using (var channel = GrpcChannel.ForAddress("https://localhost:7016"))
            {
                var client = new AuctionServ.AuctionServClient(channel);
                var newAucr = new AuctionNewRequest();
                Random random = new Random();
                newAucr.Auctionpicid = random.Next(1, 1000).ToString();
                newAucr.Auctionprice = random.Next(1, 1000).ToString();



                var reply = await client.AuctionNewAsync(newAucr);
                Console.WriteLine(reply.Message);
                Console.ReadKey();
            }
            break;
        case "2":
            using (var channel = GrpcChannel.ForAddress("https://localhost:7016"))
            {
                var client = new AuctionServ.AuctionServClient(channel);
                var newR = new AuctionRequest();

                var reply = await client.AuctionGetAsync(newR);
                //foreach (var item in reply.Data)
                //{
                    Console.WriteLine(reply.Data);
                //}
                Console.ReadKey();
            }
            break;
        case "3":
            Console.Write("Enter your Auction number: ");
            var auctionid = Console.ReadLine();
            Console.Write("Enter your bet: ");
            var bidprice = Console.ReadLine();
            using (var channel = GrpcChannel.ForAddress("https://localhost:7016"))
            {
                var client = new AuctionServ.AuctionServClient(channel);
                var newBid = new AuctionBidRequest();
                newBid.Auctionid = auctionid;
                newBid.Bidprice = bidprice;


                var reply = await client.AuctionBidNewAsync(newBid);
                Console.WriteLine(reply.Message);
                Console.ReadKey();
            }
            break;
        case "4":
            return;
    }
}



