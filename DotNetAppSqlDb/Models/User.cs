using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetAppSqlDb.Models
{


    public partial class User
    {
        public User()
        {
            Tasks = new HashSet<Task>();
        }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

    }

}