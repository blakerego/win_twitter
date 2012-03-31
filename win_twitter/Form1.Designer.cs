namespace TwitterSearch
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mTweetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUsernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mPgBox = new System.Windows.Forms.NumericUpDown();
            this.mGoToPageBtn = new System.Windows.Forms.Button();
            this.mExportBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mBeforeDate = new System.Windows.Forms.DateTimePicker();
            this.mTweetsBeforeChk = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mAfterDate = new System.Windows.Forms.DateTimePicker();
            this.mTweetsAfterChk = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mPgBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.69111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.30889F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.93313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.06687F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(602, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.HandleSearchClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mTweetColumn,
            this.mDate,
            this.mUsernameColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 298);
            this.dataGridView1.TabIndex = 3;
            // 
            // mTweetColumn
            // 
            this.mTweetColumn.HeaderText = "Tweet";
            this.mTweetColumn.Name = "mTweetColumn";
            this.mTweetColumn.Width = 300;
            // 
            // mDate
            // 
            this.mDate.HeaderText = "Date";
            this.mDate.Name = "mDate";
            // 
            // mUsernameColumn
            // 
            this.mUsernameColumn.HeaderText = "User";
            this.mUsernameColumn.Name = "mUsernameColumn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.mExportBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(602, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 298);
            this.panel1.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 273);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mPgBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mGoToPageBtn);
            this.splitContainer1.Size = new System.Drawing.Size(161, 22);
            this.splitContainer1.SplitterDistance = 76;
            this.splitContainer1.TabIndex = 3;
            // 
            // mPgBox
            // 
            this.mPgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPgBox.Enabled = false;
            this.mPgBox.Location = new System.Drawing.Point(0, 0);
            this.mPgBox.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.mPgBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mPgBox.Name = "mPgBox";
            this.mPgBox.ReadOnly = true;
            this.mPgBox.Size = new System.Drawing.Size(76, 20);
            this.mPgBox.TabIndex = 5;
            this.mPgBox.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.mPgBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mGoToPageBtn
            // 
            this.mGoToPageBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mGoToPageBtn.Enabled = false;
            this.mGoToPageBtn.Location = new System.Drawing.Point(0, 0);
            this.mGoToPageBtn.Name = "mGoToPageBtn";
            this.mGoToPageBtn.Size = new System.Drawing.Size(81, 22);
            this.mGoToPageBtn.TabIndex = 4;
            this.mGoToPageBtn.Text = "go to page";
            this.mGoToPageBtn.UseVisualStyleBackColor = true;
            this.mGoToPageBtn.Click += new System.EventHandler(this.HandleSearchClicked);
            // 
            // mExportBtn
            // 
            this.mExportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mExportBtn.Enabled = false;
            this.mExportBtn.Location = new System.Drawing.Point(3, 3);
            this.mExportBtn.Name = "mExportBtn";
            this.mExportBtn.Size = new System.Drawing.Size(161, 23);
            this.mExportBtn.TabIndex = 0;
            this.mExportBtn.Text = "Export";
            this.mExportBtn.UseVisualStyleBackColor = true;
            this.mExportBtn.Click += new System.EventHandler(this.HandleExport);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(599, 66);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(599, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(593, 40);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mTweetsAfterChk);
            this.panel2.Controls.Add(this.mAfterDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 40);
            this.panel2.TabIndex = 0;
            // 
            // mBeforeDate
            // 
            this.mBeforeDate.Enabled = false;
            this.mBeforeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mBeforeDate.Location = new System.Drawing.Point(133, 0);
            this.mBeforeDate.Margin = new System.Windows.Forms.Padding(0);
            this.mBeforeDate.Name = "mBeforeDate";
            this.mBeforeDate.Size = new System.Drawing.Size(123, 20);
            this.mBeforeDate.TabIndex = 1;
            this.mBeforeDate.Value = new System.DateTime(2011, 7, 21, 0, 0, 0, 0);
            // 
            // mTweetsBeforeChk
            // 
            this.mTweetsBeforeChk.AutoSize = true;
            this.mTweetsBeforeChk.Location = new System.Drawing.Point(3, 3);
            this.mTweetsBeforeChk.Name = "mTweetsBeforeChk";
            this.mTweetsBeforeChk.Size = new System.Drawing.Size(127, 17);
            this.mTweetsBeforeChk.TabIndex = 0;
            this.mTweetsBeforeChk.Text = "Tweets on or before: ";
            this.mTweetsBeforeChk.UseVisualStyleBackColor = true;
            this.mTweetsBeforeChk.CheckedChanged += new System.EventHandler(this.HandleBeforeCheckChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mBeforeDate);
            this.panel3.Controls.Add(this.mTweetsBeforeChk);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(296, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 40);
            this.panel3.TabIndex = 1;
            // 
            // mAfterDate
            // 
            this.mAfterDate.Enabled = false;
            this.mAfterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mAfterDate.Location = new System.Drawing.Point(127, 1);
            this.mAfterDate.Margin = new System.Windows.Forms.Padding(0);
            this.mAfterDate.Name = "mAfterDate";
            this.mAfterDate.Size = new System.Drawing.Size(123, 20);
            this.mAfterDate.TabIndex = 2;
            // 
            // mTweetsAfterChk
            // 
            this.mTweetsAfterChk.AutoSize = true;
            this.mTweetsAfterChk.Location = new System.Drawing.Point(9, 3);
            this.mTweetsAfterChk.Name = "mTweetsAfterChk";
            this.mTweetsAfterChk.Size = new System.Drawing.Size(115, 17);
            this.mTweetsAfterChk.TabIndex = 0;
            this.mTweetsAfterChk.Text = "Tweets on or after:";
            this.mTweetsAfterChk.UseVisualStyleBackColor = true;
            this.mTweetsAfterChk.CheckedChanged += new System.EventHandler(this.HandleAfterCheckChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 370);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Twitter Search Tool. by Blake";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mPgBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button mExportBtn;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button mGoToPageBtn;
		private System.Windows.Forms.NumericUpDown mPgBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn mTweetColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn mUsernameColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker mBeforeDate;
        private System.Windows.Forms.CheckBox mTweetsBeforeChk;
        private System.Windows.Forms.CheckBox mTweetsAfterChk;
        private System.Windows.Forms.DateTimePicker mAfterDate;
	}
}

