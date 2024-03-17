namespace Passes
{
    partial class ViewVisitors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVisitors));
            this.textsearch = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.bexit = new System.Windows.Forms.Button();
            this.updateemp = new System.Windows.Forms.Label();
            this.dataGridViewVisitor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitor)).BeginInit();
            this.SuspendLayout();
            // 
            // textsearch
            // 
            this.textsearch.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsearch.Location = new System.Drawing.Point(696, 111);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(331, 34);
            this.textsearch.TabIndex = 96;
            this.textsearch.Tag = "";
            this.textsearch.TextChanged += new System.EventHandler(this.textsearch_TextChanged);
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(584, 111);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(73, 27);
            this.search.TabIndex = 95;
            this.search.Text = "Search";
            this.search.Click += new System.EventHandler(this.label2_Click);
            // 
            // bexit
            // 
            this.bexit.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bexit.Image = ((System.Drawing.Image)(resources.GetObject("bexit.Image")));
            this.bexit.Location = new System.Drawing.Point(951, 2);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(76, 70);
            this.bexit.TabIndex = 94;
            this.bexit.Tag = "";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // updateemp
            // 
            this.updateemp.AutoSize = true;
            this.updateemp.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateemp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.updateemp.Location = new System.Drawing.Point(419, 37);
            this.updateemp.Name = "updateemp";
            this.updateemp.Size = new System.Drawing.Size(150, 35);
            this.updateemp.TabIndex = 93;
            this.updateemp.Text = "View Visitor";
            // 
            // dataGridViewVisitor
            // 
            this.dataGridViewVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisitor.Location = new System.Drawing.Point(12, 148);
            this.dataGridViewVisitor.Name = "dataGridViewVisitor";
            this.dataGridViewVisitor.RowHeadersWidth = 62;
            this.dataGridViewVisitor.RowTemplate.Height = 28;
            this.dataGridViewVisitor.Size = new System.Drawing.Size(1015, 404);
            this.dataGridViewVisitor.TabIndex = 97;
            // 
            // ViewVisitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 564);
            this.Controls.Add(this.dataGridViewVisitor);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.updateemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewVisitors";
            this.Text = "ViewVisitors";
            this.Load += new System.EventHandler(this.ViewVisitors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Label updateemp;
        private System.Windows.Forms.DataGridView dataGridViewVisitor;
    }
}