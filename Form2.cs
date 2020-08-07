using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_detailsDataSet.acc_holder_details' table. You can move, or remove it, as needed.
            this.acc_holder_detailsTableAdapter.Fill(this.bank_detailsDataSet.acc_holder_details);
        }

        
    }
}
