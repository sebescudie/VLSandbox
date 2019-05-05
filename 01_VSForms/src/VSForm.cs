using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSForms
{
    public partial class VSForm : Form
    {
        public VSForm()
        {
            InitializeComponent();
        }

        public Form GetForm()
        {
            return this;
        }
    }
}
