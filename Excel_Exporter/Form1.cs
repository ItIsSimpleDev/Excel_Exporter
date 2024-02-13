using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel_Exporter
{
    public partial class Form1 : Form
    {
        private List<SimpleData> simpleDatas = new List<SimpleData>();
        public Form1()
        {
            InitializeComponent();
            simpleDatas = SimpleData.GetSimpleDatas();
            dataGridView1.DataSource = simpleDatas;
        }

        private void exportToExcelBtn_Click(object sender, EventArgs e)
        {
            Excel.ExportToExcel(ConvertListToObjects(simpleDatas));
        }

        private List<object> ConvertListToObjects<T>(List<T> sourceList)
        {
            return sourceList.Cast<object>().ToList();
        }
    }
}
