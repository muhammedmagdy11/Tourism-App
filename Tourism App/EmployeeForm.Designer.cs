namespace Tourism_App
{
    partial class EmployeeForm
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
            this.tab_Reservations = new System.Windows.Forms.TabControl();
            this.tab_Journeys = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_budget = new System.Windows.Forms.Label();
            this.txt_budget = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_Date = new System.Windows.Forms.ComboBox();
            this.cmb_location = new System.Windows.Forms.ComboBox();
            this.cmb_numOfDays = new System.Windows.Forms.ComboBox();
            this.cmb_travelWay = new System.Windows.Forms.ComboBox();
            this.btn_book = new System.Windows.Forms.Button();
            this.data_Journeys = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.richreserveid = new System.Windows.Forms.RichTextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.richnumoftickets = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Reservationdgv = new System.Windows.Forms.DataGridView();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.tab_Reservations.SuspendLayout();
            this.tab_Journeys.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Journeys)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reservationdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Reservations
            // 
            this.tab_Reservations.Controls.Add(this.tab_Journeys);
            this.tab_Reservations.Controls.Add(this.tabPage2);
            this.tab_Reservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Reservations.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.tab_Reservations.Location = new System.Drawing.Point(0, 0);
            this.tab_Reservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Reservations.Name = "tab_Reservations";
            this.tab_Reservations.SelectedIndex = 0;
            this.tab_Reservations.Size = new System.Drawing.Size(921, 480);
            this.tab_Reservations.TabIndex = 0;
            // 
            // tab_Journeys
            // 
            this.tab_Journeys.Controls.Add(this.groupBox1);
            this.tab_Journeys.Controls.Add(this.btn_book);
            this.tab_Journeys.Controls.Add(this.data_Journeys);
            this.tab_Journeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Journeys.Location = new System.Drawing.Point(4, 33);
            this.tab_Journeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Journeys.Name = "tab_Journeys";
            this.tab_Journeys.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Journeys.Size = new System.Drawing.Size(913, 443);
            this.tab_Journeys.TabIndex = 0;
            this.tab_Journeys.Text = "Journeys";
            this.tab_Journeys.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_budget);
            this.groupBox1.Controls.Add(this.txt_budget);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmb_Date);
            this.groupBox1.Controls.Add(this.cmb_location);
            this.groupBox1.Controls.Add(this.cmb_numOfDays);
            this.groupBox1.Controls.Add(this.cmb_travelWay);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(907, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filteration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(755, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(579, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(403, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Transportation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(232, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Budget";
            // 
            // lbl_budget
            // 
            this.lbl_budget.AutoSize = true;
            this.lbl_budget.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_budget.ForeColor = System.Drawing.Color.Red;
            this.lbl_budget.Location = new System.Drawing.Point(233, 110);
            this.lbl_budget.Name = "lbl_budget";
            this.lbl_budget.Size = new System.Drawing.Size(248, 20);
            this.lbl_budget.TabIndex = 14;
            this.lbl_budget.Text = "Budget Should be number";
            this.lbl_budget.Visible = false;
            // 
            // txt_budget
            // 
            this.txt_budget.Location = new System.Drawing.Point(237, 63);
            this.txt_budget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_budget.Name = "txt_budget";
            this.txt_budget.Size = new System.Drawing.Size(137, 27);
            this.txt_budget.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(783, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_Date
            // 
            this.cmb_Date.FormattingEnabled = true;
            this.cmb_Date.Location = new System.Drawing.Point(760, 60);
            this.cmb_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Date.Name = "cmb_Date";
            this.cmb_Date.Size = new System.Drawing.Size(137, 28);
            this.cmb_Date.TabIndex = 11;
            // 
            // cmb_location
            // 
            this.cmb_location.FormattingEnabled = true;
            this.cmb_location.Location = new System.Drawing.Point(584, 60);
            this.cmb_location.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_location.Name = "cmb_location";
            this.cmb_location.Size = new System.Drawing.Size(137, 28);
            this.cmb_location.TabIndex = 10;
            // 
            // cmb_numOfDays
            // 
            this.cmb_numOfDays.FormattingEnabled = true;
            this.cmb_numOfDays.Location = new System.Drawing.Point(408, 60);
            this.cmb_numOfDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_numOfDays.Name = "cmb_numOfDays";
            this.cmb_numOfDays.Size = new System.Drawing.Size(137, 28);
            this.cmb_numOfDays.TabIndex = 9;
            // 
            // cmb_travelWay
            // 
            this.cmb_travelWay.FormattingEnabled = true;
            this.cmb_travelWay.Location = new System.Drawing.Point(5, 60);
            this.cmb_travelWay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_travelWay.Name = "cmb_travelWay";
            this.cmb_travelWay.Size = new System.Drawing.Size(201, 28);
            this.cmb_travelWay.TabIndex = 7;
            // 
            // btn_book
            // 
            this.btn_book.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.btn_book.Location = new System.Drawing.Point(9, 194);
            this.btn_book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(111, 36);
            this.btn_book.TabIndex = 1;
            this.btn_book.Text = "Book";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Visible = false;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // data_Journeys
            // 
            this.data_Journeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Journeys.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_Journeys.Location = new System.Drawing.Point(3, 239);
            this.data_Journeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_Journeys.Name = "data_Journeys";
            this.data_Journeys.RowHeadersWidth = 51;
            this.data_Journeys.RowTemplate.Height = 24;
            this.data_Journeys.Size = new System.Drawing.Size(907, 202);
            this.data_Journeys.TabIndex = 0;
            this.data_Journeys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Journeys_CellContentClick);
            this.data_Journeys.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_Journeys_RowHeaderMouseClick);
            this.data_Journeys.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_Journeys_RowHeaderMouseDoubleClick);
            this.data_Journeys.MouseEnter += new System.EventHandler(this.data_Journeys_MouseEnter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnsave);
            this.tabPage2.Controls.Add(this.richreserveid);
            this.tabPage2.Controls.Add(this.btnupdate);
            this.tabPage2.Controls.Add(this.richnumoftickets);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.Reservationdgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(913, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reservations";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 363);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tickets Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Reservation ID :";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(373, 321);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(143, 64);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Visible = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // richreserveid
            // 
            this.richreserveid.Location = new System.Drawing.Point(209, 300);
            this.richreserveid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richreserveid.Name = "richreserveid";
            this.richreserveid.ReadOnly = true;
            this.richreserveid.Size = new System.Drawing.Size(112, 42);
            this.richreserveid.TabIndex = 4;
            this.richreserveid.Text = "";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(373, 321);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(143, 64);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // richnumoftickets
            // 
            this.richnumoftickets.Location = new System.Drawing.Point(209, 357);
            this.richnumoftickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richnumoftickets.Name = "richnumoftickets";
            this.richnumoftickets.Size = new System.Drawing.Size(112, 42);
            this.richnumoftickets.TabIndex = 2;
            this.richnumoftickets.Text = "";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(559, 321);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 64);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Reservationdgv
            // 
            this.Reservationdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reservationdgv.Location = new System.Drawing.Point(147, 0);
            this.Reservationdgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reservationdgv.Name = "Reservationdgv";
            this.Reservationdgv.RowHeadersWidth = 51;
            this.Reservationdgv.Size = new System.Drawing.Size(597, 273);
            this.Reservationdgv.TabIndex = 0;
            this.Reservationdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Reservationdgv_CellContentClick);
            // 
            // skinEngine1
            // 
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(921, 480);
            this.Controls.Add(this.tab_Reservations);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.tab_Reservations.ResumeLayout(false);
            this.tab_Journeys.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Journeys)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reservationdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Reservations;
        private System.Windows.Forms.TabPage tab_Journeys;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView data_Journeys;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_Date;
        private System.Windows.Forms.ComboBox cmb_location;
        private System.Windows.Forms.ComboBox cmb_numOfDays;
        private System.Windows.Forms.ComboBox cmb_travelWay;
        private System.Windows.Forms.TextBox txt_budget;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_budget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Reservationdgv;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RichTextBox richreserveid;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.RichTextBox richnumoftickets;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}