namespace M3U_Plus2Strm
{
    public partial class Form1 : Form
    {
        List<Movie> filterMovies = Program.movies;
        List<Serie> filterSeries = Program.series;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = Program.config;

            dataGridView1.DataSource = filterSeries;
            dataGridView2.DataSource = filterMovies;

            //adjust columns in dataGridView1 to match cells' text
            //use properties from the 'Serie' object
            //order the columns to appear as: name, episode, url
            //hide the 'type' column
            dataGridView1.Columns["type"].Visible = false;
            dataGridView1.Columns["name"].DisplayIndex = 0;
            dataGridView1.Columns["episode"].DisplayIndex = 1;
            dataGridView1.Columns["url"].DisplayIndex = 2;
            dataGridView1.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns["episode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns["url"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            //adjust columns in dataGridView2 to match cells' text
            //use properties from the 'Movie' object
            //order the columns to appear as: name, url
            //hide the 'type' column
            dataGridView2.Columns["type"].Visible = false;
            dataGridView2.Columns["name"].DisplayIndex = 0;
            dataGridView2.Columns["url"].DisplayIndex = 1;
            dataGridView2.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView2.Columns["url"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            //dataGridView1.AutoResizeColumns();
            //dataGridView2.AutoResizeColumns();
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the movie selected in dataGridView2
            Movie movie = (Movie)dataGridView2.CurrentRow.DataBoundItem;
            //create a MovieStreamFileHandler object for the selected movie
            MovieStreamFileHandler movieStreamFileHandler = new MovieStreamFileHandler(movie);
            //call the CreateStrmFile method to create a .strm file for the movie
            movieStreamFileHandler.CreateStrmFile(Program.config.strmMoviePath);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            label1.Text = "Total movies: " + filterMovies.Count().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //remove to the filterMovies list the movies that contains text in textBox1
            filterMovies = filterMovies.Where(m => !m.name.ToLower().Contains(textBox1.Text.ToLower())).ToList();
            //update the dataGridView2 with the new filterMovies list
            dataGridView2.DataSource = filterMovies;
            label1.Text = "Total movies: " + filterMovies.Count().ToString();
        }
    }
}