using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoginUI.Models
{
    public class Bid
    {
        #region Initial
        public int BidId { get; set; }
        #endregion

        #region User
        //[Required]
        //public string UserId { get; set; }
        //[ForeignKey("UserId")]
        //public AppUser User { get; set; }

        //public string BiderId { get; set; }
        //[ForeignKey("BiderId")]
        //public AppUser Bider { get; set; }
        #endregion

        #region Filters
        public int? PostingId { get; set; }
        public Posting Posting { get; set; }
        #endregion

        #region Basics

        public int Cost { get; set; }

        public Status Status { get; set; }

        [Display(Name = "Additional Details")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "None")]
        public string Details { get; set; }
        #endregion

        #region Dates
        [Display(Name = "Added Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime AddedDate { get; set; }

        [Display(Name = "Rejected Date")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? RejectedDate { get; set; }

        [Display(Name = "Approved Date")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? AcceptDate { get; set; }

        [Display(Name = "Completed Date")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CompletedDate { get; set; }
        #endregion
    }
}
