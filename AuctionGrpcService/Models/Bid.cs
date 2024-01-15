using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionGrpcService.Models
{
    public class Bid
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int BidId { get; set; }
        public int AuctionId { get; set; }
        public decimal BidPrice { get; set; }

        public bool? BidIsWinner { get; set; }

        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        [ForeignKey("AuctionId")]
        public virtual Auction Auction { get; set; }
    }
}
