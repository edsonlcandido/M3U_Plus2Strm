using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3U_Plus2Strm
{
    internal class Movie : Media
    {
        public Movie(Media media)
        {
            type = media.type;
            url = media.url;
            name = media.name;
        }
    }
}
