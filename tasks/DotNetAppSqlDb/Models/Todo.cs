﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetAppSqlDb.Models
{
    public class Todo
    {
        public int ID { get; set; }
        public string Description { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        public bool Done { get; set; }

        public bool UpEarly { get; set; }

        public bool StayUp { get; set; }

        public bool MakeGym { get; set; }

    }
}