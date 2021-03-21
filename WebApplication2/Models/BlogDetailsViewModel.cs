using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class BlogDetailsViewModel
    {
        public List<BlogModel> Blogs { get; set; }
        public List<ReaderModel> Readers { get; set; }
    }
}
