using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
    public partial class Add_Medication : UserControl
    {
        string mnTB;
        string dTB;

        string MCheck;
        string TCheck;
        string WCheck;
        string ThCheck;
        string FCheck;
        string SCheck;
        string SuCheck;

        string _MCheck;
        string _TCheck;
        string _WCheck;
        string _ThCheck;
        string _FCheck;
        string _SCheck;
        string _SuCheck;

        public Add_Medication()
        {
            InitializeComponent();
        }

        private void Go_Back_Click(object sender, EventArgs e)
        {
            MName_TB.Text = "Enter Here...";
            Dosage_TB.Text = "Enter Here...";
            Form1.Panel_Reset();
        }

        private void Get_Data_Fields()
        {
            mnTB = MName_TB.Text;
            dTB = Dosage_TB.Text;

            MCheck = _MCheck;
            //TCheck;
            //WCheck;
            //ThCheck;
            //FCheck;
            //SCheck;
            //SuCheck;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Get_Data_Fields();
            XDocument xdoc = XDocument.Load("Prescription_Data.xml");
            XElement XPrescription_Data = xdoc.Element("Prescription_Data"); 

            try
            {
                XPrescription_Data.Add(new XElement("Prescription",
                    new XAttribute("Name", mnTB), 
                    new XAttribute("Dosage", dTB),
                    new XAttribute("Monday", MCheck)));
                xdoc.Save("Prescription_Data.xml");
                MessageBox.Show("Saved!");
            }
            catch
            {
                MessageBox.Show("Error Please Try Again!");
            }            
        }

        private void MCB_CheckedChanged(object sender, EventArgs e)
        {
            _MCheck = "Yes";
        }

        private void TCB_CheckedChanged(object sender, EventArgs e)
        {
            _TCheck = "Yes";
        }

        private void WCB_CheckedChanged(object sender, EventArgs e)
        {
            _WCheck = "W";
        }

        private void ThCB_CheckedChanged(object sender, EventArgs e)
        {
            _ThCheck = "Th";
        }

        private void FCB_CheckedChanged(object sender, EventArgs e)
        {
            _FCheck = "F";
        }

        private void SCB_CheckedChanged(object sender, EventArgs e)
        {
            _SCheck = "S";
        }

        private void SuCB_CheckedChanged(object sender, EventArgs e)
        {
            _SuCheck = "Su";
        }
    }
}
