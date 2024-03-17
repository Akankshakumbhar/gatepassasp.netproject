namespace Passes
{
    partial class UpdateVisitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateVisitor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtvisitorid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtuniqueid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textadress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtgender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textcontact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bexit = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.updateemp = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(645, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 341);
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtvisitorid
            // 
            this.txtvisitorid.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvisitorid.Location = new System.Drawing.Point(197, 103);
            this.txtvisitorid.Name = "txtvisitorid";
            this.txtvisitorid.Size = new System.Drawing.Size(221, 34);
            this.txtvisitorid.TabIndex = 102;
            this.txtvisitorid.Tag = "";
            this.txtvisitorid.TextChanged += new System.EventHandler(this.txtvisitorid_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 27);
            this.label8.TabIndex = 101;
            this.label8.Text = "Visitor Id";
            // 
            // txtuniqueid
            // 
            this.txtuniqueid.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuniqueid.Location = new System.Drawing.Point(197, 440);
            this.txtuniqueid.Name = "txtuniqueid";
            this.txtuniqueid.Size = new System.Drawing.Size(331, 34);
            this.txtuniqueid.TabIndex = 100;
            this.txtuniqueid.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 27);
            this.label6.TabIndex = 99;
            this.label6.Text = "Unique Id";
            // 
            // textadress
            // 
            this.textadress.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textadress.Location = new System.Drawing.Point(197, 371);
            this.textadress.Name = "textadress";
            this.textadress.Size = new System.Drawing.Size(331, 34);
            this.textadress.TabIndex = 98;
            this.textadress.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 27);
            this.label7.TabIndex = 97;
            this.label7.Text = "Address";
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgender.FormattingEnabled = true;
            this.txtgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.txtgender.Location = new System.Drawing.Point(197, 301);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(331, 35);
            this.txtgender.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 27);
            this.label5.TabIndex = 95;
            this.label5.Text = "Gender";
            // 
            // textcontact
            // 
            this.textcontact.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcontact.Location = new System.Drawing.Point(197, 229);
            this.textcontact.Name = "textcontact";
            this.textcontact.Size = new System.Drawing.Size(331, 34);
            this.textcontact.TabIndex = 94;
            this.textcontact.Tag = "";
            this.textcontact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textcontact_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 93;
            this.label4.Text = "Contact";
            // 
            // textname
            // 
            this.textname.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textname.Location = new System.Drawing.Point(197, 168);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(331, 34);
            this.textname.TabIndex = 92;
            this.textname.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 91;
            this.label2.Text = "Name";
            // 
            // bexit
            // 
            this.bexit.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bexit.Image = ((System.Drawing.Image)(resources.GetObject("bexit.Image")));
            this.bexit.Location = new System.Drawing.Point(1002, 2);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(76, 70);
            this.bexit.TabIndex = 90;
            this.bexit.Tag = "";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnreset.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreset.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.Image")));
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(885, 484);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(119, 55);
            this.btnreset.TabIndex = 89;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(645, 484);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 55);
            this.btnUpdate.TabIndex = 88;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // updateemp
            // 
            this.updateemp.AutoSize = true;
            this.updateemp.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateemp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.updateemp.Location = new System.Drawing.Point(413, 37);
            this.updateemp.Name = "updateemp";
            this.updateemp.Size = new System.Drawing.Size(178, 35);
            this.updateemp.TabIndex = 87;
            this.updateemp.Text = "Update Visitor\r\n";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsearch.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.Location = new System.Drawing.Point(432, 97);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(124, 45);
            this.btnsearch.TabIndex = 104;
            this.btnsearch.Text = "Search";
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // UpdateVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 565);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtvisitorid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtuniqueid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textadress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textcontact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.updateemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateVisitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateVisitor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtvisitorid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtuniqueid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textadress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtgender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textcontact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label updateemp;
        private System.Windows.Forms.Button btnsearch;
    }
}