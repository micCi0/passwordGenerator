using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
        private string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string numberChars = "0123456789";
        private string specialChars = "!@#$%^&*()_-+=<>?";
        private string compbinations = "";
        private int passwordLength = 0;
        private string result = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compbinations = "";
            result = "";
            if (lowerCaseCheck.Checked)
            {
                compbinations = lowercaseChars;
            }
           
            if(upperCaseCheck.Checked)
            {
                compbinations = uppercaseChars;
            }
            if(numberCheck.Checked)
            {
                compbinations = numberChars;
            }
            if (symbolsCheck.Checked)
            {
                compbinations = specialChars;
            }
            else if(lowerCaseCheck.Checked && upperCaseCheck.Checked 
                && numberCheck.Checked && symbolsCheck.Checked)
            {
                compbinations = lowercaseChars + uppercaseChars
                    + numberChars + specialChars;
            }
            else if (lowerCaseCheck.Checked && upperCaseCheck.Checked 
                && numberCheck.Checked)
            {
                compbinations = lowercaseChars + uppercaseChars
                    + numberChars;
            }
            else if (lowerCaseCheck.Checked && upperCaseCheck.Checked )
            {
                compbinations = lowercaseChars + uppercaseChars;
            }

          

            GeneratePassword(compbinations);
        }

        private void GeneratePassword(string compbinations)
        {
            if (compbinations != "")
            {

                Random rand = new Random();
                for (int i = 0; i < passwordLength; i++)
                {
                    int index = rand.Next(0, compbinations.Length);
                    result += compbinations[index];
                }
                labelResult.Text = $"Password:{result}";
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select an option");
            }

        }

        private void ChangeLength(object sender, EventArgs e)
        {
            passwordLength = trackBar.Value;
            length.Text = passwordLength.ToString();
        }

        private  void CopyResult(object sender, EventArgs e)
        {
            if(labelResult.Text != null)
            {
                button2.Visible = true;
                Clipboard.SetText(labelResult.Text);
                 Thread.Sleep(1100);
                button2.Visible = false;
                labelResult.Text = null;

            }
            
        }
    }
}
