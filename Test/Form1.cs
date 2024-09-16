using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<SinhVien> lsv = new List<SinhVien>();
        private void button1(object sender, EventArgs e)
        {
            
            SinhVien sv = new SinhVien()
            {
                MSSV = txtMSSV.Text,
                HoTen = txtHoTen.Text,
                NgaySinh = dtNgaySinh.Value,
                Lop = txtLop.Text,
            };
            lsv.Add(sv);
            dataSinVien.DataSource = null;
            dataSinVien.DataSource = lsv;            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < lsv.Count; i++)
            {
                if (lsv[i].MSSV == txtMSSV.Text)
                {
                    lsv.Remove(lsv[i]);
                    i--;
                }
            }
            dataSinVien.DataSource = null;
            dataSinVien.DataSource = lsv;
        }
    }
}
