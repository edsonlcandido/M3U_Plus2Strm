using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace M3U_Plus2Strm
{
    internal class ParseM3uFile
    {
        public ParseM3uFile() { }
        public string[] ReadFile(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            return lines;
        }
        public List<Media> Parse(string[] lines)
        {
            List<Media> medias = new List<Media>();
            Media media = null;
            foreach (string line in lines)
            {
                string characterPattern = @"""([A-Za-z])""";                
                string newLine = Regex.Replace(line, characterPattern, "'$1'");
                if (newLine.StartsWith("#EXTINF:"))
                {
                    media = new Media();                    
                    string pattern = @"tvg-name=""((?:[^""]|\""|\\.)*?)""";
                    Match match = Regex.Match(newLine, pattern);
                    if (match.Success)
                    {
                        media.name = match.Groups[1].Value.Replace("\\\"", "\"");
                    }
                    else
                    {
                        media.name = newLine.Substring(newLine.IndexOf(",") + 1);
                    }
                }
                else if (line.StartsWith("http") && line.Contains("serie"))
                {
                    media.url = line;
                    media.type = "serie";
                    medias.Add(media);
                }else if (line.StartsWith("http") && line.Contains("movie"))
                {
                    media.url = line;
                    media.type = "movie";
                    medias.Add(media);
                }
            }
            return medias;
        }
    }

}
