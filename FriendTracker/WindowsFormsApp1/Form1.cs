using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FriendTracker;
using Newtonsoft.Json;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private List<Friend> friends = new List<Friend>();

        private string dataPath = "friends.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void LoadFriends()
        {
            if (File.Exists(dataPath))
            {
                string json = File.ReadAllText(dataPath);
                friends = JsonConvert.DeserializeObject<List<Friend>>(json) ?? new List<Friend>();
            }
        }

        private void SaveFriends()
        {
            string json = JsonConvert.SerializeObject(friends, Formatting.Indented);
            File.WriteAllText(dataPath, json);
        }




        private void buttonAddFriend_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Введите имя друга:", "Добавить друга", "");
            if (!string.IsNullOrWhiteSpace(name))
            {
                friends.Add(new Friend { Name = name });
                SaveFriends();
                MessageBox.Show($"Добавлен: {name}", "Успешно");
            }

        }

        private void buttonAddInteraction_Click(object sender, EventArgs e)
        {
           
            var interactionForm = new InteractionForm(friends.Select(f => f.Name).ToList());

            if (interactionForm.ShowDialog() == DialogResult.OK)
            {
                string name = interactionForm.SelectedFriend;
                string type = interactionForm.InteractionType;
                DateTime date = interactionForm.SelectedDate;

               

                var friend = friends.FirstOrDefault(f => f.Name == name);
                if (friend != null)
                {
                    
                    friend.LastContact = date.ToString("yyyy-MM-dd");
                    SaveFriends();
                }


                MessageBox.Show($"✅ Добавлено  баллов за {type} с {name} от {date:dd.MM.yyyy}");
            }
        }

        private void listBoxReminders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowStats_Click(object sender, EventArgs e)
        {
            string stats = "Список друзей:\n\n" + string.Join("\n", friends);
            MessageBox.Show(stats, "Статистика");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажата кнопка взаимодействия");
        }
    }
}
