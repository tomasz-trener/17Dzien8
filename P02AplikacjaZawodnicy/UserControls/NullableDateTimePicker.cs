using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02AplikacjaZawodnicy.UserControls
{
    public partial class NullableDateTimePicker : UserControl
    {
        public NullableDateTimePicker()
        {
            InitializeComponent();
        }

        public DateTime? Value
        {
            get
            {
                if (dtpData.Visible)
                    return dtpData.Value;
                else
                    return null;
            }
            set
            {
                if (value == null)
                {
                    UkryjDate();
                }
                else
                {
                    txtData.Visible = false;
                    dtpData.Visible = true;
                    dtpData.Value = (DateTime)value;
                }
            }
        }

        private void UkryjDate()
        {
            txtData.Visible = true;
            dtpData.Visible = false;
        }

        private void dtpData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                Value = null;
        }

        private void txtData_Click(object sender, EventArgs e)
        {
            Value = DateTime.Now;
        }
    }
}
