namespace M3U_Plus2Strm
{
    internal static class Program
    {
        public static List<Media> medias { get; set; }
        public static List<Serie> series { get; set; }
        public static List<Movie> movies { get; set; }
        public static Config config { get; set; } = new Config();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
            config.m3uPath = @"D:\Documentos\Downloads\playlist.m3u";
            config.strmMoviePath = @"D:\Documentos\Meus Videos\Stream\movies";
            config.strmSeriePath = @"D:\Documentos\Meus Videos\Stream\series";
            config.removeFilmes = @"[L];[Hybrid];{L]";
            ParseM3uFile parseM3uFile = new ParseM3uFile();
            string[] lines = parseM3uFile.ReadFile(config.m3uPath);
            medias = parseM3uFile.Parse(lines);
            series = new SeriesHandler().GetSeries(medias);
            movies = new MovieHandler().GetMovies(medias);
            
            Application.Run(new Form1());
        }
    }
}