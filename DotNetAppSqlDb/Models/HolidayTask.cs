using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetAppSqlDb.Models
{
    public class HolidayTask
    {
        public int ID { get; set; }

        [Display(Name = "Up by 815am latest (preferably 750 to 8am)")]
        public bool UpBy815 { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EntryDate { get; set; }

        [Display(Name = "Philip has done 750 words Monday Wednesday Friday and 500 words Tuesday Thursday")]
        public int PhilipWordQuantity { get; set; }

        [Display(Name = "James has done 250 words (Weekdays)")]
        public int JamesWordQuantity { get; set; }

        [Display(Name = "John has done 250 words (Weekdays)")]
        public int JohnWordQuantity { get; set; }


        [Display(Name = "Philip has gone a run today, yesterday or the day before")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PhilipLastRunDate { get; set; }

        [Display(Name = "Philip has done weights today, yesterday or the day before")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PhilipLastWeightsDate { get; set; }

        [Display(Name = "Philip has done a cycle ride in the last week (enter date)")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PhilipLastCycleDate { get; set; }


        public int? UserID { get; set; }

        public virtual User User { get; set; }


    }

}