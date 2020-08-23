using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridBalancer
{
    public partial class AddNewPS : Form
    {
        public AddNewPS()
        {
            InitializeComponent();
        }

        private void AddNewPS_Load(object sender, EventArgs e)
        {

        }

        public string getName()
        {
                return Name.Text;
        }

        public int getType()
        {
            return Type.SelectedIndex; 
        }

        public string getPower()
        {
            return Power.Value.ToString();
        }

        private void AddPS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
