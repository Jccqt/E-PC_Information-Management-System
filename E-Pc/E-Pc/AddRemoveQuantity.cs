using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Pc
{
    public partial class AddRemoveQuantity : UserControl
    {
        public AddRemoveQuantity()
        {
            InitializeComponent();
        }

        private void AddRemoveQuantity_Load(object sender, EventArgs e)
        {
            CurrentQuantityBox.Text = EditItem.originalQuantity.ToString();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(!QuantityToAddRemoveBox.Text.Equals("") && !RemarksBox.Text.Equals("") && !QuantityToAddRemoveBox.Text.Equals("0"))
            {
                if(AddDeleteHeader.Text.Equals("Adding quantity"))
                {
                    PageObjects.editItemPage.QuantityBox.Text = (EditItem.originalQuantity
                                                                + Convert.ToInt32(QuantityToAddRemoveBox.Text)).ToString();
                    PageObjects.editItemPage.QuantityActivityLabel.Text = $"You added {QuantityToAddRemoveBox.Text} quantity";
                    PageObjects.editItemPage.Remarks.Text = RemarksBox.Text;
                    PageObjects.editItemPage.QuantityActivityLabel.Visible = true;
                    ((Form)this.TopLevelControl).Close();
                }
                else
                {
                    if(Convert.ToInt32(QuantityToAddRemoveBox.Text) > EditItem.originalQuantity)
                    {
                        MessageBox.Show("You cannot remove quantity more than the original quantity!", "Invalid quantity!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        PageObjects.editItemPage.QuantityBox.Text = (EditItem.originalQuantity
                                                                - Convert.ToInt32(QuantityToAddRemoveBox.Text)).ToString();
                        PageObjects.editItemPage.QuantityActivityLabel.Text = $"You removed {QuantityToAddRemoveBox.Text} quantity";
                        PageObjects.editItemPage.Remarks.Text = RemarksBox.Text;
                        PageObjects.editItemPage.QuantityActivityLabel.Visible = true;
                        ((Form)this.TopLevelControl).Close();
                    }
                }
            } 
            else if (QuantityToAddRemoveBox.Text.Equals("0"))
            {
                MessageBox.Show("You cannot insert 0 quantity", "Invalid quantity!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(QuantityToAddRemoveBox.Text.Equals("") || RemarksBox.Text.Equals(""))
            {
                MessageBox.Show("You cannot save empty details!", "Empty details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuantityToAddRemoveBox_TextChanged(object sender, EventArgs e)
        {
            if(!QuantityToAddRemoveBox.Text.Equals("") && !Regex.IsMatch(QuantityToAddRemoveBox.Text, InputValidation.numberPattern))
            {
                MessageBox.Show("Invalid input! Please enter numeric only [0-9]", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityToAddRemoveBox.Text = QuantityToAddRemoveBox.Text.Remove(QuantityToAddRemoveBox.Text.Length - 1);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}
