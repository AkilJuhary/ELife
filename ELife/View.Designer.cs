namespace ELife
{
    partial class View
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBackBtn = new System.Windows.Forms.Label();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSearchAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxName.Location = new System.Drawing.Point(425, 102);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(154, 32);
            this.textBoxName.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(270, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "Or Enter Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(77, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Enter ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxID.Location = new System.Drawing.Point(164, 102);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(91, 32);
            this.textBoxID.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(283, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 34);
            this.label1.TabIndex = 32;
            this.label1.Text = "View Patient Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBackBtn
            // 
            this.labelBackBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBackBtn.AutoSize = true;
            this.labelBackBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBackBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBackBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBackBtn.Location = new System.Drawing.Point(47, 37);
            this.labelBackBtn.Name = "labelBackBtn";
            this.labelBackBtn.Size = new System.Drawing.Size(103, 36);
            this.labelBackBtn.TabIndex = 37;
            this.labelBackBtn.Text = "< Back";
            this.labelBackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBackBtn.Click += new System.EventHandler(this.labelBackBtn_Click);
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(81, 195);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.Size = new System.Drawing.Size(645, 156);
            this.dataGridViewDetails.TabIndex = 38;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(601, 99);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(125, 35);
            this.buttonSearch.TabIndex = 44;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSearchAll
            // 
            this.buttonSearchAll.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonSearchAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSearchAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchAll.FlatAppearance.BorderSize = 0;
            this.buttonSearchAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchAll.Location = new System.Drawing.Point(601, 140);
            this.buttonSearchAll.Name = "buttonSearchAll";
            this.buttonSearchAll.Size = new System.Drawing.Size(125, 35);
            this.buttonSearchAll.TabIndex = 45;
            this.buttonSearchAll.Text = "Search All";
            this.buttonSearchAll.UseVisualStyleBackColor = false;
            this.buttonSearchAll.Click += new System.EventHandler(this.buttonSearchAll_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSearchAll);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridViewDetails);
            this.Controls.Add(this.labelBackBtn);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBackBtn;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSearchAll;
    }
}