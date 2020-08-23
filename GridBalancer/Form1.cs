using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GridBalancer
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        public double TotalEnergy = 0;
        public double SystemFreq = 0.00;

        public int Solar = 80;
        public int Wind = 80;
        public int Water = 80;

        List<PowerSource> PowerSources = new List<PowerSource>();

        public void MainStatus()
        {
            TotalPower.Text = TotalEnergy.ToString() + "mW";
            TotalFreq.Text = SystemFreq.ToString() + "Hz";
        }

        public void setResources()
        {
            SolarAmount.Value = Solar;
            WindAmount.Value = Wind;
            WaterAmount.Value = Water;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setResources();
            MainStatus();
        }

       

        private void AddPS_Click(object sender, EventArgs e)
        {
            AddNewPS addNewPS = new AddNewPS();
            
            
            DialogResult = addNewPS.ShowDialog();
        }
    }
}
