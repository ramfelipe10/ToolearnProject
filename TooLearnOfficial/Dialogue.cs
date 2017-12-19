using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TooLearnOfficial
{
    public partial class Dialogue : Form
    {
        public Dialogue()
        {
            InitializeComponent();
        }

        static DialogueBox MsgBox; static DialogResult result = DialogResult.No;

        public static DialogResult Show(string Text, string Caption, string btnOK, string btnCancel)
        {
            MsgBox = new DialogueBox();
            MsgBox.label1.Text = Text;
            MsgBox.bunifuFlatButton1.Text = btnOK;
            MsgBox.bunifuFlatButton2.Text = btnCancel;
            MsgBox.ShowDialog();
            return result;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            MsgBox.Close();
        }
    }
}
