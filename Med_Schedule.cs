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
    public partial class Med_Schedule : UserControl
    {

        string Mmed_CB1;
        string Mmed_CB2;
        string Mmed_CB3;
        string Mmed_CB4;
        string Mmed_CB5;
        string Mmed_CB6;

        string Tmed_CB1;
        string Tmed_CB2;
        string Tmed_CB3;
        string Tmed_CB4;
        string Tmed_CB5;
        string Tmed_CB6;

        public Med_Schedule()
        {
            InitializeComponent();
            Set_MSP_Text();

            MCB1.Text = Mmed_CB1;
            MCB2.Text = Mmed_CB2;
            MCB3.Text = Mmed_CB3;
            MCB4.Text = Mmed_CB4;
            MCB5.Text = Mmed_CB5;
            MCB6.Text = Mmed_CB6;

            TCB1.Text = Tmed_CB1;
            TCB2.Text = Tmed_CB2;
            TCB3.Text = Tmed_CB3;
            TCB4.Text = Tmed_CB4;
            TCB5.Text = Tmed_CB5;
            TCB6.Text = Tmed_CB6;
        }

        public void Get_MSP_Text()
        {
            //XmlDocument xmldoc = new XmlDocument();
            //xmldoc.Load("Prescription_Data.xml");
            //Search_Name = Search_NameTB.Text;

            //XmlElement Get_Name_Searched = (XmlElement)xmldoc.SelectSingleNode("Item/Name[@Name= '" + Search_Name + "']");
            //NM_Rate = Get_Name_Searched.Attributes["Rate"].InnerText;
        }

        public void Set_MSP_Text()
        {
            Mmed_CB1 = "Empty Slot";
            Mmed_CB2 = "Empty Slot";
            Mmed_CB3 = "Empty Slot";
            Mmed_CB4 = "Empty Slot";
            Mmed_CB5 = "Empty Slot";
            Mmed_CB6 = "Empty Slot";

            Tmed_CB1 = "Empty Slot";
            Tmed_CB2 = "Empty Slot";
            Tmed_CB3 = "Empty Slot";
            Tmed_CB4 = "Empty Slot";
            Tmed_CB5 = "Empty Slot";
            Tmed_CB6 = "Empty Slot";
        }

        private void MCB1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TCB1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
