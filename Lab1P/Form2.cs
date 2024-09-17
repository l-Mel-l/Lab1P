using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1P {
    public partial class Form2 : Form {

        private string buttonText;

        public Form2(string buttonText)
        {
            InitializeComponent();
            this.buttonText = buttonText;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = buttonText; 
        }
    }
}
