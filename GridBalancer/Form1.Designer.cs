namespace GridBalancer
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddPS = new System.Windows.Forms.Button();
            this.AddPC = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SolarAmount = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WindAmount = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.WaterAmount = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TotalFreq = new System.Windows.Forms.Label();
            this.TotalPower = new System.Windows.Forms.Label();
            this.PSList = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddPC);
            this.groupBox1.Controls.Add(this.AddPS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // AddPS
            // 
            this.AddPS.Location = new System.Drawing.Point(6, 21);
            this.AddPS.Name = "AddPS";
            this.AddPS.Size = new System.Drawing.Size(188, 42);
            this.AddPS.TabIndex = 1;
            this.AddPS.Text = "Add a Power Source";
            this.AddPS.UseVisualStyleBackColor = true;
            this.AddPS.Click += new System.EventHandler(this.AddPS_Click);
            // 
            // AddPC
            // 
            this.AddPC.Location = new System.Drawing.Point(6, 69);
            this.AddPC.Name = "AddPC";
            this.AddPC.Size = new System.Drawing.Size(188, 42);
            this.AddPC.TabIndex = 2;
            this.AddPC.Text = "Add a Power Consumer";
            this.AddPC.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chaos";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 42);
            this.button3.TabIndex = 0;
            this.button3.Text = "Low Wind";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 42);
            this.button4.TabIndex = 1;
            this.button4.Text = "High Cloud";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 117);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 42);
            this.button5.TabIndex = 2;
            this.button5.Text = "Low Water";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.WaterAmount);
            this.groupBox3.Controls.Add(this.WindAmount);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.SolarAmount);
            this.groupBox3.Location = new System.Drawing.Point(219, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(933, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resources";
            // 
            // SolarAmount
            // 
            this.SolarAmount.Location = new System.Drawing.Point(9, 40);
            this.SolarAmount.Name = "SolarAmount";
            this.SolarAmount.Size = new System.Drawing.Size(208, 23);
            this.SolarAmount.Step = 1;
            this.SolarAmount.TabIndex = 0;
            this.SolarAmount.Value = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sun Light";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wind";
            // 
            // WindAmount
            // 
            this.WindAmount.Location = new System.Drawing.Point(9, 88);
            this.WindAmount.Name = "WindAmount";
            this.WindAmount.Size = new System.Drawing.Size(208, 23);
            this.WindAmount.TabIndex = 3;
            this.WindAmount.Value = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Water";
            // 
            // WaterAmount
            // 
            this.WaterAmount.Location = new System.Drawing.Point(223, 39);
            this.WaterAmount.Name = "WaterAmount";
            this.WaterAmount.Size = new System.Drawing.Size(208, 23);
            this.WaterAmount.TabIndex = 4;
            this.WaterAmount.Value = 90;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TotalPower);
            this.groupBox4.Controls.Add(this.TotalFreq);
            this.groupBox4.Location = new System.Drawing.Point(219, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(933, 110);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Grid Status";
            // 
            // TotalFreq
            // 
            this.TotalFreq.AutoSize = true;
            this.TotalFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFreq.Location = new System.Drawing.Point(675, 18);
            this.TotalFreq.Name = "TotalFreq";
            this.TotalFreq.Size = new System.Drawing.Size(252, 69);
            this.TotalFreq.TabIndex = 0;
            this.TotalFreq.Text = "50.00Hz";
            // 
            // TotalPower
            // 
            this.TotalPower.AutoSize = true;
            this.TotalPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPower.Location = new System.Drawing.Point(6, 20);
            this.TotalPower.Name = "TotalPower";
            this.TotalPower.Size = new System.Drawing.Size(269, 69);
            this.TotalPower.TabIndex = 1;
            this.TotalPower.Text = "5000MW";
            // 
            // PSList
            // 
            this.PSList.HideSelection = false;
            this.PSList.Location = new System.Drawing.Point(219, 259);
            this.PSList.Name = "PSList";
            this.PSList.Size = new System.Drawing.Size(321, 475);
            this.PSList.TabIndex = 4;
            this.PSList.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 746);
            this.Controls.Add(this.PSList);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Grid Balancer Pre Alpha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddPC;
        private System.Windows.Forms.Button AddPS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar WaterAmount;
        private System.Windows.Forms.ProgressBar WindAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar SolarAmount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label TotalPower;
        private System.Windows.Forms.Label TotalFreq;
        private System.Windows.Forms.ListView PSList;
    }
}

