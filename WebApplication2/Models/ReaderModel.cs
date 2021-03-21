using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Models
{
    public class ReaderModel

    {
        public string ReaderName { get; set; }
        public DateTime CheckinTime { get; set; }
        public string FavouriteCategory { get; set; }
    }
}
