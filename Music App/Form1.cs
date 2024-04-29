using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace Music_App
{
    public partial class Form1 : Form
    {
        //Bingding source is ability to connect list of items such as albums to grid control so we define it here
        BindingSource albumsBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            /*    AlbumsDAO albumsDAO = new AlbumsDAO();
                Album a1 = new Album
                {
                    ID = 1,
                    AlbumName = "My first album",
                    ArtistName = "Sweet Cheeks",
                    Year = 2024,
                    ImageURL = "Nothing yet",
                    Description = "No description"
                };
                Album a2 = new Album
                {
                    ID = 1,
                    AlbumName = "My second album",
                    ArtistName = "Sweet Cheeks",
                    Year = 2024,
                    ImageURL = "Nothing yet",
                    Description = "No description"
                };

                albumsDAO.albums.Add(a1);
                albumsDAO.albums.Add(a2); */

            //connect the list to the grid view control

            albums = albumsDAO.getAllAlbums();
            albumsBindingSource.DataSource = albums;

            dataGridView1.DataSource = albumsBindingSource;

            // pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/thumb/9/90/TheMelodicBlueCover.jpeg/220px-TheMelodicBlueCover.jpeg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            //connect the list to the grid view control
            albumsBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);

            dataGridView1.DataSource = albumsBindingSource;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //get the row number clicked

            int rowCLicked = dataGridView.CurrentRow.Index;
            //  MessageBox.Show("You clicked row" + rowCLicked);

            String imageURL = dataGridView.Rows[rowCLicked].Cells[4].Value.ToString();

            //  MessageBox.Show("URL" + imageURL);
            pictureBox1.Load(imageURL);

            tracksBindingSource.DataSource = albums[rowCLicked].Tracks;

            dataGridView2.DataSource = tracksBindingSource;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //add a new item to the databse
            Album album = new Album
            {
                AlbumName = txt_albumName.Text,
                ArtistName = txt_albumArtist.Text,
                Year = Int32.Parse(txt_albumYear.Text),
                ImageURL = txt_ImageURL.Text,
                Description = txt_albumDescription.Text
            };
            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addOneAlbum(album);
            MessageBox.Show(result + " new row(s) inserted");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            //get the row number clicked

            int rowCLicked = dataGridView2.CurrentRow.Index;
            //MessageBox.Show("You clicked row" + rowCLicked);
            int trackID = (int)dataGridView2.Rows[rowCLicked].Cells[0].Value;
            MessageBox.Show("ID of track" + trackID);

            AlbumsDAO albumsDao = new AlbumsDAO();

            int result = albumsDao.deleteTrack(trackID);

            MessageBox.Show("Result" + result);
            dataGridView2.DataSource = null;
            albums = albumsDao.getAllAlbums();

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //get the row number clicked

            int rowCLicked = dataGridView.CurrentRow.Index;
            //MessageBox.Show("You clicked row" + rowCLicked);
            String videoURL = dataGridView.Rows[rowCLicked].Cells[3].Value.ToString();

            //MessageBox.Show("URL =" + imageURL);
            webView21.Source = new Uri(videoURL);

        }
    }
}
