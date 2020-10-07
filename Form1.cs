using MovieMania.Movie_Mania;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMania
{
    public partial class Form1 : Form
    {
        Movie M = new Movie();
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadDataGrid()
        {
            DataTable DT = M.Select();
            dgvMovieList.DataSource = DT;
            //clear fields
            Clear();
        }
        public void Clear()
        {
            txtbxMovieID.Text = "";
            txtbxTitle.Text = "";
            txtbxReleaseYr.Text = "";
            cmbxGenre.Text = "";
            txtbxDirector.Text = "";
            txtbxProducer.Text = "";
            txtbxWriter.Text = "";
            cmbxRating.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            //Step 1: Get the values in each textbox
            M.Title = txtbxTitle.Text;
            M.ReleaseYear = int.Parse(txtbxReleaseYr.Text);
            M.Genre = cmbxGenre.Text;
            M.Director = txtbxDirector.Text;
            M.Producer = txtbxProducer.Text;
            M.Writer = txtbxWriter.Text;
            M.Rating = cmbxRating.Text;
            //Step 2: Add data into DB using the methods in the Movie Class
            bool isAdded = M.Add(M);
            if (isAdded == true)
            {
                MessageBox.Show("Movie Added!");
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Failed to Add Movie. Try Again...");
                Clear();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Close Form
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Step 1: Get the values in each textbox
            M.MovieID = int.Parse(txtbxMovieID.Text);
            M.Title = txtbxTitle.Text;
            M.ReleaseYear = int.Parse(txtbxReleaseYr.Text);
            M.Genre = cmbxGenre.Text;
            M.Director = txtbxDirector.Text;
            M.Producer = txtbxProducer.Text;
            M.Writer = txtbxWriter.Text;
            M.Rating = cmbxRating.Text;
            //Step 2: Add data into DB using the methods in the Movie Class
            bool isUpdated = M.Update(M);
            if (isUpdated == true)
            {
                MessageBox.Show("Movie Updated!");
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Failed to Update Movie. Try Again...");
                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get the MovieID from the record in the database
            M.MovieID = Convert.ToInt32(txtbxMovieID.Text);
            bool isDeleted = M.Delete(M);
            if (isDeleted == true)
            {
                MessageBox.Show("Movie Deleted!");
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Failed to Delete Movie. Try Again...");
                Clear();
            }
        }

        private void dgvMovieList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Identify the row on which the mouse was clicked
            int rowNumber = e.RowIndex;
            //Get data from datagrid view and display in the textboxes
            txtbxMovieID.Text = dgvMovieList.Rows[rowNumber].Cells[0].Value.ToString();
            txtbxTitle.Text = dgvMovieList.Rows[rowNumber].Cells[1].Value.ToString();
            txtbxReleaseYr.Text = dgvMovieList.Rows[rowNumber].Cells[2].Value.ToString();
            cmbxGenre.Text = dgvMovieList.Rows[rowNumber].Cells[3].Value.ToString();
            txtbxDirector.Text = dgvMovieList.Rows[rowNumber].Cells[4].Value.ToString();
            txtbxProducer.Text = dgvMovieList.Rows[rowNumber].Cells[5].Value.ToString();
            txtbxWriter.Text = dgvMovieList.Rows[rowNumber].Cells[6].Value.ToString();
            cmbxRating.Text = dgvMovieList.Rows[rowNumber].Cells[7].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtbxSearch.Text;
            //Display records w/ keyword in the DataTable
            DataTable DT = M.Search(keyword);
            dgvMovieList.DataSource = DT;
        }
    }
}
