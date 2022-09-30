using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorExam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancelar_click(object sender, EventArgs e)
        {
            txtResultado1.Text = "0";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                if (checkedListBox1.CheckedItems.Count == 1)
                {
                    btnAceptar.Enabled = false;
                }
            }
        }
    }
    }
}
