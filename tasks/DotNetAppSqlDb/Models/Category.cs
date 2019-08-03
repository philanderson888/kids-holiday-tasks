using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DotNetAppSqlDb.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Category()
        {
            ToDos = new HashSet<Todo>();
        }

        public virtual ICollection<Todo> ToDos { get; set; }
    }
}