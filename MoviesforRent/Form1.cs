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

        public string dtCheck()
        {
            return con.Database;
        }

        private void Getrentalrecordsmovies()
        {


            SqlCommand cmd = new SqlCommand("Select * from MOVTBL", con);

            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            movgview.DataSource = dt;

        }

        private void Getrentalrecords()
        {


            SqlCommand cmd = new SqlCommand("Select * from RNTBL", con);

            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            rntlgview.DataSource = dt;

        }

        private void custmaddbtn_Click(object sender, EventArgs e)
        {
            if (IsValid())

            {
                SqlCommand cmd = new SqlCommand("INSERT INTO CUSTABLE VALUES(@cid,@fname,@sname,@address,@mob)", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cid", custmiddbx.Text);
                cmd.Parameters.AddWithValue("@fname", custofstnmebx.Text);
                cmd.Parameters.AddWithValue("@sname", custosrenmebx.Text);
                cmd.Parameters.AddWithValue("@address", custoadrsbx.Text);
                cmd.Parameters.AddWithValue("@mob", custophnbx.Text);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

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

        private void custmdltbtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM CUSTABLE  WHERE CUSTOID=@cid", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@cid", custmiddbx.Text);
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Done");
            Getrentalrecordscustmer();
            Cleartextbox();
        }

        private void custmupdtbtn_Click(object sender, EventArgs e)
        {
            if (custmiddbx.Text != "")

            {
                SqlCommand cmd = new SqlCommand("UPDATE  CUSTABLE SET CUSTOID= @cid, FSTNAM = @fname, SURNAM = @sname, ADDRES= @address, PHON= @mob WHERE CUSTOID=@cid", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cid", custmiddbx.Text);
                cmd.Parameters.AddWithValue("@fname", custofstnmebx.Text);
                cmd.Parameters.AddWithValue("@sname", custosrenmebx.Text);
                cmd.Parameters.AddWithValue("@address", custoadrsbx.Text);
                cmd.Parameters.AddWithValue("@mob", custophnbx.Text);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Done");
                Getrentalrecordscustmer();
                Cleartextbox();
            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }

        private void movaddbttn_Click(object sender, EventArgs e)
        {

            if (IsValidate())

            {
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
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
               
                MessageBox.Show("Done");
                Getrentalrecordsmovies();
                Cleartextbox();
            }
        }



        private bool IsValidate()
        {

            if (movsidbx.Text == string.Empty)
            {
                MessageBox.Show("Fields are Empty");
                return false;
            }

            return true;

        }

        private void movdltbtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM MOVTBL  WHERE MOVSId=@mid", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@mid", movsidbx.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Done");
            Getrentalrecordsmovies();
            Cleartextbox();
        }

        private void movupdtbtn_Click(object sender, EventArgs e)
        {
            if (movsidbx.Text != "")

            {
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

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Done");
                Getrentalrecordsmovies();
                Cleartextbox();
            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }

        private void movisuebtn_Click(object sender, EventArgs e)
        {

            if (IsValidR())

            {
SqlCommand cmd = new SqlCommand("INSERT INTO RNTBL VALUES(@rmid,@cstrridbx,@movrenbx,@rntdbx,@retdbox)", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@rmid", rentmovidbx.Text);
                cmd.Parameters.AddWithValue("@cstrridbx", cstrridbx.Text);
                cmd.Parameters.AddWithValue("@movrenbx", movrenbx.Text);
                cmd.Parameters.AddWithValue("@rntdbx", rntdbx.Text);
                cmd.Parameters.AddWithValue("@retdbox", rtrdbx.Text);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Done");
                Getrentalrecords();
                Cleartextbox();
            }
        }



        private bool IsValidR()
        {

            if (rentmovidbx.Text == string.Empty)
            {
                MessageBox.Show("Fields are Empty");
                return false;
            }

            return true;

        }

        private void movrtrnbttn_Click(object sender, EventArgs e)
        {
            if (IsValidR())

            {
SqlCommand cmd = new SqlCommand("UPDATE  RNTBL SET RNTId= @rmid, CUSTOId= @retdbox WHERE MOVSId=@rmid", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@rmid", rentmovidbx.Text);                
                cmd.Parameters.AddWithValue("@retdbox", rtrdbx.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Done");
                Getrentalrecords();
                Cleartextbox();
            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }

        private void rntolmov_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select RNTID, FSTNAM, ADDRES, MOVNAME, MOVRNT, RNTDT, RTRNDT from RNTBL JOIN RNTBL ON RNTBL.CUSTOID = RNTBL.CUSTOID JOIN MOVTBL ON MOVTBL.MOVSID=RNTBL.MOVSID", con);

            sda.Fill(dt);
            rntlgview.DataSource = dt;
            con.Close();
        }

        private void presentlyout_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select RNTID, FSTNAM, ADDRES, MOVNAME, MOVRNT, RNTDT, RTRNDT from RNTBL JOIN CUSTABLE ON RNTBL.CUSTOID = CUSTABLE.CUSTOID JOIN MOVTBL ON MOVTBL.MOVSID=RNTBL.MOVSID where RNTBL.datereturn=''", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            rntlgview.DataSource = dt;
        }

        private void upratmov_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From MOVTBL Where MOVRAT=(select max (MOVRAT) from MOVTBL)", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            movgview.DataSource = dt;
        }

        private void costmfstnmedtl_Click(object sender, EventArgs e)
        {

        }
    }
}
