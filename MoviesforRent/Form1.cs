using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesforRent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      // Add connection string
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JTA47FT\SQLEXPRESS; Initial Catalog = master ;Integrated Security=True;Connect Timeout=30;");

        private void Form1_Load(object sender, EventArgs e)
        {
            Getrentalrecordscustmer();
            Getrentalrecordsmovies();
            Getrentalrecords();
        }

        private void Cleartextbox()
        {
            custmiddbx.Clear();
            custofstnmebx.Clear();
            custosrenmebx.Clear();
            custoadrsbx.Clear();
            custophnbx.Clear();

            movsidbx.Clear();
            movntrbx.Clear();
            movrlsbx.Clear();
            movgnrbx.Clear();
            movcbx.Clear();
            movpbx.Clear();
            movrntbx.Clear();
            movrtndtbx.Clear();

            rentmovidbx.Clear();
            cstrridbx.Clear();
            movrenbx.Clear();
            rntdbx.Clear();
            rtrdbx.Clear();

            custmiddbx.Focus();
        }

        private void Getrentalrecordscustmer()
        {
           

            SqlCommand cmd = new SqlCommand("Select * from CUSTABLE", con);

            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            custmgview.DataSource = dt;

        }
        //testing function
        public string dtCheck()
        {
            return con.Database;
        }
        //Add records of rental movies
        private void Getrentalrecordsmovies()
        {

            // Add query for selection of movie table
            SqlCommand cmd = new SqlCommand("Select * from MOVTBL", con);

            DataTable dt = new DataTable();
            // connection open
            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            //connection close
            con.Close();

            movgview.DataSource = dt;

        }

        private void Getrentalrecords()
        {
            //Add query for selection of rental table

            SqlCommand cmd = new SqlCommand("Select * from RNTBL", con);

            DataTable dt = new DataTable();
            // open connection
            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            // connection close
            con.Close();

            rntlgview.DataSource = dt;

        }
        //Add customer button
        private void custmaddbtn_Click(object sender, EventArgs e)
        {
            if (IsValid())

            {
                //Add Insert query for inserting customer values
                SqlCommand cmd = new SqlCommand("INSERT INTO CUSTABLE VALUES(@cid,@fname,@sname,@address,@mob)", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cid", custmiddbx.Text);
                cmd.Parameters.AddWithValue("@fname", custofstnmebx.Text);
                cmd.Parameters.AddWithValue("@sname", custosrenmebx.Text);
                cmd.Parameters.AddWithValue("@address", custoadrsbx.Text);
                cmd.Parameters.AddWithValue("@mob", custophnbx.Text);
                // connection open
                con.Open();
                cmd.ExecuteNonQuery();
                //connection close
                con.Close();
                // Add messagebox to show message done
                MessageBox.Show("Done");
                Getrentalrecordscustmer();
                Cleartextbox();
            }
        }

       

        private bool IsValid()
        {

            if (custmiddbx.Text == string.Empty)
            { 
            MessageBox.Show("Fields are Empty");
            return false;
        }

        return true;

        }
        // Add Customer Delete button
        private void custmdltbtn_Click(object sender, EventArgs e)
        {
            //add query for delete customers
            SqlCommand cmd = new SqlCommand("DELETE FROM CUSTABLE  WHERE CUSTOID=@cid", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@cid", custmiddbx.Text);
            //connection open
            con.Open();
            cmd.ExecuteNonQuery();
            //connection close
            con.Close();
            //Add message to done message
            MessageBox.Show("Done");
            Getrentalrecordscustmer();
            Cleartextbox();
        }
        //Add Update button for customers
        private void custmupdtbtn_Click(object sender, EventArgs e)
        {
            if (custmiddbx.Text != "")

            {
                //Add query for Update customers
                SqlCommand cmd = new SqlCommand("UPDATE  CUSTABLE SET CUSTOID= @cid, FSTNAM = @fname, SURNAM = @sname, ADDRES= @address, PHON= @mob WHERE CUSTOID=@cid", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cid", custmiddbx.Text);
                cmd.Parameters.AddWithValue("@fname", custofstnmebx.Text);
                cmd.Parameters.AddWithValue("@sname", custosrenmebx.Text);
                cmd.Parameters.AddWithValue("@address", custoadrsbx.Text);
                cmd.Parameters.AddWithValue("@mob", custophnbx.Text);
                //connection open
                con.Open();
                cmd.ExecuteNonQuery();
                //connection close
                con.Close();
                //Add messagebox to show done message
                MessageBox.Show("Done");
                Getrentalrecordscustmer();
                Cleartextbox();
            }
            else
            {
                //Add messagebox to show message of try again
                MessageBox.Show("Try Again");
            }
        }
        //Add  button for inserting movie
        private void movaddbttn_Click(object sender, EventArgs e)
        {

            if (IsValidate())

            {
                //add query for inserting movies
                SqlCommand cmd = new SqlCommand("INSERT INTO MOVTBL VALUES(@mid,@mname,@mrat,@mgen,@mcpy,@mplt,@mrent,@mrd)", con);
                
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@mid", movsidbx.Text);
                cmd.Parameters.AddWithValue("@mname", movntrbx.Text);
                cmd.Parameters.AddWithValue("@mrat", movrlsbx.Text);
                cmd.Parameters.AddWithValue("@mgen", movgnrbx.Text);
                cmd.Parameters.AddWithValue("@mcpy", movcbx.Text);
                cmd.Parameters.AddWithValue("@mplt", movpbx.Text);
                cmd.Parameters.AddWithValue("@mrent", movrntbx.Text);
                cmd.Parameters.AddWithValue("@mrd", movrtndtbx.Text);
                //open connection
                con.Open();
                cmd.ExecuteNonQuery();
                //connection close
                con.Close();
               // Add messagebox to show message done
                MessageBox.Show("Done");
                Getrentalrecordsmovies();
                Cleartextbox();
            }
        }



        private bool IsValidate()
        {

            if (movsidbx.Text == string.Empty)
            {
                //Add message box to show message "fields are empty"
                MessageBox.Show("Fields are Empty");
                return false;
            }

            return true;

        }
        //Add Delete button to delete movies
        private void movdltbtn_Click(object sender, EventArgs e)
        {
            //add query for delete movies
            SqlCommand cmd = new SqlCommand("DELETE FROM MOVTBL  WHERE MOVSId=@mid", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@mid", movsidbx.Text);
            //Connection open
            con.Open();
            cmd.ExecuteNonQuery();
            //Close connection
            con.Close();
            //Add messagebox to show done
            MessageBox.Show("Done");
            Getrentalrecordsmovies();
            Cleartextbox();
        }
        //Add update button to update movies
        private void movupdtbtn_Click(object sender, EventArgs e)
        {
            if (movsidbx.Text != "")

            {
                //add query to update movies
SqlCommand cmd = new SqlCommand("UPDATE  MOVTBL SET MOVSId= @mid, MOVNAME= @mname, MOVRAT= @mrat, MOVGEN= @mgen, MOVCPY= @mcpy, MOVPLT= @mplt, MOVRNT= @mrent, MOVRELSDT= @mrd WHERE MOVSID=@mid", con);

cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@mid", movsidbx.Text);
                cmd.Parameters.AddWithValue("@mname", movntrbx.Text);
                cmd.Parameters.AddWithValue("@mrat", movrlsbx.Text);
                cmd.Parameters.AddWithValue("@mgen", movgnrbx.Text);
                cmd.Parameters.AddWithValue("@mcpy", movcbx.Text);
                cmd.Parameters.AddWithValue("@mplt", movpbx.Text);
                cmd.Parameters.AddWithValue("@mrent", movrntbx.Text);
                cmd.Parameters.AddWithValue("@mrd", movrtndtbx.Text);
                //connection open
                con.Open();
                cmd.ExecuteNonQuery();
                //Connection close
                con.Close();
                // Add messagebox to show message"done"
                MessageBox.Show("Done");
                Getrentalrecordsmovies();
                Cleartextbox();
            }
            else
            {
                //Add messagebox to show message"try again"
                MessageBox.Show("Try Again");
            }
        }
        // Add issue movie button
        private void movisuebtn_Click(object sender, EventArgs e)
        {

            if (IsValidR())

            {
                //Add Queries for inserting rental movies
SqlCommand cmd = new SqlCommand("INSERT INTO RNTBL VALUES(@rmid,@cstrridbx,@movrenbx,@rntdbx,@retdbox)", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@rmid", rentmovidbx.Text);
                cmd.Parameters.AddWithValue("@cstrridbx", cstrridbx.Text);
                cmd.Parameters.AddWithValue("@movrenbx", movrenbx.Text);
                cmd.Parameters.AddWithValue("@rntdbx", rntdbx.Text);
                cmd.Parameters.AddWithValue("@retdbox", rtrdbx.Text);
                //Coneection open
                con.Open();
                cmd.ExecuteNonQuery();
                //Close connection
                con.Close();
                //Add messagebox to show message"done"
                MessageBox.Show("Done");
                Getrentalrecords();
                Cleartextbox();
            }
        }



        private bool IsValidR()
        {

            if (rentmovidbx.Text == string.Empty)
            {
                // Add messagebox to show "Fields are open"
                MessageBox.Show("Fields are Empty");
                return false;
            }

            return true;

        }
        //Add return movie button
        private void movrtrnbttn_Click(object sender, EventArgs e)
        {
            if (IsValidR())

            {
                //Add queries for updating rental movies
SqlCommand cmd = new SqlCommand("UPDATE  RNTBL SET RNTId= @rmid, CUSTOId= @retdbox WHERE MOVSId=@rmid", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@rmid", rentmovidbx.Text);                
                cmd.Parameters.AddWithValue("@retdbox", rtrdbx.Text);
                //connection open
                con.Open();
                cmd.ExecuteNonQuery();
                //Connection close
                con.Close();
                //Add messagebox to show message"done"
                MessageBox.Show("Done");
                Getrentalrecords();
                Cleartextbox();
            }
            else
            {
                //Add messagebox to show "try again"
                MessageBox.Show("Try Again");
            }
        }

        private void rntolmov_CheckedChanged(object sender, EventArgs e)
        {
            //connection open
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select RNTID, FSTNAM, ADDRES, MOVNAME, MOVRNT, RNTDT, RTRNDT from RNTBL JOIN RNTBL ON RNTBL.CUSTOID = RNTBL.CUSTOID JOIN MOVTBL ON MOVTBL.MOVSID=RNTBL.MOVSID", con);

            sda.Fill(dt);
            rntlgview.DataSource = dt;
            //connection close
            con.Close();
        }

        private void presentlyout_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select RNTID, FSTNAM, ADDRES, MOVNAME, MOVRNT, RNTDT, RTRNDT from RNTBL JOIN CUSTABLE ON RNTBL.CUSTOID = CUSTABLE.CUSTOID JOIN MOVTBL ON MOVTBL.MOVSID=RNTBL.MOVSID where RNTBL.datereturn=''", con);
            DataTable dt = new DataTable();
            //Fill data
            sda.Fill(dt);
            rntlgview.DataSource = dt;
        }

        private void upratmov_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From MOVTBL Where MOVRAT=(select max (MOVRAT) from MOVTBL)", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //fill data
            movgview.DataSource = dt;
        }

        private void costmfstnmedtl_Click(object sender, EventArgs e)
        {

        }
    }
}
