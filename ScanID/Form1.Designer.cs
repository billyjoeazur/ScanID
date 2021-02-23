namespace ScanID
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.SearchBox = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.fullname = new System.Windows.Forms.Label();
			this.course_year = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.idNumber = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.LabelDate = new System.Windows.Forms.Label();
			this.LabelTime = new System.Windows.Forms.Label();
			this.tableLayoutBaseContainer = new System.Windows.Forms.TableLayoutPanel();
			this.tableBody = new System.Windows.Forms.TableLayoutPanel();
			this.tableID = new System.Windows.Forms.TableLayoutPanel();
			this.tableINFO = new System.Windows.Forms.TableLayoutPanel();
			this.timeInOut = new System.Windows.Forms.Label();
			this.tableIDwelcome = new System.Windows.Forms.TableLayoutPanel();
			this.tableHeader = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.tableDateTime = new System.Windows.Forms.TableLayoutPanel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.tableLayoutBaseContainer.SuspendLayout();
			this.tableBody.SuspendLayout();
			this.tableID.SuspendLayout();
			this.tableINFO.SuspendLayout();
			this.tableIDwelcome.SuspendLayout();
			this.tableHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.tableDateTime.SuspendLayout();
			this.SuspendLayout();
			// 
			// SearchBox
			// 
			this.SearchBox.Location = new System.Drawing.Point(3, 3);
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.Size = new System.Drawing.Size(149, 20);
			this.SearchBox.TabIndex = 0;
			this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(610, 381);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// fullname
			// 
			this.fullname.AutoSize = true;
			this.fullname.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fullname.Location = new System.Drawing.Point(3, 228);
			this.fullname.Name = "fullname";
			this.fullname.Size = new System.Drawing.Size(604, 76);
			this.fullname.TabIndex = 5;
			this.fullname.Text = "FULL NAME";
			this.fullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// course_year
			// 
			this.course_year.AutoSize = true;
			this.course_year.Dock = System.Windows.Forms.DockStyle.Fill;
			this.course_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.course_year.Location = new System.Drawing.Point(3, 304);
			this.course_year.Name = "course_year";
			this.course_year.Size = new System.Drawing.Size(604, 77);
			this.course_year.TabIndex = 6;
			this.course_year.Text = "COURSE - YEAR";
			this.course_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.pictureBox2.Location = new System.Drawing.Point(210, 155);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(190, 70);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// idNumber
			// 
			this.idNumber.AutoSize = true;
			this.idNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.idNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idNumber.Location = new System.Drawing.Point(3, 76);
			this.idNumber.Name = "idNumber";
			this.idNumber.Size = new System.Drawing.Size(604, 76);
			this.idNumber.TabIndex = 8;
			this.idNumber.Text = "ID NUMBER";
			this.idNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 114);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// LabelDate
			// 
			this.LabelDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelDate.AutoSize = true;
			this.LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelDate.Location = new System.Drawing.Point(726, 0);
			this.LabelDate.Name = "LabelDate";
			this.LabelDate.Size = new System.Drawing.Size(346, 54);
			this.LabelDate.TabIndex = 10;
			this.LabelDate.Text = "Monday, 22 February, 2021";
			this.LabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelTime
			// 
			this.LabelTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelTime.AutoSize = true;
			this.LabelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelTime.Location = new System.Drawing.Point(871, 54);
			this.LabelTime.Name = "LabelTime";
			this.LabelTime.Size = new System.Drawing.Size(201, 81);
			this.LabelTime.TabIndex = 11;
			this.LabelTime.Text = "8:00:00 PM";
			this.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutBaseContainer
			// 
			this.tableLayoutBaseContainer.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tableLayoutBaseContainer.ColumnCount = 1;
			this.tableLayoutBaseContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutBaseContainer.Controls.Add(this.tableBody, 0, 1);
			this.tableLayoutBaseContainer.Controls.Add(this.tableHeader, 0, 0);
			this.tableLayoutBaseContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutBaseContainer.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutBaseContainer.Name = "tableLayoutBaseContainer";
			this.tableLayoutBaseContainer.RowCount = 2;
			this.tableLayoutBaseContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutBaseContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tableLayoutBaseContainer.Size = new System.Drawing.Size(1244, 589);
			this.tableLayoutBaseContainer.TabIndex = 12;
			// 
			// tableBody
			// 
			this.tableBody.ColumnCount = 1;
			this.tableBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableBody.Controls.Add(this.tableID, 0, 1);
			this.tableBody.Controls.Add(this.tableIDwelcome, 0, 0);
			this.tableBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableBody.Location = new System.Drawing.Point(3, 150);
			this.tableBody.Name = "tableBody";
			this.tableBody.RowCount = 2;
			this.tableBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
			this.tableBody.Size = new System.Drawing.Size(1238, 436);
			this.tableBody.TabIndex = 13;
			// 
			// tableID
			// 
			this.tableID.ColumnCount = 2;
			this.tableID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableID.Controls.Add(this.tableINFO, 1, 0);
			this.tableID.Controls.Add(this.pictureBox1, 0, 0);
			this.tableID.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableID.Location = new System.Drawing.Point(3, 46);
			this.tableID.Name = "tableID";
			this.tableID.RowCount = 1;
			this.tableID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableID.Size = new System.Drawing.Size(1232, 387);
			this.tableID.TabIndex = 13;
			// 
			// tableINFO
			// 
			this.tableINFO.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tableINFO.ColumnCount = 1;
			this.tableINFO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableINFO.Controls.Add(this.timeInOut, 0, 0);
			this.tableINFO.Controls.Add(this.idNumber, 0, 1);
			this.tableINFO.Controls.Add(this.pictureBox2, 0, 2);
			this.tableINFO.Controls.Add(this.course_year, 0, 4);
			this.tableINFO.Controls.Add(this.fullname, 0, 3);
			this.tableINFO.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableINFO.Location = new System.Drawing.Point(619, 3);
			this.tableINFO.Name = "tableINFO";
			this.tableINFO.RowCount = 5;
			this.tableINFO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableINFO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableINFO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableINFO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableINFO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableINFO.Size = new System.Drawing.Size(610, 381);
			this.tableINFO.TabIndex = 13;
			// 
			// timeInOut
			// 
			this.timeInOut.AutoSize = true;
			this.timeInOut.Dock = System.Windows.Forms.DockStyle.Fill;
			this.timeInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeInOut.Location = new System.Drawing.Point(3, 0);
			this.timeInOut.Name = "timeInOut";
			this.timeInOut.Size = new System.Drawing.Size(604, 76);
			this.timeInOut.TabIndex = 9;
			this.timeInOut.Text = "TIME IN/OUT";
			this.timeInOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableIDwelcome
			// 
			this.tableIDwelcome.ColumnCount = 2;
			this.tableIDwelcome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.58117F));
			this.tableIDwelcome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.41883F));
			this.tableIDwelcome.Controls.Add(this.SearchBox, 0, 0);
			this.tableIDwelcome.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableIDwelcome.Location = new System.Drawing.Point(3, 3);
			this.tableIDwelcome.Name = "tableIDwelcome";
			this.tableIDwelcome.RowCount = 1;
			this.tableIDwelcome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableIDwelcome.Size = new System.Drawing.Size(1232, 37);
			this.tableIDwelcome.TabIndex = 13;
			// 
			// tableHeader
			// 
			this.tableHeader.BackColor = System.Drawing.Color.LightGray;
			this.tableHeader.ColumnCount = 2;
			this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.70161F));
			this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.29839F));
			this.tableHeader.Controls.Add(this.pictureBox3, 0, 0);
			this.tableHeader.Controls.Add(this.tableDateTime, 1, 0);
			this.tableHeader.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableHeader.Location = new System.Drawing.Point(3, 3);
			this.tableHeader.Name = "tableHeader";
			this.tableHeader.RowCount = 1;
			this.tableHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableHeader.Size = new System.Drawing.Size(1238, 141);
			this.tableHeader.TabIndex = 0;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::ScanID.Properties.Resources.AppHeader;
			this.pictureBox3.Location = new System.Drawing.Point(3, 3);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(151, 135);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// tableDateTime
			// 
			this.tableDateTime.ColumnCount = 1;
			this.tableDateTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableDateTime.Controls.Add(this.LabelDate, 0, 0);
			this.tableDateTime.Controls.Add(this.LabelTime, 0, 1);
			this.tableDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableDateTime.Location = new System.Drawing.Point(160, 3);
			this.tableDateTime.Name = "tableDateTime";
			this.tableDateTime.RowCount = 2;
			this.tableDateTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableDateTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableDateTime.Size = new System.Drawing.Size(1075, 135);
			this.tableDateTime.TabIndex = 13;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1244, 589);
			this.Controls.Add(this.tableLayoutBaseContainer);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.tableLayoutBaseContainer.ResumeLayout(false);
			this.tableBody.ResumeLayout(false);
			this.tableID.ResumeLayout(false);
			this.tableINFO.ResumeLayout(false);
			this.tableINFO.PerformLayout();
			this.tableIDwelcome.ResumeLayout(false);
			this.tableIDwelcome.PerformLayout();
			this.tableHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.tableDateTime.ResumeLayout(false);
			this.tableDateTime.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox SearchBox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label fullname;
		private System.Windows.Forms.Label course_year;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label idNumber;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label LabelDate;
		private System.Windows.Forms.Label LabelTime;
		private System.Windows.Forms.TableLayoutPanel tableLayoutBaseContainer;
		private System.Windows.Forms.TableLayoutPanel tableBody;
		private System.Windows.Forms.TableLayoutPanel tableID;
		private System.Windows.Forms.TableLayoutPanel tableIDwelcome;
		private System.Windows.Forms.TableLayoutPanel tableHeader;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.TableLayoutPanel tableDateTime;
		private System.Windows.Forms.TableLayoutPanel tableINFO;
		private System.Windows.Forms.Label timeInOut;
		private System.Windows.Forms.Timer timer1;
	}
}

