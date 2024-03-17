namespace Passes
{
    partial class GeneratePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratePass));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Label();
            this.bexit = new System.Windows.Forms.Button();
            this.updateemp = new System.Windows.Forms.Label();
            this.btnvalidform = new System.Windows.Forms.Label();
            this.Validto = new System.Windows.Forms.Label();
            this.dateTimePickerValiidform = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerValidto = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelname = new System.Windows.Forms.Label();
            this.labelvalidto = new System.Windows.Forms.Label();
            this.labelvalidform = new System.Windows.Forms.Label();
            this.labelgender = new System.Windows.Forms.Label();
            this.labelpassid = new System.Windows.Forms.Label();
            this.labelcontact = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn1day = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weekpass = new System.Windows.Forms.Label();
            this.btngenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 216);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(762, 81);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(315, 34);
            this.txtsearch.TabIndex = 80;
            this.txtsearch.Tag = "";
            this.txtsearch.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.AutoSize = true;
            this.btnsearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnsearch.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.Location = new System.Drawing.Point(667, 84);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(73, 27);
            this.btnsearch.TabIndex = 79;
            this.btnsearch.Text = "Search";
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bexit
            // 
            this.bexit.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bexit.Image = ((System.Drawing.Image)(resources.GetObject("bexit.Image")));
            this.bexit.Location = new System.Drawing.Point(1017, 5);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(60, 70);
            this.bexit.TabIndex = 78;
            this.bexit.Tag = "";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // updateemp
            // 
            this.updateemp.AutoSize = true;
            this.updateemp.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateemp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.updateemp.Location = new System.Drawing.Point(449, 21);
            this.updateemp.Name = "updateemp";
            this.updateemp.Size = new System.Drawing.Size(254, 35);
            this.updateemp.TabIndex = 77;
            this.updateemp.Text = "Generate Visitor Pass";
            // 
            // btnvalidform
            // 
            this.btnvalidform.AutoSize = true;
            this.btnvalidform.BackColor = System.Drawing.SystemColors.Control;
            this.btnvalidform.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalidform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvalidform.Location = new System.Drawing.Point(118, 364);
            this.btnvalidform.Name = "btnvalidform";
            this.btnvalidform.Size = new System.Drawing.Size(109, 27);
            this.btnvalidform.TabIndex = 82;
            this.btnvalidform.Text = "Valid Form";
            this.btnvalidform.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Validto
            // 
            this.Validto.AutoSize = true;
            this.Validto.BackColor = System.Drawing.SystemColors.Control;
            this.Validto.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Validto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Validto.Location = new System.Drawing.Point(623, 374);
            this.Validto.Name = "Validto";
            this.Validto.Size = new System.Drawing.Size(80, 27);
            this.Validto.TabIndex = 83;
            this.Validto.Text = "Valid to";
            this.Validto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePickerValiidform
            // 
            this.dateTimePickerValiidform.CustomFormat = "dd.MM.yyy";
            this.dateTimePickerValiidform.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerValiidform.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerValiidform.Location = new System.Drawing.Point(259, 364);
            this.dateTimePickerValiidform.Name = "dateTimePickerValiidform";
            this.dateTimePickerValiidform.Size = new System.Drawing.Size(252, 37);
            this.dateTimePickerValiidform.TabIndex = 84;
            this.dateTimePickerValiidform.ValueChanged += new System.EventHandler(this.dateTimePickerValiidform_ValueChanged);
            // 
            // dateTimePickerValidto
            // 
            this.dateTimePickerValidto.CustomFormat = "dd.MM.yyy";
            this.dateTimePickerValidto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerValidto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerValidto.Location = new System.Drawing.Point(742, 364);
            this.dateTimePickerValidto.Name = "dateTimePickerValidto";
            this.dateTimePickerValidto.Size = new System.Drawing.Size(252, 37);
            this.dateTimePickerValidto.TabIndex = 85;
            this.dateTimePickerValidto.ValueChanged += new System.EventHandler(this.dateTimePickerValidto_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.pictureBoxProfile);
            this.panel1.Controls.Add(this.labelname);
            this.panel1.Controls.Add(this.labelvalidto);
            this.panel1.Controls.Add(this.labelvalidform);
            this.panel1.Controls.Add(this.labelgender);
            this.panel1.Controls.Add(this.labelpassid);
            this.panel1.Controls.Add(this.labelcontact);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(259, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 350);
            this.panel1.TabIndex = 86;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.White;
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfile.Location = new System.Drawing.Point(433, 87);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(233, 217);
            this.pictureBoxProfile.TabIndex = 104;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelname.Location = new System.Drawing.Point(58, 107);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(75, 27);
            this.labelname.TabIndex = 89;
            this.labelname.Text = "Names";
            this.labelname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelvalidto
            // 
            this.labelvalidto.AutoSize = true;
            this.labelvalidto.BackColor = System.Drawing.Color.Transparent;
            this.labelvalidto.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvalidto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelvalidto.Location = new System.Drawing.Point(63, 305);
            this.labelvalidto.Name = "labelvalidto";
            this.labelvalidto.Size = new System.Drawing.Size(80, 27);
            this.labelvalidto.TabIndex = 88;
            this.labelvalidto.Text = "Valid to";
            this.labelvalidto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelvalidform
            // 
            this.labelvalidform.AutoSize = true;
            this.labelvalidform.BackColor = System.Drawing.Color.Transparent;
            this.labelvalidform.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvalidform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelvalidform.Location = new System.Drawing.Point(51, 255);
            this.labelvalidform.Name = "labelvalidform";
            this.labelvalidform.Size = new System.Drawing.Size(104, 27);
            this.labelvalidform.TabIndex = 87;
            this.labelvalidform.Text = "ValidForm";
            this.labelvalidform.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelgender
            // 
            this.labelgender.AutoSize = true;
            this.labelgender.BackColor = System.Drawing.Color.Transparent;
            this.labelgender.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelgender.Location = new System.Drawing.Point(53, 205);
            this.labelgender.Name = "labelgender";
            this.labelgender.Size = new System.Drawing.Size(80, 27);
            this.labelgender.TabIndex = 86;
            this.labelgender.Text = "Gender";
            this.labelgender.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelpassid
            // 
            this.labelpassid.AutoSize = true;
            this.labelpassid.BackColor = System.Drawing.Color.Transparent;
            this.labelpassid.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelpassid.Location = new System.Drawing.Point(53, 55);
            this.labelpassid.Name = "labelpassid";
            this.labelpassid.Size = new System.Drawing.Size(75, 27);
            this.labelpassid.TabIndex = 85;
            this.labelpassid.Text = "Pass Id";
            this.labelpassid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelpassid.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelcontact
            // 
            this.labelcontact.AutoSize = true;
            this.labelcontact.BackColor = System.Drawing.Color.Transparent;
            this.labelcontact.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcontact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelcontact.Location = new System.Drawing.Point(51, 151);
            this.labelcontact.Name = "labelcontact";
            this.labelcontact.Size = new System.Drawing.Size(82, 27);
            this.labelcontact.TabIndex = 84;
            this.labelcontact.Text = "Contact";
            this.labelcontact.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(255, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 27);
            this.label2.TabIndex = 83;
            this.label2.Text = "Gate Passses";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(163, 419);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 48);
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(157, 526);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 48);
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(163, 653);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 48);
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            // 
            // btn1day
            // 
            this.btn1day.AutoSize = true;
            this.btn1day.BackColor = System.Drawing.SystemColors.Control;
            this.btn1day.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1day.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1day.Location = new System.Drawing.Point(129, 484);
            this.btn1day.Name = "btn1day";
            this.btn1day.Size = new System.Drawing.Size(108, 27);
            this.btn1day.TabIndex = 90;
            this.btn1day.Text = "Day 1 Pass";
            this.btn1day.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(111, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 91;
            this.label1.Text = "2-7 Day Pass";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weekpass
            // 
            this.weekpass.AutoSize = true;
            this.weekpass.BackColor = System.Drawing.SystemColors.Control;
            this.weekpass.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekpass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.weekpass.Location = new System.Drawing.Point(118, 704);
            this.weekpass.Name = "weekpass";
            this.weekpass.Size = new System.Drawing.Size(124, 81);
            this.weekpass.TabIndex = 92;
            this.weekpass.Text = "More than \r\n1 Week Pass\r\n\r\n";
            this.weekpass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btngenerate.Image = ((System.Drawing.Image)(resources.GetObject("btngenerate.Image")));
            this.btngenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngenerate.Location = new System.Drawing.Point(950, 724);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(117, 36);
            this.btngenerate.TabIndex = 93;
            this.btngenerate.Text = "Generate";
            this.btngenerate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngenerate.UseVisualStyleBackColor = false;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // GeneratePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 898);
            this.Controls.Add(this.btngenerate);
            this.Controls.Add(this.weekpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1day);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePickerValidto);
            this.Controls.Add(this.dateTimePickerValiidform);
            this.Controls.Add(this.Validto);
            this.Controls.Add(this.btnvalidform);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.updateemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneratePass";
            this.Text = "GeneratePass";
            this.Load += new System.EventHandler(this.GeneratePass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label btnsearch;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Label updateemp;
        private System.Windows.Forms.Label btnvalidform;
        private System.Windows.Forms.Label Validto;
        private System.Windows.Forms.DateTimePicker dateTimePickerValiidform;
        private System.Windows.Forms.DateTimePicker dateTimePickerValidto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label btn1day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label weekpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelvalidto;
        private System.Windows.Forms.Label labelvalidform;
        private System.Windows.Forms.Label labelgender;
        private System.Windows.Forms.Label labelpassid;
        private System.Windows.Forms.Label labelcontact;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button btngenerate;
    }
}