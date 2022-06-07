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

                    //About5.3
                    File.AppendAllText(CTsaveFD.FileName, "3. " + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelName3.Text + TxtBoxName3.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelDate3.Text + TxtBoxDate3.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelTime3.Text + TxtBoxTime3.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelLoc3.Text + TxtBoxLoc3.Text + "\r\n");

                    //About5.4
                    File.AppendAllText(CTsaveFD.FileName, "4. " + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelName4.Text + TxtBoxName4.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelDate4.Text + TxtBoxDate4.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelTime4.Text + TxtBoxTime4.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelLoc4.Text + TxtBoxLoc4.Text + "\r\n");

                    //About5.5
                    File.AppendAllText(CTsaveFD.FileName, "5. " + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelName5.Text + TxtBoxName5.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelDate5.Text + TxtBoxDate5.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelTime5.Text + TxtBoxTime5.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelLoc5.Text + TxtBoxLoc5.Text + "\r\n");

                    //About5.6
                    File.AppendAllText(CTsaveFD.FileName, "6. " + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelName6.Text + TxtBoxName6.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelDate6.Text + TxtBoxDate6.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelTime6.Text + TxtBoxTime6.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelLoc6.Text + TxtBoxLoc6.Text + "\r\n");

                    //About5.7
                    File.AppendAllText(CTsaveFD.FileName, "7. " + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelName7.Text + TxtBoxName7.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelDate7.Text + TxtBoxDate7.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelTime7.Text + TxtBoxTime7.Text + "\r\n");
                    File.AppendAllText(CTsaveFD.FileName, "\t" + CTlabelLoc7.Text + TxtBoxLoc7.Text + "\r\n");


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

        private void CTbtnClear_Click(object sender, EventArgs e)
        {
            //TextBox
            TxtBoxFN.Text = "";
            TxtBoxMN.Text = "";
            TxtBoxSN.Text = "";
            TxtBoxSuffix.Text = "";
            TxtBoxAge.Text = "";
            TxtBoxPN.Text = "";
            TxtBoxEmail.Text = "";
            TxtBoxBP.Text = "";
            TxtBoxCA.Text = "";
            TxtBoxMotherFN.Text = "";
            TxtBoxMotherMN.Text = "";
            TxtBoxMotherSN.Text = "";
            TxtBoxMotherSuffix.Text = "";
            TxtBoxMotherPN.Text = "";
            TxtBoxMotherCA.Text = "";
            TxtBoxFatherFN.Text = "";
            TxtBoxFatherMN.Text = "";
            TxtBoxFatherSN.Text = "";
            TxtBoxFatherSuffix.Text = "";
            TxtBoxFatherPN.Text = "";
            TxtBoxFatherCA.Text = "";
            TxtBoxName1.Text = "";
            TxtBoxName2.Text = "";
            TxtBoxName3.Text = "";
            TxtBoxName4.Text = "";
            TxtBoxName5.Text = "";
            TxtBoxName6.Text = "";
            TxtBoxName7.Text = "";
            TxtBoxDate1.Text = "";
            TxtBoxDate2.Text = "";
            TxtBoxDate3.Text = "";
            TxtBoxDate4.Text = "";
            TxtBoxDate6.Text = "";
            TxtBoxDate7.Text = "";
            TxtBoxTime1.Text = "";

            //CheckBox
            CTcheckboxYes1.Checked = false;
            CTcheckboxYes2.Checked = false;
            CTcheckboxYes3.Checked = false;
            CTcheckboxYes4.Checked = false;
            CTcheckbocNo1.Checked = false;
            CTcheckboxNo2.Checked = false;
            CTcheckboxNo3.Checked = false;
            CTcheckboxNo4.Checked = false;
            CTcheckboxIDK1.Checked = false;
        }
    }
}
