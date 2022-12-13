namespace CST_150_Inventory_Project.PresentationLayer
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.dtaInventory = new System.Windows.Forms.DataGridView();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchCatagory = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.btnResults = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaInventory
            // 
            this.dtaInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaInventory.Location = new System.Drawing.Point(379, 90);
            this.dtaInventory.Name = "dtaInventory";
            this.dtaInventory.RowHeadersWidth = 82;
            this.dtaInventory.RowTemplate.Height = 41;
            this.dtaInventory.Size = new System.Drawing.Size(705, 356);
            this.dtaInventory.TabIndex = 0;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(145, 141);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(200, 39);
            this.txtSearchName.TabIndex = 1;
            // 
            // txtSearchCatagory
            // 
            this.txtSearchCatagory.Location = new System.Drawing.Point(145, 257);
            this.txtSearchCatagory.Name = "txtSearchCatagory";
            this.txtSearchCatagory.Size = new System.Drawing.Size(200, 39);
            this.txtSearchCatagory.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 141);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 32);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Location = new System.Drawing.Point(12, 260);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(109, 32);
            this.lblCatagory.TabIndex = 5;
            this.lblCatagory.Text = "Catagory";
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnResults.Location = new System.Drawing.Point(209, 337);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(136, 46);
            this.btnResults.TabIndex = 6;
            this.btnResults.Text = "Search";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1096, 595);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.lblCatagory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSearchCatagory);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.dtaInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Text = "Search Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dtaInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtaInventory;
        private TextBox txtSearchName;
        private TextBox txtSearchCatagory;
        private Label lblName;
        private Label lblCatagory;
        private Button btnResults;
    }
}