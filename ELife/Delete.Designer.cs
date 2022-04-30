namespace ELife
{
    partial class Delete
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
            this.labelDelPatients = new System.Windows.Forms.Label();
            this.labelBackBtn = new System.Windows.Forms.Label();
            this.buttonSearchAll = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDelPatients
            // 
            this.labelDelPatients.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDelPatients.AutoSize = true;
            this.labelDelPatients.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelPatients.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDelPatients.Location = new System.Drawing.Point(268, 44);
            this.labelDelPatients.Name = "labelDelPatients";
            this.labelDelPatients.Size = new System.Drawing.Size(286, 34);
            this.labelDelPatients.TabIndex = 32;
            this.labelDelPatients.Text = "Delete Patient Details";
            this.labelDelPatients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBackBtn
            // 
            this.labelBackBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBackBtn.AutoSize = true;
            this.labelBackBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBackBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBackBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBackBtn.Location = new System.Drawing.Point(41, 29);
            this.labelBackBtn.Name = "labelBackBtn";
            this.labelBackBtn.Size = new System.Drawing.Size(103, 36);
            this.labelBackBtn.TabIndex = 37;
            this.labelBackBtn.Text = "< Back";
            this.labelBackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBackBtn.Click += new System.EventHandler(this.labelBackBtn_Click);
            // 
            // buttonSearchAll
            // 
            this.buttonSearchAll.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonSearchAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSearchAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchAll.FlatAppearance.BorderSize = 0;
            this.buttonSearchAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchAll.Location = new System.Drawing.Point(605, 155);
            this.buttonSearchAll.Name = "buttonSearchAll";
            this.buttonSearchAll.Size = new System.Drawing.Size(125, 35);
            this.buttonSearchAll.TabIndex = 51;
            this.buttonSearchAll.Text = "Search All";
            this.buttonSearchAll.UseVisualStyleBackColor = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(605, 114);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(125, 35);
            this.buttonSearch.TabIndex = 50;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxName.Location = new System.Drawing.Point(429, 117);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(154, 32);
            this.textBoxName.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(274, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Or Enter Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(81, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Enter ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxID.Location = new System.Drawing.Point(168, 117);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(91, 32);
            this.textBoxID.TabIndex = 46;
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(85, 211);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.Size = new System.Drawing.Size(645, 156);
            this.dataGridViewDetails.TabIndex = 52;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Tomato;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(605, 385);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 35);
            this.buttonDelete.TabIndex = 53;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewDetails);
            this.Controls.Add(this.buttonSearchAll);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelBackBtn);
            this.Controls.Add(this.labelDelPatients);
            this.Name = "Delete";
            this.Text = "Delete";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDelPatients;
        private System.Windows.Forms.Label labelBackBtn;
        private System.Windows.Forms.Button buttonSearchAll;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.Button buttonDelete;
    }
}