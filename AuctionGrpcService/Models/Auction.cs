using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionGrpcService.Models
{
    public class Auction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuctionId { get; set; }
        public int AuctionPicId { get; set; }

        public decimal AuctionPrice { get; set; }

        public DateTime AuctionDateEnd { get; set; }

        public bool ActionIsOver { get; set; }

        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
    }
}
