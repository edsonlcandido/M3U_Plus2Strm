using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3U_Plus2Strm
{    internal class StreamFileHandler
    {
        protected string name { get; set; } // The name of the media file
        protected string url { get; set; } // The URL of the media file
        protected string folder { get; set; } // The folder where the .strm file will be created
        protected List<Episode> episodes { get; set; } // The list of episodes for a serie

        /// <summary>
        /// Constructor for the StreamFileHandler class.
        /// Removes special characters from the media name.
        /// </summary>
        /// <param name="media">The media object to create a .strm file for.</param>
        public StreamFileHandler(Media media)
        {
            media.name = media.name.Replace(":", "");
            media.name = media.name.Replace("?", "");
            media.name = media.name.Replace("/", "");
            media.name = media.name.Replace("\\", "");
            media.name = media.name.Replace("*", "");
            media.name = media.name.Replace("\"", "");
            media.name = media.name.Replace("<", "");
            media.name = media.name.Replace(">", "");
            media.name = media.name.Replace("|", "");
            name = media.name;
            url = media.url;
        }

        /// <summary>
        /// Creates a .strm file for the media.
        /// </summary>
        /// <param name="path">The root path where the folder for the media type will be created.</param>
        public virtual void CreateStrmFile(string path)
        {
            string[] lines = { url };
            DirectoryInfo folderRootInfo = new DirectoryInfo(path);
            DirectoryInfo folderInfo = folderRootInfo.CreateSubdirectory(name);
            // Check if the folder exists, and create it if it does not.
            if (!folderInfo.Exists)
            {
                folderInfo.Create();
            }
            // Concatenate folderinfo.FullName with the default directory separator for the operating system.
            char sep = Path.DirectorySeparatorChar;
            folder = folderInfo.FullName + sep;
            File.WriteAllLines(folder + name + ".strm", lines);
        }
    }

}
