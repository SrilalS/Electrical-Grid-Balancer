namespace GridBalancer
{
    partial class AddNewPS
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
            this.AddPS = new System.Windows.Forms.Button();
            this.CNCLBTN = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Power = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPS
            // 
            this.AddPS.Location = new System.Drawing.Point(205, 196);
            this.AddPS.Name = "AddPS";
            this.AddPS.Size = new System.Drawing.Size(188, 42);
            this.AddPS.TabIndex = 2;
            this.AddPS.Text = "Add";
            this.AddPS.UseVisualStyleBackColor = true;
            this.AddPS.Click += new System.EventHandler(this.AddPS_Click);
            // 
            // CNCLBTN
            // 
            this.CNCLBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CNCLBTN.Location = new System.Drawing.Point(11, 196);
            this.CNCLBTN.Name = "CNCLBTN";
            this.CNCLBTN.Size = new System.Drawing.Size(188, 42);
            this.CNCLBTN.TabIndex = 3;
            this.CNCLBTN.Text = "Cancel";
            this.CNCLBTN.UseVisualStyleBackColor = true;
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Nuclear",
            "Coal",
            "Gas",
            "Hydro",
            "Diesel",
            "Solar",
            "Wind"});
            this.Type.Location = new System.Drawing.Point(11, 96);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(381, 37);
            this.Type.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(12, 37);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(381, 34);
            this.Name.TabIndex = 5;
            // 
            // Power
            // 
            this.Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Power.Location = new System.Drawing.Point(11, 156);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(382, 34);
            this.Power.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Power";
            // 
            // AddNewPS
            // 
            this.AcceptButton = this.AddPS;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CNCLBTN;
            this.ClientSize = new System.Drawing.Size(405, 249);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.CNCLBTN);
            this.Controls.Add(this.AddPS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Power Source";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddNewPS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Power)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPS;
        private System.Windows.Forms.Button CNCLBTN;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.NumericUpDown Power;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}