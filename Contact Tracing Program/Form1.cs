using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing_Program
{
    public partial class ContactTracingProg : Form
    {
        public ContactTracingProg()
        {
            InitializeComponent();
        }

        private void CTlabel3_Click(object sender, EventArgs e)
        {

        }

        private void CTProgram_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(TxtBoxFN.Text + " " + TxtBoxMN.Text + " " + TxtBoxSN.Text);
        }

        private void CTlabelname_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxFatherPN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CTbtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            CTsaveFD.Filter = "txt files (*.txt) | *.txt|All files (*.*)|*.*";
            CTsaveFD.RestoreDirectory = true;

            if (CTsaveFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //About1
                    File.WriteAllText(CTsaveFD.FileName, CTlabelAbout1.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, CTlabelName.Text + TxtBoxFN.Text + " " + TxtBoxMN.Text + " " + TxtBoxSN.Text + " " + TxtBoxSuffix.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, CTlabelAge.Text + TxtBoxAge.Text + " years old" + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, CTlabelBirthday.Text + CTcboxMonth.SelectedItem.ToString() + " " + CTcboxDay.SelectedItem.ToString() + " " + CTcboxYear.SelectedItem.ToString() + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, CTlabelSex.Text + CTcboxSexFM.SelectedItem.ToString() + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, CTlabelPNumber.Text + TxtBoxPN.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, CTlabelEmail.Text + TxtBoxEmail.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, CTlabelBirthPlace.Text + TxtBoxBP.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, CTlabelCurrentAddress.Text + TxtBoxCA.Text + "\r\n" + "\r\n");

                    //About2
                    File.AppendAllText(CTsaveFD.FileName, CTlabelAbout2.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, CTlabelMother.Text + TxtBoxMotherFN.Text + " " + TxtBoxMotherMN.Text + " " + TxtBoxMotherSN.Text + " " + TxtBoxMotherSuffix.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, CTlabelMotherPNumber.Text + TxtBoxMotherPN.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, CTlabelMotherCA.Text + TxtBoxMotherCA.Text +"\r\n");
                    File.AppendAllText(CTsaveFD.FileName, CTlabelFather.Text + TxtBoxFatherFN.Text + " " + TxtBoxFatherMN.Text + " " + TxtBoxFatherSN.Text + " " + TxtBoxFatherSuffix.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, CTlabelFatherPNumber.Text + TxtBoxFatherPN.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, CTlabelFatherCA.Text + TxtBoxFatherCA.Text + "\r\n" + "\r\n");

                    //About3
                    File.AppendAllText(CTsaveFD.FileName, CTlabelAbout3.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "1. " + CTlabelQ1.Text + "- " + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTcheckboxYes1.Text + ": " + CTcheckboxYes1.Checked.ToString() + " " + CTcheckbocNo1.Text + ": " + CTcheckbocNo1.Checked.ToString() + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "2. " + CTlabelQ2.Text + "- " + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTcheckboxYes2.Text + ": " + CTcheckboxYes2.Checked.ToString() + " " + CTcheckboxNo2.Text + ": " + CTcheckboxNo2.Checked.ToString() + "\r\n" + "\r\n");

                    //About4
                    File.AppendAllText(CTsaveFD.FileName, CTlabelAbout4.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "3. " + CTlabelQ3.Text + "- " + "\r\n" );
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTcheckboxYes3.Text + ": " + CTcheckboxYes3.Checked.ToString() + " " + CTcheckboxNo3.Text + ": " + CTcheckboxNo3.Checked.ToString() + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "4. " + CTlabelQ4.Text + "- " + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTcheckboxYes4.Text + ": " + CTcheckboxYes4.Checked.ToString() + " " + CTcheckboxNo4.Text + ": " + CTcheckboxNo4.Checked.ToString() + " " + CTcheckboxIDK1.Text + ": " + CTcheckboxIDK1.Checked.ToString() + "\r\n" + "\r\n");

                    //About5.1
                    File.AppendAllText(CTsaveFD.FileName, CTlabelAbout5.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "1. " + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelName1.Text + TxtBoxName1.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelDate1.Text + TxtBoxDate1.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelTime1.Text + TxtBoxTime1.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelLoc1.Text + TxtBoxLoc1.Text + "\r\n");

                    //About5.2
                    File.AppendAllText(CTsaveFD.FileName, "2. " + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelName2.Text + TxtBoxName2.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelDate2.Text + TxtBoxDate2.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelTime2.Text + TxtBoxTime2.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelLoc2.Text + TxtBoxLoc2.Text + "\r\n");

                    MessageBox.Show("File Saved");
                }
                catch 
                {

                    MessageBox.Show("Incomplete please answer every question.");
                }
            }
        }

        private void TxtBoxFN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
