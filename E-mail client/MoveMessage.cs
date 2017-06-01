using System.Collections.Generic;
using System.Windows.Forms;

namespace E_mail_client
{
    public partial class MoveMessage : Form
    {
        public string Result { get; set; }

        public MoveMessage(List<string> list)
        {
            InitializeComponent();
            list.ForEach(str => comboBox.Items.Add(str));
            comboBox.SelectedIndex = 0;
        }

        private void BtnOk_Click(object sender, System.EventArgs e)
        {

            Result = comboBox.SelectedItem.ToString();
            Close();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
