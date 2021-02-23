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
			DateTime datetoday = DateTime.Now;
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

			MySqlDataAdapter adapterEMPattendance = new MySqlDataAdapter();
			DataTable tableEMPattendance = new DataTable();

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

			MySqlCommand commandEMPattendance = new MySqlCommand("SELECT * FROM `employeeattendance` WHERE `idno` = @search AND `datetoday` = @datetoday", db.getConnection);
			commandEMPattendance.Parameters.Add("@search", MySqlDbType.VarChar).Value = SearchBox.Text;
			commandEMPattendance.Parameters.Add("@datetoday", MySqlDbType.VarChar).Value = datetoday.ToLongDateString();

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

			adapterEMPattendance.SelectCommand = commandEMPattendance;
			adapterEMPattendance.Fill(tableEMPattendance);


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
				timeInOut.Text = "";
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
				timeInOut.Text = "";

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
				timeInOut.Text = "";
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
				timeInOut.Text = "";
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

				timeInOut.Text = "";
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

				DateTime today = DateTime.Now;
				
				if(tableEMPattendance.Rows.Count == 0)
				{
					TryAdd(SearchBox.Text, today.ToLongDateString(), today.ToLongTimeString());
					timeInOut.Text = "TIME IN: " +  today.ToLongTimeString();
					timeInOut.ForeColor = Color.Green;
				}
				else
				{
					if (tableEMPattendance.Rows[0][2].ToString() == today.ToLongDateString() && tableEMPattendance.Rows[0][4].ToString() == "")
					{
						TryUpdate(tableEMP.Rows[0][0].ToString(), today.ToLongTimeString());
						timeInOut.Text = "TIME OUT: " + today.ToLongTimeString();
						timeInOut.ForeColor = Color.Red;
					}
					else if (tableEMPattendance.Rows[0][2].ToString() == today.ToLongDateString() && tableEMPattendance.Rows[0][5].ToString() == "")
					{
						TryUpdateIN2(tableEMP.Rows[0][0].ToString(), today.ToLongTimeString());
						timeInOut.Text = "TIME IN: " + today.ToLongTimeString();
						timeInOut.ForeColor = Color.Green;
					}
					else if (tableEMPattendance.Rows[0][2].ToString() == today.ToLongDateString() && tableEMPattendance.Rows[0][6].ToString() == "")
					{
						TryUpdateOUT2(tableEMP.Rows[0][0].ToString(), today.ToLongTimeString());
						timeInOut.Text = "TIME OUT: " + today.ToLongTimeString();
						timeInOut.ForeColor = Color.Red;
					}
					else if (tableEMPattendance.Rows[0][2].ToString() == today.ToLongDateString() && tableEMPattendance.Rows[0][7].ToString() == "")
					{
						TryUpdateIN3(tableEMP.Rows[0][0].ToString(), today.ToLongTimeString());
						timeInOut.Text = "TIME IN: " + today.ToLongTimeString();
						timeInOut.ForeColor = Color.Green;
					}
					else if (tableEMPattendance.Rows[0][2].ToString() == today.ToLongDateString() && tableEMPattendance.Rows[0][8].ToString() == "")
					{
						TryUpdateOUT3(tableEMP.Rows[0][0].ToString(), today.ToLongTimeString());
						timeInOut.Text = "TIME OUT: " + today.ToLongTimeString();
						timeInOut.ForeColor = Color.Red;
					}


				}
				//label2.Text = tableEMPattendance.Rows[0][4].ToString();
				//label3.Text = "";
			}

			else
			{
				idNumber.Text = "NO RECORD";
				fullname.Text = "";
				course_year.Text = "";
				pictureBox1.Image = null;
				pictureBox2.Image = null;
				timeInOut.Text = "";
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

		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void TryAdd(string idno, string datetoday, string in1)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `employeeattendance`(`idno`, `datetoday`, `in1`) VALUES (@idno,@datetoday,@in1)", db.getConnection);
			command.Parameters.Add("@idno", MySqlDbType.VarChar).Value = idno;
			command.Parameters.Add("@datetoday", MySqlDbType.VarChar).Value = datetoday;
			command.Parameters.Add("@in1", MySqlDbType.VarChar).Value = in1;
			db.openConnection();
			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
			}
			else
			{
				db.closeConnection();
			}
		}

		private void TryUpdate(string idno, string out1)
		{
			MySqlCommand command = new MySqlCommand("UPDATE `employeeattendance` SET `out1`=@out1 WHERE `idno`=@idno", db.getConnection);
			command.Parameters.Add("@idno", MySqlDbType.VarChar).Value = idno;
			command.Parameters.Add("@out1", MySqlDbType.VarChar).Value = out1;
			db.openConnection();
			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
			}
			else
			{
				db.closeConnection();
			}
		}

		private void TryUpdateIN2(string idno, string in2)
		{
			MySqlCommand command = new MySqlCommand("UPDATE `employeeattendance` SET `in2`=@in2 WHERE `idno`=@idno", db.getConnection);
			command.Parameters.Add("@idno", MySqlDbType.VarChar).Value = idno;
			command.Parameters.Add("@in2", MySqlDbType.VarChar).Value = in2;
			db.openConnection();
			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
			}
			else
			{
				db.closeConnection();
			}
		}

		private void TryUpdateOUT2(string idno, string out2)
		{
			MySqlCommand command = new MySqlCommand("UPDATE `employeeattendance` SET `out2`=@out2 WHERE `idno`=@idno", db.getConnection);
			command.Parameters.Add("@idno", MySqlDbType.VarChar).Value = idno;
			command.Parameters.Add("@out2", MySqlDbType.VarChar).Value = out2;
			db.openConnection();
			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
			}
			else
			{
				db.closeConnection();
			}
		}

		private void TryUpdateIN3(string idno, string in3)
		{
			MySqlCommand command = new MySqlCommand("UPDATE `employeeattendance` SET `in3`=@in3 WHERE `idno`=@idno", db.getConnection);
			command.Parameters.Add("@idno", MySqlDbType.VarChar).Value = idno;
			command.Parameters.Add("@in3", MySqlDbType.VarChar).Value = in3;
			db.openConnection();
			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
			}
			else
			{
				db.closeConnection();
			}
		}

		private void TryUpdateOUT3(string idno, string out3)
		{
			MySqlCommand command = new MySqlCommand("UPDATE `employeeattendance` SET `out3`=@out3 WHERE `idno`=@idno", db.getConnection);
			command.Parameters.Add("@idno", MySqlDbType.VarChar).Value = idno;
			command.Parameters.Add("@out3", MySqlDbType.VarChar).Value = out3;
			db.openConnection();
			if (command.ExecuteNonQuery() == 1)
			{
				db.closeConnection();
			}
			else
			{
				db.closeConnection();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{

			LabelDate.Text = DateTime.Now.ToLongDateString();
			LabelTime.Text = DateTime.Now.ToLongTimeString();
		}
	}
}
