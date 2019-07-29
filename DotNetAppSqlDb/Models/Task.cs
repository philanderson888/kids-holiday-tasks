using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetAppSqlDb.Models
{
    public partial class Task
    {
        public int TaskID { get; set; }

        [StringLength(50)]
        public string TaskDescription { get; set; }

        public bool? Done { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateStarted { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateCompleted { get; set; }

        public int? Category { get; set; }

        public int? UserID { get; set; }


        public DateTime? Deadline { get; set; }

        public virtual Category Category1 { get; set; }

        public virtual User User { get; set; }
    }
}