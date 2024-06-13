using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3U_Plus2Strm
{
    internal class MovieStreamFileHandler : StreamFileHandler
    {
        public MovieStreamFileHandler(Media media) : base(media) { }

        public override void CreateStrmFile(string path)
        {
            base.CreateStrmFile(path);
        }
    }
}
