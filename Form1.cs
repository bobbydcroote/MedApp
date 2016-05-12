using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.Linq;
using System.IO;

namespace Med_App_Beta_1._0
{
    public partial class Form1 : Form
    {
        public static Panel P1;
        public static Med_Schedule MS = new Med_Schedule();

        public Form1()
        {
            InitializeComponent();
            panel1.Controls.Add(MS);
            P1 = panel1;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static Add_Medication AM = new Add_Medication();
        private void addNewMedicationNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Remove(MS);
            panel1.Controls.Add(AM);
        }
        
        public static void Panel_Reset()
        {
            P1.Controls.Remove(AM);
            P1.Controls.Add(MS);
        }
    }
}
