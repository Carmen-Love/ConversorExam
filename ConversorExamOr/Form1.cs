using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorExamOr
{
    public partial class Form1 : Form
    {
        private Double resultado1, = 0;
        private String operacion = "";
        private Boolean enter = false;
        public Form1()
        {
        
        InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            If e.NewValue = CheckState.Unchecked Then
        If checkedListBox1.CheckedItems.Count = 1 Then
            MsgBox("EUR - Euro")
             Else
            MsgBox("USD - Dólar estadounidense")
             End If
             Else
            MsgBox("CAD - Dólar canadiense")
        }

        private void MsgBox(string v)
        {
            throw new NotImplementedException();
        }

        private void txtMoneda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_click(object sender, EventArgs e)
        {
            Form2 nuevo = new();
            new.ShowDialog();
        }
    }
}
