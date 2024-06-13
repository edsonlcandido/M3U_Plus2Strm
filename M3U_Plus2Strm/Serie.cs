using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3U_Plus2Strm
{
    internal class Serie : Media
    {
        public Serie() {
        type = "serie";
        }
        public string name { get; set; }
        public string episode { get; set; }
    }
    internal class Episode
    {
        public string Season { get; set; }
        public string EpisodeNumber { get; set; }
    }
}
