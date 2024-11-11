namespace data_call_senter_forms
{
    using System.Drawing.Text;
    using System.IO;
    public partial class Form1 : Form
    {
        private object arrlData;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerName.Text.Trim() == "")
                {
                    MessageBox.Show("enter the all data");
                    return;
                }
                if (txtCustomerAge.Text.Trim() == "")
                {
                    MessageBox.Show("enter the all data");
                    return;
                }
                if (txtCustomerAdrres.Text.Trim() == "")
                {
                    MessageBox.Show("enter the all data");
                    return;
                }
                if (txtCustomerEmail.Text.Trim() == "")
                {
                    MessageBox.Show("enter the all data");
                    return;
                }
                if (txtCustomerPhone.Text.Trim() == "")
                {
                    MessageBox.Show("enter the all data");
                    return;
                }
                if (cmbCustomerSocialFeeling.Text.Trim() == "")
                {
                    MessageBox.Show("enter the all data");
                    return;
                }
                if (txtCombanyName.Text.Trim() == "")
                {
                    MessageBox.Show("enter the all data");
                    return;
                }
                if (txtCombanyBranch.Text.Trim() == "")
                {
                    MessageBox.Show("enter the all data");
                    return;
                }
                if (txtMarketName.Text.Trim() == "")
                {
                    MessageBox.Show("enter the all data");
                    return;
                }
                if (cmdProdoctTypes.Text.Trim() == "")
                {
                    MessageBox.Show("enter the all data");
                    return;
                }
                if (txtProdoctName.Text.Trim() == "")
                {
                    MessageBox.Show("enter the all data");
                    return;
                }
                if (txtProdoctCode.Text.Trim() == "")
                {
                    MessageBox.Show("enter the all data");
                    return;
                }
                if (txtProdoctPrice.Text.Trim() == "")
                {
                    MessageBox.Show("enter the all data");
                    return;
                }
                if (txtDescontPrise.Text.Trim() == "")
                {
                    MessageBox.Show("enter the all data");
                    return;
                }

                StreamReader srCheck = new StreamReader("Data.txt");
                string strChek = srCheck.ReadToEnd();
                srCheck.Close();
                if (strChek.Contains(txtCustomerName.Text + "; "))
                {
                    MessageBox.Show("the customer name is exist, please change try agin !");
                    txtCustomerName.Focus();
                    txtCustomerName.SelectAll();
                }
                else
                {

                    StreamWriter sw = new StreamWriter("Data.txt", true);
                    string strPerson = txtCustomerName + "; " + txtCustomerAge + "; " + txtCustomerAdrres + "; " + txtCustomerEmail + "; " + txtCustomerPhone + "; " + cmbCustomerSocialFeeling;

                    string strCombany = txtCombanyName + "; " + txtCombanyBranch + "; " + txtMarketName + "; " + cmdProdoctTypes + "; " + txtProdoctName + "; " + txtProdoctCode + "; " + txtProdoctPrice + "; " + txtDescontPrise;
                    sw.WriteLine(strPerson);
                    sw.WriteLine(strCombany);
                    sw.Close();

                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox || c is ComboBox || c is RichTextBox)
                            c.Text = "";
                        txtCustomerName.Focus();
                    }
                    MessageBox.Show("the persone is add");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnDelet_Click(object sender, EventArgs e)
        {


            StreamWriter sw = new StreamWriter("Data.txt", false);
            sw.Close();




            MessageBox.Show("the old data is delet please add new data");

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Trim() != "")
            {
                StreamReader sr = new StreamReader("Data.txt");
                string line = "";
                bool found = false;
                do
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] arrlData = line.Split(';');
                        if (arrlData[0] == txtCustomerName.Text)
                        {
                            MessageBox.Show("the persone name is don't found");
                            found = false;
                            break;
                        }
                        else
                            
                        {
                            txtCustomerName.Text = arrlData[0];
                            txtCustomerAge.Text = arrlData[1];
                            txtCustomerAdrres.Text = arrlData[2];
                            txtCustomerEmail.Text = arrlData[3];
                            txtCustomerPhone.Text = arrlData[4];
                            cmbCustomerSocialFeeling.Text = arrlData[5];


                            txtCombanyName.Text = arrlData[6];
                            txtCombanyBranch.Text = arrlData[7];
                            txtMarketName.Text = arrlData[8];
                            cmdProdoctTypes.Text = arrlData[9];
                            txtProdoctName.Text = arrlData[10];
                            txtProdoctCode.Text = arrlData[11];
                            txtProdoctPrice.Text = arrlData[12];
                            txtDescontPrise.Text = arrlData[13];
                            found = true;
                            break;
                        }
                    }

                } while
                (
                  line != null
                );
                sr.Close();

            }
            else
            {

                MessageBox.Show("enter customer name and try agian!");
                txtCustomerName.Focus();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Data.txt",true);
             MessageBox.Show( sr.ReadToEnd());
            sr.ReadLine();
            sr.Close();

             
        }
    }
}
