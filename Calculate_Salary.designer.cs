namespace clinic_forms
{
    partial class Calculate_Salary
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
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.SalaryTB = new System.Windows.Forms.TextBox();
            this.CalulateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PaidButton = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeCB
            // 
            this.TypeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Location = new System.Drawing.Point(230, 84);
            this.TypeCB.Margin = new System.Windows.Forms.Padding(7);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(277, 37);
            this.TypeCB.TabIndex = 0;
            this.TypeCB.SelectedIndexChanged += new System.EventHandler(this.TypeCB_SelectedIndexChanged);
            // 
            // SalaryTB
            // 
            this.SalaryTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SalaryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryTB.Location = new System.Drawing.Point(347, 894);
            this.SalaryTB.Margin = new System.Windows.Forms.Padding(7);
            this.SalaryTB.Name = "SalaryTB";
            this.SalaryTB.ReadOnly = true;
            this.SalaryTB.Size = new System.Drawing.Size(228, 35);
            this.SalaryTB.TabIndex = 4;
            // 
            // CalulateButton
            // 
            this.CalulateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalulateButton.Location = new System.Drawing.Point(36, 890);
            this.CalulateButton.Margin = new System.Windows.Forms.Padding(7);
            this.CalulateButton.Name = "CalulateButton";
            this.CalulateButton.Size = new System.Drawing.Size(263, 52);
            this.CalulateButton.TabIndex = 5;
            this.CalulateButton.Text = "Calculate Salary";
            this.CalulateButton.UseVisualStyleBackColor = true;
            this.CalulateButton.Click += new System.EventHandler(this.CalulateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Staff Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // PaidButton
            // 
            this.PaidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidButton.Location = new System.Drawing.Point(613, 890);
            this.PaidButton.Margin = new System.Windows.Forms.Padding(7);
            this.PaidButton.Name = "PaidButton";
            this.PaidButton.Size = new System.Drawing.Size(263, 52);
            this.PaidButton.TabIndex = 9;
            this.PaidButton.Text = "Salary Paid";
            this.PaidButton.UseVisualStyleBackColor = true;
            this.PaidButton.Click += new System.EventHandler(this.PaidButton_Click);
            // 
            // NameTB
            // 
            this.NameTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(230, 146);
            this.NameTB.Margin = new System.Windows.Forms.Padding(7);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(345, 35);
            this.NameTB.TabIndex = 10;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search By:";
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(36, 214);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowTemplate.Height = 37;
            this.DataGrid.Size = new System.Drawing.Size(1267, 652);
            this.DataGrid.TabIndex = 12;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // Calculate_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 966);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.PaidButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalulateButton);
            this.Controls.Add(this.SalaryTB);
            this.Controls.Add(this.TypeCB);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Calculate_Salary";
            this.Text = "Calculate Salary";
            this.Load += new System.EventHandler(this.Calculate_Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.TextBox SalaryTB;
        private System.Windows.Forms.Button CalulateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PaidButton;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGrid;
    }
}