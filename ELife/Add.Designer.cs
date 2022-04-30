namespace ELife
{
    partial class Add
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
            this.labelAddPatient = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelDiagnosis = new System.Windows.Forms.Label();
            this.textBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.labelBackBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAddPatient
            // 
            this.labelAddPatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAddPatient.AutoSize = true;
            this.labelAddPatient.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPatient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAddPatient.Location = new System.Drawing.Point(257, 37);
            this.labelAddPatient.Name = "labelAddPatient";
            this.labelAddPatient.Size = new System.Drawing.Size(164, 34);
            this.labelAddPatient.TabIndex = 0;
            this.labelAddPatient.Text = "Add Patient";
            this.labelAddPatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAddPatient.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelName.Location = new System.Drawing.Point(65, 111);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 27);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxName.Location = new System.Drawing.Point(221, 111);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 28);
            this.textBoxName.TabIndex = 2;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelID.Location = new System.Drawing.Point(65, 163);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(34, 27);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "ID";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxID.Location = new System.Drawing.Point(221, 163);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(144, 28);
            this.textBoxID.TabIndex = 4;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAddress.Location = new System.Drawing.Point(65, 217);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(93, 27);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "Address";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAddress.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxAddress.Location = new System.Drawing.Point(221, 218);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(211, 48);
            this.textBoxAddress.TabIndex = 6;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelGender.Location = new System.Drawing.Point(65, 285);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(86, 27);
            this.labelGender.TabIndex = 9;
            this.labelGender.Text = "Gender";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDiagnosis
            // 
            this.labelDiagnosis.AutoSize = true;
            this.labelDiagnosis.BackColor = System.Drawing.Color.Transparent;
            this.labelDiagnosis.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiagnosis.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDiagnosis.Location = new System.Drawing.Point(65, 337);
            this.labelDiagnosis.Name = "labelDiagnosis";
            this.labelDiagnosis.Size = new System.Drawing.Size(109, 27);
            this.labelDiagnosis.TabIndex = 11;
            this.labelDiagnosis.Text = "Diagnosis";
            this.labelDiagnosis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDiagnosis
            // 
            this.textBoxDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiagnosis.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxDiagnosis.Location = new System.Drawing.Point(221, 337);
            this.textBoxDiagnosis.Multiline = true;
            this.textBoxDiagnosis.Name = "textBoxDiagnosis";
            this.textBoxDiagnosis.Size = new System.Drawing.Size(144, 28);
            this.textBoxDiagnosis.TabIndex = 10;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.BackColor = System.Drawing.Color.Transparent;
            this.labelDepartment.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartment.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDepartment.Location = new System.Drawing.Point(65, 391);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(133, 27);
            this.labelDepartment.TabIndex = 13;
            this.labelDepartment.Text = "Department";
            this.labelDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Transgender"});
            this.comboBoxGender.Location = new System.Drawing.Point(221, 284);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(144, 32);
            this.comboBoxGender.TabIndex = 14;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Items.AddRange(new object[] {
            "General ",
            "Haematogoly",
            "Neurology",
            "Oncology",
            "Psychology",
            "Dermatology",
            "Opthamology",
            "Cardiology",
            "Gastrology",
            "Pulmonology",
            "Nephrology",
            "Other"});
            this.comboBoxDepartment.Location = new System.Drawing.Point(221, 391);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(144, 32);
            this.comboBoxDepartment.TabIndex = 33;
            // 
            // labelBackBtn
            // 
            this.labelBackBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBackBtn.AutoSize = true;
            this.labelBackBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBackBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBackBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBackBtn.Location = new System.Drawing.Point(34, 37);
            this.labelBackBtn.Name = "labelBackBtn";
            this.labelBackBtn.Size = new System.Drawing.Size(103, 36);
            this.labelBackBtn.TabIndex = 34;
            this.labelBackBtn.Text = "< Back";
            this.labelBackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBackBtn.Click += new System.EventHandler(this.label7_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(676, 479);
            this.Controls.Add(this.labelBackBtn);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelDiagnosis);
            this.Controls.Add(this.textBoxDiagnosis);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAddPatient);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddPatient;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelDiagnosis;
        private System.Windows.Forms.TextBox textBoxDiagnosis;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label labelBackBtn;
    }
}