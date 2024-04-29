using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace Music_App
{
    public partial class Form1 : Form
    {
        // Binding source to connect list of items such as albums to grid control
        BindingSource albumsBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();

        public Form1()
        {
            InitializeComponent();
        }

        // Button click event to retrieve all albums from the database
        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // Retrieve all albums from the database
            albums = albumsDAO.getAllAlbums();

            // Connect the list to the grid view control
            albumsBindingSource.DataSource = albums;
            dataGridView1.DataSource = albumsBindingSource;
        }

        // Button click event to search albums by title
        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // Search for albums by title
            albumsBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);
            dataGridView1.DataSource = albumsBindingSource;
        }

        // Cell click event for the albums grid view
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            // Get the row number clicked
            int rowClicked = dataGridView.CurrentRow.Index;

            // Load the image of the selected album
            String imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();
            pictureBox1.Load(imageURL);

            // Bind the tracks of the selected album to the tracks grid view
            tracksBindingSource.DataSource = albums[rowClicked].Tracks;
            dataGridView2.DataSource = tracksBindingSource;
        }

        // Button click event to add a new album to the database
        private void button3_Click(object sender, EventArgs e)
        {
            // Create a new Album object with the provided details
            Album album = new Album
            {
                AlbumName = txt_albumName.Text,
                ArtistName = txt_albumArtist.Text,
                Year = Int32.Parse(txt_albumYear.Text),
                ImageURL = txt_ImageURL.Text,
                Description = txt_albumDescription.Text
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();

            // Add the new album to the database
            int result = albumsDAO.addOneAlbum(album);
            MessageBox.Show(result + " new row(s) inserted");
        }

        // Button click event to delete a track from the database
        private void button4_Click(object sender, EventArgs e)
        {
            // Get the row number clicked
            int rowClicked = dataGridView2.CurrentRow.Index;
            int trackID = (int)dataGridView2.Rows[rowClicked].Cells[0].Value;

            AlbumsDAO albumsDao = new AlbumsDAO();

            // Delete the track from the database
            int result = albumsDao.deleteTrack(trackID);
            MessageBox.Show("Result" + result);

            // Refresh the tracks grid view
            dataGridView2.DataSource = null;
            albums = albumsDao.getAllAlbums();
        }

        // Cell click event for the tracks grid view
        private void dataGridView2_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            // Get the row number clicked
            int rowClicked = dataGridView.CurrentRow.Index;
            String videoURL = dataGridView.Rows[rowClicked].Cells[3].Value.ToString();

            // Load the video in the web view
            webView21.Source = new Uri(videoURL);
        }
    }
}
