namespace Passes
{
    partial class FilterPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterPass));
            this.dataGridViewVisitors = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Label();
            this.bexit = new System.Windows.Forms.Button();
            this.updateemp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerValiidform = new System.Windows.Forms.DateTimePicker();
            this.btnsear = new System.Windows.Forms.Button();
            this.txtgender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVisitors
            // 
            this.dataGridViewVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisitors.Location = new System.Drawing.Point(3, 122);
            this.dataGridViewVisitors.Name = "dataGridViewVisitors";
            this.dataGridViewVisitors.RowHeadersWidth = 62;
            this.dataGridViewVisitors.RowTemplate.Height = 28;
            this.dataGridViewVisitors.Size = new System.Drawing.Size(1008, 216);
            this.dataGridViewVisitors.TabIndex = 103;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(692, 82);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(331, 34);
            this.txtsearch.TabIndex = 102;
            this.txtsearch.Tag = "";
            // 
            // btnsearch
            // 
            this.btnsearch.AutoSize = true;
            this.btnsearch.BackColor = System.Drawing.Color.Transparent;
            this.btnsearch.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.Location = new System.Drawing.Point(687, 52);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(73, 27);
            this.btnsearch.TabIndex = 101;
            this.btnsearch.Text = "Search";
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bexit
            // 
            this.bexit.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bexit.Image = ((System.Drawing.Image)(resources.GetObject("bexit.Image")));
            this.bexit.Location = new System.Drawing.Point(947, 6);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(76, 70);
            this.bexit.TabIndex = 100;
            this.bexit.Tag = "";
            this.bexit.UseVisualStyleBackColor = true;
            // 
            // updateemp
            // 
            this.updateemp.AutoSize = true;
            this.updateemp.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateemp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.updateemp.Location = new System.Drawing.Point(401, 22);
            this.updateemp.Name = "updateemp";
            this.updateemp.Size = new System.Drawing.Size(127, 35);
            this.updateemp.TabIndex = 99;
            this.updateemp.Text = "Filter Pass";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 10);
            this.panel1.TabIndex = 104;
            // 
            // dateTimePickerValiidform
            // 
            this.dateTimePickerValiidform.CustomFormat = "dd.MM.yyy";
            this.dateTimePickerValiidform.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerValiidform.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerValiidform.Location = new System.Drawing.Point(190, 82);
            this.dateTimePickerValiidform.Name = "dateTimePickerValiidform";
            this.dateTimePickerValiidform.Size = new System.Drawing.Size(252, 37);
            this.dateTimePickerValiidform.TabIndex = 105;
            // 
            // btnsear
            // 
            this.btnsear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsear.Image = ((System.Drawing.Image)(resources.GetObject("btnsear.Image")));
            this.btnsear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsear.Location = new System.Drawing.Point(448, 86);
            this.btnsear.Name = "btnsear";
            this.btnsear.Size = new System.Drawing.Size(47, 36);
            this.btnsear.TabIndex = 106;
            this.btnsear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsear.UseVisualStyleBackColor = false;
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgender.FormattingEnabled = true;
            this.txtgender.Items.AddRange(new object[] {
            "ValidForm",
            "Valid to"});
            this.txtgender.Location = new System.Drawing.Point(3, 84);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(181, 35);
            this.txtgender.TabIndex = 107;
            // 
            // FilterPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 495);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.btnsear);
            this.Controls.Add(this.dateTimePickerValiidform);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewVisitors);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.updateemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilterPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterPass";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVisitors;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label btnsearch;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Label updateemp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerValiidform;
        private System.Windows.Forms.Button btnsear;
        private System.Windows.Forms.ComboBox txtgender;
    }
}