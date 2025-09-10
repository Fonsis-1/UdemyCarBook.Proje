using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
	public class Category : BaseEntity
    {
		public int CategoryID { get; set; }
		public string Name { get; set; }
		public List<Blog> Blogs { get; set; }
	}
}
