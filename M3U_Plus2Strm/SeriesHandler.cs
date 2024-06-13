using System.Text.RegularExpressions;

namespace M3U_Plus2Strm
{
    internal class SeriesHandler
    {
        public SeriesHandler() { }
        public List<Serie> GetSeries(List<Media> medias)
        {
            List<Serie> series = new List<Serie>();
            foreach (Media media in medias)
            {
                if (media.type == "serie")
                {
                    Serie serie = new Serie();                    
                    serie.url = media.url;
                    //serie name is name befora pattern S00E00
                    //serie season can be S0x or Sxx
                    //use regex to get season and episode
                    var episodeIndex = media.name.IndexOf(Regex.Match(media.name, "(S0[0-9]|S[1-9][0-9])").Value);
                    serie.name = media.name.Substring(0,episodeIndex).Trim();
                    serie.episode = media.name.Substring(episodeIndex);
                    series.Add(serie);
                }
            }
            //ordene as series por nome e episodio
            series = series.OrderBy(o => o.name).ThenBy(o => o.episode).ToList();
            return series;
        }

    }

}
