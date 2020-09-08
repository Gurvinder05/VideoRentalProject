using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace VideoRentalProject
{
    public partial class VideosRentalSystem : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db_Connection"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        SqlDataAdapter adp = new SqlDataAdapter();
        DatabaseContext db_conn = new DatabaseContext();
        public VideosRentalSystem()
        {
            InitializeComponent();
        }

        private void VideosRental_Load(object sender, EventArgs e)
        {
            
            customerGridData();
            movieGridData();
            RentedmovieGridData();
            BorrowsMostVideo();
            MostPopularVideo();
            ddlfill_Customer();
            ddlfill_Movie();

        }
        private void btnVideoOnRental_Click(object sender, EventArgs e)
        {
            if (ddlCutomerList.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Customer");
                return;
            }
            if (ddlVideoList.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Video");
                return;
            }

            var alreadyRental = 0;
            conn.Open();
            cmd = new SqlCommand("Select * from RentedMovies where MovieId=@MovieId and DateReturned is NULL", conn);
            cmd.Parameters.AddWithValue("@MovieId", ddlVideoList.SelectedValue);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                alreadyRental = 1;
            }
            else
            {
                alreadyRental = 0;
            }
            rdr.Close();
            conn.Close();
            if (alreadyRental == 1)
            {
                MessageBox.Show("This Video already rented");
                return;
            }
            int success = db_conn.addRentalVideo(Convert.ToInt32(ddlVideoList.SelectedValue), Convert.ToInt32(ddlCutomerList.SelectedValue));

            if (success == 1)
            {
                MessageBox.Show("Movie Rented successfully");
                customer_id.Text = "";
                video_id.Text = "";
                ClearTextBoxes();
                RentedmovieGridData();
                BorrowsMostVideo();
                MostPopularVideo();

            }
        }
        public void customerGridData()
        {
            DataSet dsCust = new DataSet();
            cmd = new SqlCommand("select * from Customer", conn);
            adp.SelectCommand = cmd;
            dsCust.Clear();
            adp.Fill(dsCust, "Customer");
            griddataCustomer.DataSource = dsCust.Tables["Customer"];
        }
        private void movieGridData()
        {
            DataSet dsMovie = new DataSet();
            cmd = new SqlCommand("select * from Movie", conn);
            adp.SelectCommand = cmd;
            dsMovie.Clear();
            adp.Fill(dsMovie, "Movie");
            gridVideoData.DataSource = dsMovie.Tables["Movie"];
        }
        private void RentedmovieGridData()
        {
            DataSet dsRentedMovie = new DataSet();
            cmd = new SqlCommand("select * from ViewRentedMovies", conn);
            adp.SelectCommand = cmd;
            dsRentedMovie.Clear();
            adp.Fill(dsRentedMovie, "ViewRentedMovies");
            gridRentalVideos.DataSource = dsRentedMovie.Tables["ViewRentedMovies"];
        }
        private void ddlfill_Customer()
        {

            DataTable dt = new DataTable();

            dt = db_conn.BindCustomer();
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Select Customer";
            dt.Rows.InsertAt(row, 0);
            ddlCutomerList.DataSource = dt;
                ddlCutomerList.ValueMember = "CustId";
                ddlCutomerList.DisplayMember = "FirstName";

          
        }
        private void ddlfill_Movie()
        {

            DataTable dt = new DataTable();

            dt = db_conn.BindAllVideo();
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Select Video";
            dt.Rows.InsertAt(row, 0);
            ddlVideoList.DataSource = dt;
                ddlVideoList.ValueMember = "MovieId";
                ddlVideoList.DisplayMember = "Title";

        }
        private void dateRelease_ValueChanged(object sender, EventArgs e)
        {
            if (dateRelease.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                TextCost.Text = "2";
            }
            else
            {
                TextCost.Text = "5";
            }
        }


        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool checkData = Validate();
            if (checkData == true)
            {
                int c = db_conn.addCustomer(textboxFirstName.Text, TextLastname.Text, areatextAddress.Text, textboxMobile.Text);
                if (c == 1)
                {
                    customer_id.Text = "";
                    video_id.Text = "";
                    rentalMovie_id.Text = "";
                    ClearTextBoxes();
                    customerGridData();
                    tabControl1.SelectedIndex = 0;
                    ddlfill_Customer();
                    ddlfill_Movie();
                    MessageBox.Show("Added Customer Successfully");
                }
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textTitleVideo.Text))
            {
                MessageBox.Show("Movie Title is required");
                return;
            }
            else if (string.IsNullOrEmpty(TextCost.Text))
            {
                MessageBox.Show("Rental Cost is required");
                return;
            }

            int success = db_conn.addVideo(textTitleVideo.Text, dateRelease.Value.Date, Convert.ToDecimal(TextCost.Text), TextGenre.Text, Textplot.Text);
            if (success == 1)
            {
                customer_id.Text = "";
                video_id.Text = "";
                rentalMovie_id.Text = "";
                ClearTextBoxes();
                movieGridData();
                tabControl1.SelectedIndex = 1;
                ddlfill_Customer();
                ddlfill_Movie();
                MessageBox.Show("Added Video Successfully");
                
            }
            else
            {
                MessageBox.Show("Wrong Data Input");
            }
            
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(video_id.Text))
            {
                MessageBox.Show("Please Select the Video for Update");
                return;
            }
            if (string.IsNullOrEmpty(textTitleVideo.Text))
            {
                MessageBox.Show("Movie Title is required");
                return;
            }
            else if (string.IsNullOrEmpty(TextCost.Text))
            {
                MessageBox.Show("Rental Cost is required");
                return;
            }
            int success = db_conn.editVideo(textTitleVideo.Text, dateRelease.Value.Date, Convert.ToDecimal(TextCost.Text), TextGenre.Text, Textplot.Text, Convert.ToInt32(video_id.Text));
            if (success == 1)
            {
                video_id.Text = "";
                ClearTextBoxes();
                movieGridData();
                tabControl1.SelectedIndex = 1;
                ddlfill_Customer();
                ddlfill_Movie();
                MessageBox.Show("Updated Video Successfully");
               
            }
           
            
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(video_id.Text))
            {
                MessageBox.Show("Please Select the Video for Delete");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS Video ??", "Record Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                int success = db_conn.videoDelete(Convert.ToInt32(video_id.Text));
                if (success == 1)
                {
                    MessageBox.Show("Record Deleted.......");


                    ClearTextBoxes();
                    video_id.Text = "";
                    movieGridData();
                    ddlfill_Customer();
                    ddlfill_Movie();
                }
                
            }
            else if (dialogResult == DialogResult.No)
            {
              
            }
        }
       
        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(rentalMovie_id.Text))
            {
                MessageBox.Show("Please Select the Rented Movie");
                tabControl1.SelectedIndex = 2;
                return;
            }
            conn.Open();
            var alreadyReturned = 0;
            cmd = new SqlCommand("Select * from RentedMovies where RentedMovieId=@RentedMovieId and DateReturned is Not NULL", conn);
            cmd.Parameters.AddWithValue("@RentedMovieId", rentalMovie_id.Text);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                alreadyReturned = 1;
            }
            else
            {
                alreadyReturned = 0;
            }
            rdr.Close();
            conn.Close();
            if(alreadyReturned==1)
            {
                MessageBox.Show("This Video already returned");
                return;
            }
            int Success = db_conn.returnedVideo(Convert.ToInt32(rentalMovie_id.Text));
            if (Success == 1)
            {
                MessageBox.Show("Movie Returned successfully");
                customer_id.Text = "";
                video_id.Text = "";
                rentalMovie_id.Text = "";
                ClearTextBoxes();
                tabControl1.SelectedIndex = 2;
                RentedmovieGridData();
            }
            
           
        }
        private void BorrowsMostVideo()
        {
            DataSet ds = new DataSet();
            cmd = new SqlCommand("select CustId,FirstName,LastName,Address,Phone,Count(*) as 'Total Borrows' from ViewRentedMovies group by CustId,FirstName,LastName,Address,Phone order by 'Total Borrows' desc", conn);
            adp.SelectCommand = cmd;
            ds.Clear();
            adp.Fill(ds, "ViewRentedMovies");
            gridCustomeList.DataSource = ds.Tables["ViewRentedMovies"];
        }
        private void MostPopularVideo()
        {
            DataSet ds = new DataSet();
            cmd = new SqlCommand("select MovieId,Title,ReleaseDate,RentalCost,Genre,Count(*) as 'Total Rented By' from ViewRentedMovies group by MovieId,Title,ReleaseDate,RentalCost,Genre order by 'Total Rented By' desc", conn);
            adp.SelectCommand = cmd;
            ds.Clear();
            adp.Fill(ds, "ViewRentedMovies");
            gridPopularVideoList.DataSource = ds.Tables["ViewRentedMovies"];
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex==2)
            {
                RentedmovieGridData();
            }
        }

        private void btnRentedOut_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            DataSet dsRentedMovie = new DataSet();
            cmd = new SqlCommand("select * from ViewRentedMovies where DateReturned is Null", conn);
            adp.SelectCommand = cmd;
            dsRentedMovie.Clear();
            adp.Fill(dsRentedMovie, "ViewRentedMovies");
            gridRentalVideos.DataSource = dsRentedMovie.Tables["ViewRentedMovies"];
        }

       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customer_id.Text))
            {
                MessageBox.Show("Please Select the Customer for Update");
                return;
            }
            bool checkData = Validate();
            if (checkData == true)
            {
                int c = db_conn.editCustomer(textboxFirstName.Text, TextLastname.Text, areatextAddress.Text, textboxMobile.Text, Convert.ToInt32(customer_id.Text));
                if (c == 1)
                {
                    customer_id.Text = "";
                    ClearTextBoxes();
                    customerGridData();
                    tabControl1.SelectedIndex = 0;
                    ddlfill_Customer();
                    ddlfill_Movie();
                    MessageBox.Show("Updated Customer Successfully");
                }
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customer_id.Text))
            {
                MessageBox.Show("Please Select the Customer for Delete");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS Customer ??", "Customer Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int cust = db_conn.customerDelete(Convert.ToInt32(customer_id.Text));
                if (cust == 1)
                {
                    MessageBox.Show("Record Deleted.......");


                    ClearTextBoxes();
                    customer_id.Text = "";
                    customerGridData();
                    ddlfill_Customer();
                    ddlfill_Movie();
                    MessageBox.Show("Successfully Delete Customer");

                }

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

       

        private void gridVideoData_Click(object sender, EventArgs e)
        {
            if (gridVideoData.Rows.Count > 0)
            {
                video_id.Text = gridVideoData.CurrentRow.Cells[0].Value.ToString();
                textTitleVideo.Text = gridVideoData.CurrentRow.Cells[1].Value.ToString();
                dateRelease.Text = gridVideoData.CurrentRow.Cells[2].Value.ToString();
                TextCost.Text = gridVideoData.CurrentRow.Cells[3].Value.ToString();
                TextGenre.Text = gridVideoData.CurrentRow.Cells[4].Value.ToString();
                Textplot.Text = gridVideoData.CurrentRow.Cells[5].Value.ToString();

            }
        }

        private void griddataCustomer_Click(object sender, EventArgs e)
        {
            if (griddataCustomer.Rows.Count > 0)
            {
                customer_id.Text = griddataCustomer.CurrentRow.Cells[0].Value.ToString();
                textboxFirstName.Text = griddataCustomer.CurrentRow.Cells[1].Value.ToString();
                TextLastname.Text = griddataCustomer.CurrentRow.Cells[2].Value.ToString();
                areatextAddress.Text = griddataCustomer.CurrentRow.Cells[3].Value.ToString();
                textboxMobile.Text = griddataCustomer.CurrentRow.Cells[4].Value.ToString();

            }
        }

        

        private void btnAllRentedVideo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            RentedmovieGridData();
        }

        private void gridRentalVideos_Click(object sender, EventArgs e)
        {
            if (gridRentalVideos.Rows.Count > 0)
            {
                rentalMovie_id.Text = gridRentalVideos.CurrentRow.Cells["RMID"].Value.ToString();
                customer_id.Text = gridRentalVideos.CurrentRow.Cells["CustId"].Value.ToString();
                textboxFirstName.Text = gridRentalVideos.CurrentRow.Cells["FirstName"].Value.ToString();
                TextLastname.Text = gridRentalVideos.CurrentRow.Cells["LastName"].Value.ToString();
                areatextAddress.Text = gridRentalVideos.CurrentRow.Cells["Address"].Value.ToString();
                textboxMobile.Text = gridRentalVideos.CurrentRow.Cells["Phone"].Value.ToString();
                video_id.Text = gridRentalVideos.CurrentRow.Cells["MovieId"].Value.ToString();
                textTitleVideo.Text = gridRentalVideos.CurrentRow.Cells["Title"].Value.ToString();
                dateRelease.Text = gridRentalVideos.CurrentRow.Cells["ReleaseDate"].Value.ToString();
                TextCost.Text = gridRentalVideos.CurrentRow.Cells["RentalCost"].Value.ToString();
                TextGenre.Text = gridRentalVideos.CurrentRow.Cells["Genre"].Value.ToString();
                Textplot.Text = gridRentalVideos.CurrentRow.Cells["Plot"].Value.ToString();

            }
        }
        public bool Validation()
        {
            if (string.IsNullOrEmpty(textboxFirstName.Text))
            {
                MessageBox.Show("First Name is required");
                return false;
            }
            else if (string.IsNullOrEmpty(TextLastname.Text))
            {
                MessageBox.Show("Last Name is required");
                return false;
            }
            else if (string.IsNullOrEmpty(areatextAddress.Text))
            {
                MessageBox.Show("Address is required");
                return false;
            }
            else if (string.IsNullOrEmpty(textboxMobile.Text))
            {
                MessageBox.Show("Phone No. is required");
                return false;
            }
            return true;
        }
    }
    

}
