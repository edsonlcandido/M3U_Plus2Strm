namespace M3U_Plus2Strm
{
    internal class MovieHandler
    {
        public MovieHandler() { }
        public List<Movie> GetMovies(List<Media> medias)
        {
            List<Movie> movies = new List<Movie>();
            foreach (Media media in medias)
            {
                if (media.type == "movie")
                {
                    Movie movie = new Movie(media);
                    movies.Add(movie);
                }
            }

            //ordene os filmes pelo nome
            movies = movies.OrderBy(o => o.name).ToList();
            return movies;
        }
    }

}
