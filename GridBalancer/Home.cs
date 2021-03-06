﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GridBalancer
{
    public partial class Home : Form
    {

        
        public Home()
        {
            InitializeComponent();
        }

        public double TotalEnergy = 0;
        public double SystemFreq = 0.00;

        public int Solar = 80;
        public int Wind = 80;
        public int Water = 80;

        List<PowerSource> PowerSources = new List<PowerSource>();

        public void setList()
        {
            PSList.Items.Clear();
            PSList.Columns.Clear();

            PSList.View = View.Details;
            PSList.GridLines = true;
            PSList.FullRowSelect = true;

            PSList.Columns.Add("Name",50);
            PSList.Columns.Add("Type",50);
            PSList.Columns.Add("Power",50);
            foreach (PowerSource PXS in PowerSources)
            {
                string[] LVX = {PXS.Name, PXS.getPType(), PXS.Energy.ToString()};
                ListViewItem LVXI = new ListViewItem(LVX);
                PSList.Items.Add(LVXI);
            }
        }

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
            addNewPS.AcceptButton.DialogResult = DialogResult.OK;

            if (addNewPS.ShowDialog() == DialogResult.OK)
            {
                bool isV = false;
                double VT = 0;
                if (addNewPS.getType() > 4)
                {
                    isV = true;
                    VT = 100;
                }
                PowerSource PSX = new PowerSource(addNewPS.getName(), double.Parse(addNewPS.getPower()),addNewPS.getType(),isV,VT);

                PowerSources.Add(PSX);
                setList();
            }
        }
    }
}
