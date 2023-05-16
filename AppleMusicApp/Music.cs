using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleMusicApp
{
    public class Music
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Artist { get; set; }
        public List<string> Tracks { get; set; }
    }
}
