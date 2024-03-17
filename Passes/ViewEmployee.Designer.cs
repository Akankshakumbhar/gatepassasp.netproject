namespace Passes
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            this.updateemp = new System.Windows.Forms.Label();
            this.bexit = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateemp
            // 
            this.updateemp.AutoSize = true;
            this.updateemp.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateemp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.updateemp.Location = new System.Drawing.Point(384, 16);
            this.updateemp.Name = "updateemp";
            this.updateemp.Size = new System.Drawing.Size(184, 35);
            this.updateemp.TabIndex = 48;
            this.updateemp.Text = "ViewEmployee\r\n";
            // 
            // bexit
            // 
            this.bexit.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bexit.Image = ((System.Drawing.Image)(resources.GetObject("bexit.Image")));
            this.bexit.Location = new System.Drawing.Point(952, 0);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(76, 70);
            this.bexit.TabIndex = 73;
            this.bexit.Tag = "";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.AutoSize = true;
            this.btnsearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnsearch.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.Location = new System.Drawing.Point(609, 105);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(73, 27);
            this.btnsearch.TabIndex = 74;
            this.btnsearch.Text = "Search";
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsearch.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(697, 98);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(331, 34);
            this.txtusername.TabIndex = 75;
            this.txtusername.Tag = "";
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 422);
            this.dataGridView1.TabIndex = 76;
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 564);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.updateemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewEmployee";
            this.Text = "ViewEmployee";
            this.Load += new System.EventHandler(this.ViewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateemp;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Label btnsearch;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}