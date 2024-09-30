namespace WinFormsApp_taskDB
{
    partial class Project
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1 = new TabControl();
            Create = new TabPage();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            Submit = new Button();
            Read = new TabPage();
            View2 = new DataGridView();
            Update = new TabPage();
            k = new TextBox();
            SearchbyName = new Label();
            UpdateTable = new Button();
            textBox8 = new TextBox();
            CourseName = new Label();
            textBox7 = new TextBox();
            Age = new Label();
            textBox6 = new TextBox();
            NewName = new Label();
            textBox5 = new TextBox();
            Id = new Label();
            Delete = new TabPage();
            Remove = new Button();
            ViewForData = new DataGridView();
            IdDelete = new TextBox();
            label4 = new Label();
            Course = new TabPage();
            CourseData = new DataGridView();
            OrderbyId = new Button();
            GroupByName = new Button();
            OrderByName = new Button();
            GroupByage = new Button();
            label5 = new Label();
            Search = new TextBox();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            Create.SuspendLayout();
            Read.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)View2).BeginInit();
            Update.SuspendLayout();
            Delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewForData).BeginInit();
            Course.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CourseData).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Cornsilk;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(505, 258);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Cornsilk;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(1113, 41);
            button1.Name = "button1";
            button1.Size = new Size(130, 33);
            button1.TabIndex = 1;
            button1.Text = "Update Console";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Create);
            tabControl1.Controls.Add(Read);
            tabControl1.Controls.Add(Update);
            tabControl1.Controls.Add(Delete);
            tabControl1.Controls.Add(Course);
            tabControl1.Location = new Point(659, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(413, 287);
            tabControl1.TabIndex = 4;
            // 
            // Create
            // 
            Create.BackColor = Color.Cornsilk;
            Create.Controls.Add(label3);
            Create.Controls.Add(label2);
            Create.Controls.Add(textBox4);
            Create.Controls.Add(textBox3);
            Create.Controls.Add(textBox2);
            Create.Controls.Add(label1);
            Create.Controls.Add(Submit);
            Create.Location = new Point(4, 29);
            Create.Name = "Create";
            Create.Padding = new Padding(3);
            Create.Size = new Size(405, 254);
            Create.TabIndex = 1;
            Create.Text = "Create";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 56);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 6;
            label3.Text = "Subject id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 56);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 5;
            label2.Text = "Age";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.AliceBlue;
            textBox4.Location = new Point(173, 79);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.AliceBlue;
            textBox3.Location = new Point(3, 79);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.AliceBlue;
            textBox2.Location = new Point(0, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(298, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 3);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // Submit
            // 
            Submit.BackColor = Color.PowderBlue;
            Submit.Location = new Point(148, 171);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 0;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // Read
            // 
            Read.Controls.Add(View2);
            Read.Location = new Point(4, 29);
            Read.Name = "Read";
            Read.Size = new Size(405, 254);
            Read.TabIndex = 2;
            Read.Text = "Read";
            Read.UseVisualStyleBackColor = true;
            // 
            // View2
            // 
            View2.BackgroundColor = Color.Cornsilk;
            View2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            View2.Location = new Point(-4, 0);
            View2.Name = "View2";
            View2.RowHeadersWidth = 51;
            View2.Size = new Size(406, 217);
            View2.TabIndex = 0;
            View2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // Update
            // 
            Update.BackColor = Color.Ivory;
            Update.Controls.Add(k);
            Update.Controls.Add(SearchbyName);
            Update.Controls.Add(UpdateTable);
            Update.Controls.Add(textBox8);
            Update.Controls.Add(CourseName);
            Update.Controls.Add(textBox7);
            Update.Controls.Add(Age);
            Update.Controls.Add(textBox6);
            Update.Controls.Add(NewName);
            Update.Controls.Add(textBox5);
            Update.Controls.Add(Id);
            Update.Location = new Point(4, 29);
            Update.Name = "Update";
            Update.Size = new Size(405, 254);
            Update.TabIndex = 3;
            Update.Text = "Update";
            Update.Click += tabPage6_Click;
            // 
            // k
            // 
            k.BackColor = Color.AliceBlue;
            k.Location = new Point(53, 5);
            k.Name = "k";
            k.Size = new Size(143, 27);
            k.TabIndex = 9;
            k.TextChanged += textBox1_TextChanged_1;
            // 
            // SearchbyName
            // 
            SearchbyName.AutoSize = true;
            SearchbyName.Location = new Point(3, 8);
            SearchbyName.Name = "SearchbyName";
            SearchbyName.Size = new Size(49, 20);
            SearchbyName.TabIndex = 9;
            SearchbyName.Text = "Name";
            // 
            // UpdateTable
            // 
            UpdateTable.Location = new Point(165, 169);
            UpdateTable.Name = "UpdateTable";
            UpdateTable.Size = new Size(94, 29);
            UpdateTable.TabIndex = 8;
            UpdateTable.Text = "Update";
            UpdateTable.UseVisualStyleBackColor = true;
            UpdateTable.Click += UpdateTable_Click;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.AliceBlue;
            textBox8.Location = new Point(225, 115);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(88, 27);
            textBox8.TabIndex = 7;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // CourseName
            // 
            CourseName.AutoSize = true;
            CourseName.Location = new Point(225, 92);
            CourseName.Name = "CourseName";
            CourseName.Size = new Size(71, 20);
            CourseName.TabIndex = 6;
            CourseName.Text = "Course Id";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.AliceBlue;
            textBox7.Location = new Point(81, 115);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(84, 27);
            textBox7.TabIndex = 5;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Location = new Point(81, 92);
            Age.Name = "Age";
            Age.Size = new Size(36, 20);
            Age.TabIndex = 4;
            Age.Text = "Age";
            Age.Click += label4_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.AliceBlue;
            textBox6.Location = new Point(81, 62);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(232, 27);
            textBox6.TabIndex = 3;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // NewName
            // 
            NewName.AutoSize = true;
            NewName.Location = new Point(146, 35);
            NewName.Name = "NewName";
            NewName.Size = new Size(83, 20);
            NewName.TabIndex = 2;
            NewName.Text = "New Name";
            NewName.Click += NewName_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.AliceBlue;
            textBox5.Location = new Point(225, 6);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 1;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(202, 8);
            Id.Name = "Id";
            Id.Size = new Size(22, 20);
            Id.TabIndex = 0;
            Id.Text = "Id";
            // 
            // Delete
            // 
            Delete.Controls.Add(Remove);
            Delete.Controls.Add(ViewForData);
            Delete.Controls.Add(IdDelete);
            Delete.Controls.Add(label4);
            Delete.Location = new Point(4, 29);
            Delete.Name = "Delete";
            Delete.Padding = new Padding(3);
            Delete.Size = new Size(405, 254);
            Delete.TabIndex = 4;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            Remove.BackColor = Color.Cornsilk;
            Remove.Location = new Point(247, 9);
            Remove.Name = "Remove";
            Remove.Size = new Size(94, 29);
            Remove.TabIndex = 3;
            Remove.Text = "Delete";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += Remove_Click;
            // 
            // ViewForData
            // 
            ViewForData.BackgroundColor = Color.Cornsilk;
            ViewForData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewForData.Location = new Point(3, 89);
            ViewForData.Name = "ViewForData";
            ViewForData.RowHeadersWidth = 51;
            ViewForData.Size = new Size(402, 165);
            ViewForData.TabIndex = 2;
            ViewForData.CellContentClick += ViewForData_CellContentClick;
            // 
            // IdDelete
            // 
            IdDelete.BackColor = Color.Azure;
            IdDelete.Location = new Point(43, 13);
            IdDelete.Name = "IdDelete";
            IdDelete.Size = new Size(125, 27);
            IdDelete.TabIndex = 1;
            IdDelete.TextChanged += IdDelete_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 13);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 0;
            label4.Text = "Id";
            // 
            // Course
            // 
            Course.Controls.Add(CourseData);
            Course.Location = new Point(4, 29);
            Course.Name = "Course";
            Course.Size = new Size(405, 254);
            Course.TabIndex = 5;
            Course.Text = "Course";
            Course.UseVisualStyleBackColor = true;
            // 
            // CourseData
            // 
            CourseData.BackgroundColor = Color.Cornsilk;
            CourseData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CourseData.Location = new Point(3, 3);
            CourseData.Name = "CourseData";
            CourseData.RowHeadersWidth = 51;
            CourseData.Size = new Size(399, 215);
            CourseData.TabIndex = 0;
            CourseData.CellContentClick += CourseData_CellContentClick;
            // 
            // OrderbyId
            // 
            OrderbyId.Location = new Point(113, 2);
            OrderbyId.Name = "OrderbyId";
            OrderbyId.Size = new Size(94, 29);
            OrderbyId.TabIndex = 5;
            OrderbyId.Text = "Id ";
            OrderbyId.UseVisualStyleBackColor = false;
            OrderbyId.Click += button2_Click_2;
            // 
            // GroupByName
            // 
            GroupByName.BackColor = SystemColors.Window;
            GroupByName.Location = new Point(213, 2);
            GroupByName.Name = "GroupByName";
            GroupByName.Size = new Size(94, 29);
            GroupByName.TabIndex = 5;
            GroupByName.Text = "Name";
            GroupByName.UseVisualStyleBackColor = false;
            GroupByName.Click += GroupByName_Click;
            // 
            // OrderByName
            // 
            OrderByName.BackColor = SystemColors.Window;
            OrderByName.Location = new Point(313, 2);
            OrderByName.Name = "OrderByName";
            OrderByName.Size = new Size(94, 29);
            OrderByName.TabIndex = 5;
            OrderByName.Text = "Subject";
            OrderByName.UseVisualStyleBackColor = false;
            OrderByName.Click += OrderByName_Click;
            // 
            // GroupByage
            // 
            GroupByage.BackColor = SystemColors.Window;
            GroupByage.Location = new Point(413, 2);
            GroupByage.Name = "GroupByage";
            GroupByage.Size = new Size(94, 29);
            GroupByage.TabIndex = 5;
            GroupByage.Text = "Age";
            GroupByage.UseVisualStyleBackColor = false;
            GroupByage.Click += GroupByage_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 6);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 6;
            label5.Text = "Filtering";
            // 
            // Search
            // 
            Search.BackColor = Color.AliceBlue;
            Search.Location = new Point(113, 335);
            Search.Name = "Search";
            Search.Size = new Size(294, 27);
            Search.TabIndex = 7;
            Search.TextChanged += Search_TextChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(21, 338);
            label.Name = "label";
            label.Size = new Size(53, 20);
            label.TabIndex = 8;
            label.Text = "Search";
            // 
            // Project
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1291, 564);
            Controls.Add(label);
            Controls.Add(Search);
            Controls.Add(label5);
            Controls.Add(GroupByage);
            Controls.Add(OrderByName);
            Controls.Add(GroupByName);
            Controls.Add(OrderbyId);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Project";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            Create.ResumeLayout(false);
            Create.PerformLayout();
            Read.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)View2).EndInit();
            Update.ResumeLayout(false);
            Update.PerformLayout();
            Delete.ResumeLayout(false);
            Delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewForData).EndInit();
            Course.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CourseData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabControl tabControl1;
        private TabPage Create;
        private TabPage Read;
        private TabPage Update;
        private TabPage Delete;
        private Label label1;
        private Button Submit;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label Age;
        private TextBox textBox6;
        private Label NewName;
        private TextBox textBox5;
        private Label Id;
        private Button UpdateTable;
        private TextBox textBox8;
        private Label CourseName;
        private TextBox textBox7;
        private DataGridView View2;
        private TextBox IdDelete;
        private Label label4;
        private DataGridView ViewForData;
        private Button Remove;
        private TabPage Course;
        private DataGridView CourseData;
        private Button OrderbyId;
        private Button GroupByName;
        private Button OrderByName;
        private Button GroupByage;
        private Label label5;
        private TextBox Search;
        private Label label;
        private Label SearchbyName;
        private TextBox k;
    }
}
