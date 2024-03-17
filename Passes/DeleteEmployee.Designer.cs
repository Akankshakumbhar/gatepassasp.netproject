namespace Passes
{
    partial class DeleteEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteEmployee));
            this.txtstate = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.textcity = new System.Windows.Forms.TextBox();
            this.textadress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgender = new System.Windows.Forms.ComboBox();
            this.textcontact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthiredate = new System.Windows.Forms.DateTimePicker();
            this.textname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateemp = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.bexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtstate
            // 
            this.txtstate.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstate.Location = new System.Drawing.Point(156, 584);
            this.txtstate.Name = "txtstate";
            this.txtstate.ReadOnly = true;
            this.txtstate.Size = new System.Drawing.Size(331, 34);
            this.txtstate.TabIndex = 83;
            this.txtstate.Tag = "";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(158, 147);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(329, 34);
            this.txtusername.TabIndex = 82;
            this.txtusername.Tag = "";
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // textcity
            // 
            this.textcity.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcity.Location = new System.Drawing.Point(156, 512);
            this.textcity.Name = "textcity";
            this.textcity.ReadOnly = true;
            this.textcity.Size = new System.Drawing.Size(331, 34);
            this.textcity.TabIndex = 81;
            this.textcity.Tag = "";
            // 
            // textadress
            // 
            this.textadress.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textadress.Location = new System.Drawing.Point(156, 455);
            this.textadress.Name = "textadress";
            this.textadress.ReadOnly = true;
            this.textadress.Size = new System.Drawing.Size(331, 34);
            this.textadress.TabIndex = 80;
            this.textadress.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 27);
            this.label9.TabIndex = 79;
            this.label9.Text = "UserName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 591);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 27);
            this.label8.TabIndex = 78;
            this.label8.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 27);
            this.label7.TabIndex = 77;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 27);
            this.label6.TabIndex = 76;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 27);
            this.label5.TabIndex = 75;
            this.label5.Text = "Gender";
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgender.FormattingEnabled = true;
            this.txtgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.txtgender.Location = new System.Drawing.Point(156, 386);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(331, 35);
            this.txtgender.TabIndex = 74;
            // 
            // textcontact
            // 
            this.textcontact.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcontact.Location = new System.Drawing.Point(156, 329);
            this.textcontact.Name = "textcontact";
            this.textcontact.ReadOnly = true;
            this.textcontact.Size = new System.Drawing.Size(331, 34);
            this.textcontact.TabIndex = 73;
            this.textcontact.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 72;
            this.label4.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 71;
            this.label3.Text = "HireDate";
            // 
            // txthiredate
            // 
            this.txthiredate.CalendarFont = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthiredate.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthiredate.Location = new System.Drawing.Point(156, 264);
            this.txthiredate.Name = "txthiredate";
            this.txthiredate.Size = new System.Drawing.Size(331, 34);
            this.txthiredate.TabIndex = 70;
            // 
            // textname
            // 
            this.textname.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textname.Location = new System.Drawing.Point(156, 198);
            this.textname.Name = "textname";
            this.textname.ReadOnly = true;
            this.textname.Size = new System.Drawing.Size(331, 34);
            this.textname.TabIndex = 69;
            this.textname.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 68;
            this.label2.Text = "Name";
            // 
            // updateemp
            // 
            this.updateemp.AutoSize = true;
            this.updateemp.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateemp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.updateemp.Location = new System.Drawing.Point(227, 46);
            this.updateemp.Name = "updateemp";
            this.updateemp.Size = new System.Drawing.Size(208, 35);
            this.updateemp.TabIndex = 84;
            this.updateemp.Text = "Delete Employee\r\n";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(136, 640);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(145, 55);
            this.btndelete.TabIndex = 85;
            this.btndelete.Text = "Delete";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btreset
            // 
            this.btreset.BackColor = System.Drawing.SystemColors.Highlight;
            this.btreset.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btreset.Image = ((System.Drawing.Image)(resources.GetObject("btreset.Image")));
            this.btreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btreset.Location = new System.Drawing.Point(351, 640);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(155, 55);
            this.btreset.TabIndex = 86;
            this.btreset.Text = "Reset";
            this.btreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btreset.UseVisualStyleBackColor = false;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsearch.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.Location = new System.Drawing.Point(521, 144);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(119, 38);
            this.btnsearch.TabIndex = 87;
            this.btnsearch.Text = "Search";
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // bexit
            // 
            this.bexit.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bexit.Image = ((System.Drawing.Image)(resources.GetObject("bexit.Image")));
            this.bexit.Location = new System.Drawing.Point(650, 1);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(76, 70);
            this.bexit.TabIndex = 88;
            this.bexit.Tag = "";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 745);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.updateemp);
            this.Controls.Add(this.txtstate);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.textcity);
            this.Controls.Add(this.textadress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.textcontact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthiredate);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtstate;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox textcity;
        private System.Windows.Forms.TextBox textadress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtgender;
        private System.Windows.Forms.TextBox textcontact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txthiredate;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label updateemp;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button bexit;
    }
}