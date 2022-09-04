using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoginUI.Models
{
    public class Posting
    {
        #region Inital
        public int PostingId { get; set; }

        //[Display(Name = "Posting Type")]
        //public PostingType PostingType { get; set; }

        public string PostingType { get; set; }
        #endregion

        #region User

        //[Required]
        //public string UserId { get; set; }

        //[ForeignKey("UserId")]
        //public AppUser User { get; set; }

        #endregion

        #region General

        public string Pickup { get; set; }

        public string Dropoff { get; set; }

        //[Display(Name = "Load Type")]
        //public LoadType LoadType { get; set; }
        public string LoadType { get; set; }

        ////#region FCL

        ////public Cont? ContainerType { get; set; }

        ////[Display(Name = "Trucks Required")]
        ////public int? Trucks { get; set; }
        ////#endregion

        ////#region LCL

        ////[Display(Name = "Pallets Required")]
        ////public int? Pallets { get; set; }
        ////#endregion

        #endregion

        ////#region Export & Import

        ////[Display(Name = "Port of Loading")]
        ////public Ports? POL { get; set; }

        ////[Display(Name = "Port of Discharge")]
        ////public Ports? POD { get; set; }

        ////[Display(Name = "QTY")]
        ////public int? QTY { get; set; }

        ////[Display(Name = "Delivery Time")]
        ////public DateTime? DeliveryTime { get; set; }

        ////#endregion

        ////#region Export

        ////[Display(Name = "Name of Shipment")]
        ////public string NamOfShip { get; set; }

        ////[Display(Name = "Date of Loading")]
        ////[DataType(DataType.Date)]
        ////public DateTime? DOF { get; set; }

        ////[Display(Name = "Price of Value")]
        ////public int? POF { get; set; }

        ////[Display(Name = "CIF Value")]
        ////public int? CIF { get; set; }

        ////#endregion

        ////#region Import

        ////[Display(Name = "Name of Consignment")]
        ////public string NamOfCons { get; set; }

        ////#endregion

        ////#region Basics

        ////public Commodity Commodity { get; set; }

        ////public int Weight { get; set; }

        ////public Unit Unit { get; set; }

        ////public Hazardous Hazardous { get; set; }

        ////[Display(Name = "Hazardous Classification")]
        ////public HazardousClassify HazardousClassify { get; set; }
        ////#endregion

        ////#region Hazardous Classify

        ////public Explosives Explosives { get; set; }
        ////public Gases Gases { get; set; }

        ////[Display(Name = "Flammable Liquids")]
        ////public FlammableLiquids FlammableLiquids { get; set; }

        ////[Display(Name = "Flammable Solids")]
        ////public FlammableSolids FlammableSolids { get; set; }

        ////[Display(Name = "Toxic and Infectious Substances")]
        ////public ToxicAndInfectiousSubstances ToxicAndInfectiousSubstances { get; set; }

        ////[Display(Name = "Radioactive Substances")]
        ////public Radioactivesubstances Radioactivesubstances { get; set; }

        ////[Display(Name = "Corrosive Substances")]
        ////public Corrosivesubstances Corrosivesubstances { get; set; }

        ////[Display(Name = "Miscellaneous")]
        ////public Miscellaneous Miscellaneous { get; set; }

        ////#endregion

        ////#region Services
        ////public Question Freight { get; set; }

        ////public Question Customs { get; set; }

        ////// Transportation
        ////public Question Transporation { get; set; }

        ////public Question Insurance { get; set; }

        ////public Question Warehousing { get; set; }
        ////#endregion

        ////#region Description & Status
        ////[DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "Null")]
        ////public string Description { get; set; }

        ////public Status Status { get; set; }
        ////#endregion

        ////#region Dates
        ////[Display(Name = "Added Date")]
        //////[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        ////[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        ////public DateTime AddedDate { get; set; }

        ////[Display(Name = "Rejected Date")]
        //////[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        ////public DateTime? RejectedDate { get; set; }

        ////[Display(Name = "Approved Date")]
        //////[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        ////public DateTime? AcceptDate { get; set; }

        ////[Display(Name = "Completed Date")]
        //////[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        ////public DateTime? CompletedDate { get; set; }
        ////#endregion
    }
}
