using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRentalProject
{
    public class DatabaseContext
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db_Connection"].ConnectionString);
        public int returnedVideo(int rmid)
        {

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("update RentedMovies set DateReturned=@DateReturned where RentedMovieId=@RentedMovieId", conn))
                {
                    cmd.Parameters.AddWithValue("@RentedMovieId", rmid);
                    cmd.Parameters.AddWithValue("@DateReturned", DateTime.Now);

                    cmd.ExecuteNonQuery();

                }
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int editVideo(string video_title, DateTime release_Date, decimal cost, string genre, string plot, int movieId)
        {

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("update Movie set Title=@Title,ReleaseDate=@ReleaseDate,RentalCost=@RentalCost,Genre=@Genre,Plot=@Plot where MovieId=@MovieId", conn))
                {
                    cmd.Parameters.AddWithValue("@MovieId", movieId);
                    cmd.Parameters.AddWithValue("@Title", video_title);
                    cmd.Parameters.AddWithValue("@ReleaseDate", release_Date);
                    cmd.Parameters.AddWithValue("@RentalCost", cost);
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    cmd.Parameters.AddWithValue("@Plot", plot);


                    cmd.ExecuteNonQuery();

                }
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int editCustomer(string cust_firstName, string cust_lastname, string cust_address, string contact_no, int customer_id)
        {

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("update Customer set FirstName=@FirstName,LastName=@LastName,Address=@Address,Phone=@Phone  where CustId=@CustId", conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", cust_firstName);
                    cmd.Parameters.AddWithValue("@LastName", cust_lastname);
                    cmd.Parameters.AddWithValue("@Address", cust_address);
                    cmd.Parameters.AddWithValue("@Phone", contact_no);
                    cmd.Parameters.AddWithValue("@CustId", customer_id);

                    cmd.ExecuteNonQuery();

                }
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int customerDelete(int customer_id)
        {

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("delete from Customer where CustId=@CustId", conn))
                {
                    cmd.Parameters.AddWithValue("@CustId", customer_id);

                    cmd.ExecuteNonQuery();

                }
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int addCustomer(string cust_firstName, string cust_lastname, string cust_address, string contact_no)
        {

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("insert into Customer(FirstName,LastName,Address,Phone)values(@FirstName,@LastName,@Address,@Phone)", conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", cust_firstName);
                    cmd.Parameters.AddWithValue("@LastName", cust_lastname);
                    cmd.Parameters.AddWithValue("@Address", cust_address);
                    cmd.Parameters.AddWithValue("@Phone", contact_no);

                    cmd.ExecuteNonQuery();

                }
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int videoDelete(int vid_id)
        {

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("delete from Movie where MovieId=@MovieId", conn))
                {
                    cmd.Parameters.AddWithValue("@MovieId", vid_id);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int addVideo(string video_title, DateTime release_Date, decimal cost, string genre, string plot)
        {

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("insert into Movie(Title,ReleaseDate,RentalCost,Genre,Plot)values(@Title,@ReleaseDate,@RentalCost,@Genre,@Plot)", conn))
                {
                    cmd.Parameters.AddWithValue("@Title", video_title);
                    cmd.Parameters.AddWithValue("@ReleaseDate", release_Date);
                    cmd.Parameters.AddWithValue("@RentalCost", cost);
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    cmd.Parameters.AddWithValue("@Plot", plot);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public DataTable BindCustomer()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("stpGetAllCustomer", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {


                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable BindAllVideo()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from Movie", conn))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public int addRentalVideo(int vid_id, int customer_id)
        {

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("insert into RentedMovies(MovieId,CustId,DateRented)values(@MovieId,@CustId,@DateRented)", conn))
                {
                    cmd.Parameters.AddWithValue("@MovieId", vid_id);
                    cmd.Parameters.AddWithValue("@CustId", customer_id);
                    cmd.Parameters.AddWithValue("@DateRented", DateTime.Now);

                    cmd.ExecuteNonQuery();

                }
                conn.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
       
       
        
    }
}
