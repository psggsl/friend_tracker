using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FriendTracker;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InteractionForm : Form
    {
        public string SelectedFriend { get; set; }
        public string InteractionType { get; set; }
        public DateTime SelectedDate { get; set; }

        public InteractionForm(List<string> friends)
        {
            InitializeComponent();
            comboFriends.Items.AddRange(friends.ToArray());
            comboFriends.SelectedIndex = 0;
            datePicker.Value = DateTime.Today;
        }

        private void comboFriends_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (comboFriends.SelectedItem == null)
            {
                MessageBox.Show("Выберите друга.");
                return;
            }

            SelectedFriend = comboFriends.SelectedItem.ToString();
            SelectedDate = datePicker.Value;

            if (rbMessage.Checked) InteractionType = "Сообщение";
            else if (rbCall.Checked) InteractionType = "Звонок";
            else if (rbMeeting.Checked) InteractionType = "Встреча";
            else if (rbEvent.Checked) InteractionType = "Мероприятие";
            else
            {
                MessageBox.Show("Выберите тип взаимодействия.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void groupInteraction_Enter(object sender, EventArgs e)
        {

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbMessage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMeeting_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbEvent_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
