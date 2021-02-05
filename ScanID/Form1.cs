using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ScanID
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		MY_DB db = new MY_DB();
		
		public void SelectSearchBox()
		{
			SearchBox.SelectionStart = 0;
			SearchBox.SelectionLength = SearchBox.Text.Length;
		}

		public void MyQuery()
		{
			MySqlDataAdapter adapterELEM = new MySqlDataAdapter();
			DataTable tableELEM = new DataTable();

			MySqlDataAdapter adapterJR = new MySqlDataAdapter();
			DataTable tableJR = new DataTable();

			MySqlDataAdapter adapterSR = new MySqlDataAdapter();
			DataTable tableSR = new DataTable();

			MySqlDataAdapter adapterCOL = new MySqlDataAdapter();
			DataTable tableCOL = new DataTable();

			MySqlDataAdapter adapterMAS = new MySqlDataAdapter();
			DataTable tableMAS = new DataTable();

			MySqlDataAdapter adapterEMP = new MySqlDataAdapter();
			DataTable tableEMP = new DataTable();

			MySqlCommand commandELEM = new MySqlCommand("SELECT * FROM `elementary` WHERE `lrn` = @search", db.getConnection);
			commandELEM.Parameters.Add("@search", MySqlDbType.VarChar).Value = SearchBox.Text;

			MySqlCommand commandJR = new MySqlCommand("SELECT * FROM `juniorhigh` WHERE `lrn` = @search", db.getConnection);
			commandJR.Parameters.Add("@search", MySqlDbType.VarChar).Value = SearchBox.Text;

			MySqlCommand commandSR = new MySqlCommand("SELECT * FROM `seniorhigh` WHERE `lrn` = @search", db.getConnection);
			commandSR.Parameters.Add("@search", MySqlDbType.VarChar).Value = SearchBox.Text;

			MySqlCommand commandCOL = new MySqlCommand("SELECT * FROM `college` WHERE `idno` = @search", db.getConnection);
			commandCOL.Parameters.Add("@search", MySqlDbType.VarChar).Value = SearchBox.Text;

			MySqlCommand commandMAS = new MySqlCommand("SELECT * FROM `masteral` WHERE `idno` = @search", db.getConnection);
			commandMAS.Parameters.Add("@search", MySqlDbType.VarChar).Value = SearchBox.Text;

			MySqlCommand commandEMP = new MySqlCommand("SELECT * FROM `employee` WHERE `idnumber` = @search", db.getConnection);
			commandEMP.Parameters.Add("@search", MySqlDbType.VarChar).Value = SearchBox.Text;

			adapterELEM.SelectCommand = commandELEM;
			adapterELEM.Fill(tableELEM);

			adapterJR.SelectCommand = commandJR;
			adapterJR.Fill(tableJR);

			adapterSR.SelectCommand = commandSR;
			adapterSR.Fill(tableJR);

			adapterCOL.SelectCommand = commandCOL;
			adapterCOL.Fill(tableCOL);

			adapterMAS.SelectCommand = commandMAS;
			adapterMAS.Fill(tableMAS);

			adapterEMP.SelectCommand = commandEMP;
			adapterEMP.Fill(tableEMP);


			if (tableELEM.Rows.Count > 0)
			{
				//show lrn
				idNumber.Text = tableELEM.Rows[0][0].ToString();

				//show fullname
				fullname.Text = tableELEM.Rows[0][2].ToString() + " " + tableELEM.Rows[0][3].ToString() + " " + tableELEM.Rows[0][4].ToString();

				//show grade
				course_year.Text = tableELEM.Rows[0][6].ToString();

				//show picture
				byte[] pic;
				pic = (byte[])tableELEM.Rows[0][11];
				MemoryStream picture = new MemoryStream(pic);
				pictureBox1.Image = Image.FromStream(picture);
				Show();

				//show barcode
				byte[] bar;
				bar = (byte[])tableELEM.Rows[0][13];
				MemoryStream barcode = new MemoryStream(bar);
				pictureBox2.Image = Image.FromStream(barcode);
				Show();
			}
			else if (tableJR.Rows.Count > 0)
			{
				//show lrn
				idNumber.Text = tableJR.Rows[0][0].ToString();

				//show fullname
				fullname.Text = tableJR.Rows[0][2].ToString() + " " + tableJR.Rows[0][3].ToString() + " " + tableJR.Rows[0][4].ToString();

				//show grade/group
				course_year.Text = tableJR.Rows[0][6].ToString() + " - " + tableJR.Rows[0][7].ToString();

				//show picture
				byte[] pic;
				pic = (byte[])tableJR.Rows[0][12];
				MemoryStream picture = new MemoryStream(pic);
				pictureBox1.Image = Image.FromStream(picture);
				Show();

				//show barcode
				byte[] bar;
				bar = (byte[])tableJR.Rows[0][14];
				MemoryStream barcode = new MemoryStream(bar);
				pictureBox2.Image = Image.FromStream(barcode);
				Show();

			}
			else if (tableSR.Rows.Count > 0)
			{
				//show lrn
				idNumber.Text = tableSR.Rows[0][0].ToString();

				//show fullname
				fullname.Text = tableSR.Rows[0][2].ToString() + " " + tableSR.Rows[0][3].ToString() + " " + tableSR.Rows[0][4].ToString();

				//show grade
				course_year.Text = tableSR.Rows[0][6].ToString() + " - " + tableSR.Rows[0][7].ToString();

				//show picture
				byte[] pic;
				pic = (byte[])tableSR.Rows[0][12];
				MemoryStream picture = new MemoryStream(pic);
				pictureBox1.Image = Image.FromStream(picture);
				Show();

				//show barcode
				byte[] bar;
				bar = (byte[])tableSR.Rows[0][14];
				MemoryStream barcode = new MemoryStream(bar);
				pictureBox2.Image = Image.FromStream(barcode);
				Show();
			}
			else if (tableCOL.Rows.Count > 0)
			{
				//show idno
				string myid = tableCOL.Rows[0][0].ToString();
				var builder = new StringBuilder();
				int count = 0;
				foreach (var c in myid)
				{
					builder.Append(c);
					if (++count == 2)
					{
						builder.Append('-');
					}
				}
				myid = builder.ToString();
				idNumber.Text = myid;

				//show fullname
				fullname.Text = tableCOL.Rows[0][1].ToString() + " " + tableCOL.Rows[0][2].ToString() + " " + tableCOL.Rows[0][3].ToString();

				//show course and year
				course_year.Text = tableCOL.Rows[0][5].ToString() + " - " + tableCOL.Rows[0][6].ToString();

				//show picture
				byte[] pic;
				pic = (byte[])tableCOL.Rows[0][11];
				MemoryStream picture = new MemoryStream(pic);
				pictureBox1.Image = Image.FromStream(picture);
				Show();

				//show barcode
				byte[] bar;
				bar = (byte[])tableCOL.Rows[0][13];
				MemoryStream barcode = new MemoryStream(bar);
				pictureBox2.Image = Image.FromStream(barcode);
				Show();
			}
			else if (tableMAS.Rows.Count > 0)
			{
				//show idno
				string myid = tableMAS.Rows[0][0].ToString();
				var builder = new StringBuilder();
				int count = 0;
				foreach (var c in myid)
				{
					builder.Append(c);
					if (++count == 2)
					{
						builder.Append('-');
					}
				}
				myid = builder.ToString();
				idNumber.Text = myid;

				//show fullname
				fullname.Text = tableMAS.Rows[0][1].ToString() + " " + tableMAS.Rows[0][2].ToString() + " " + tableMAS.Rows[0][3].ToString();

				//show course
				course_year.Text = tableMAS.Rows[0][5].ToString();

				//show picture
				byte[] pic;
				pic = (byte[])tableMAS.Rows[0][10];
				MemoryStream picture = new MemoryStream(pic);
				pictureBox1.Image = Image.FromStream(picture);
				Show();

				//show barcode
				byte[] bar;
				bar = (byte[])tableMAS.Rows[0][12];
				MemoryStream barcode = new MemoryStream(bar);
				pictureBox2.Image = Image.FromStream(barcode);
				Show();
			}

			else if (tableEMP.Rows.Count > 0)
			{
				//show id number
				idNumber.Text = tableEMP.Rows[0][0].ToString();

				//show fullname
				string fname = tableEMP.Rows[0][3].ToString() + " " + tableEMP.Rows[0][4].ToString() + " " + tableEMP.Rows[0][5].ToString();
				fullname.Text = fname;

				//show designation
				course_year.Text = tableEMP.Rows[0][6].ToString();

				//show picture
				byte[] pic;
				pic = (byte[])tableEMP.Rows[0][2];
				MemoryStream picture = new MemoryStream(pic);
				pictureBox1.Image = Image.FromStream(picture);
				Show();

				//show QRcode
				byte[] bar;
				bar = (byte[])tableEMP.Rows[0][1];
				MemoryStream barcode = new MemoryStream(bar);
				pictureBox2.Image = Image.FromStream(barcode);
				Show();
			}

			else
			{
				idNumber.Text = "NO RECORD";
				fullname.Text = "";
				course_year.Text = "";
				pictureBox1.Image = null;
				pictureBox2.Image = null;
			}
		}

		private void SearchBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				MyQuery();
				SelectSearchBox();
			}
		}
	}
}
