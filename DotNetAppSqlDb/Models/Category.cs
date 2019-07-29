using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DotNetAppSqlDb.Models
{

    public partial class Category
    {
        public Category()
        {
            Tasks = new HashSet<Task>();
        }

        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }

}