namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddFriend = new System.Windows.Forms.Button();
            this.buttonAddInteraction = new System.Windows.Forms.Button();
            this.listBoxReminders = new System.Windows.Forms.ListBox();
            this.buttonShowStats = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddFriend
            // 
            this.buttonAddFriend.Location = new System.Drawing.Point(93, 122);
            this.buttonAddFriend.Name = "buttonAddFriend";
            this.buttonAddFriend.Size = new System.Drawing.Size(164, 33);
            this.buttonAddFriend.TabIndex = 0;
            this.buttonAddFriend.Text = "Добавить друга";
            this.buttonAddFriend.UseVisualStyleBackColor = true;
            this.buttonAddFriend.Click += new System.EventHandler(this.buttonAddFriend_Click);
            // 
            // buttonAddInteraction
            // 
            this.buttonAddInteraction.Location = new System.Drawing.Point(93, 182);
            this.buttonAddInteraction.Name = "buttonAddInteraction";
            this.buttonAddInteraction.Size = new System.Drawing.Size(164, 33);
            this.buttonAddInteraction.TabIndex = 1;
            this.buttonAddInteraction.Text = "Добавить взаимодействие";
            this.buttonAddInteraction.UseVisualStyleBackColor = true;
            this.buttonAddInteraction.Click += new System.EventHandler(this.buttonAddInteraction_Click);
            // 
            // listBoxReminders
            // 
            this.listBoxReminders.FormattingEnabled = true;
            this.listBoxReminders.Location = new System.Drawing.Point(434, 122);
            this.listBoxReminders.Name = "listBoxReminders";
            this.listBoxReminders.Size = new System.Drawing.Size(206, 251);
            this.listBoxReminders.TabIndex = 3;
            this.listBoxReminders.SelectedIndexChanged += new System.EventHandler(this.listBoxReminders_SelectedIndexChanged);
            // 
            // buttonShowStats
            // 
            this.buttonShowStats.Location = new System.Drawing.Point(93, 239);
            this.buttonShowStats.Name = "buttonShowStats";
            this.buttonShowStats.Size = new System.Drawing.Size(164, 33);
            this.buttonShowStats.TabIndex = 4;
            this.buttonShowStats.Text = "Показать статистику";
            this.buttonShowStats.UseVisualStyleBackColor = true;
            this.buttonShowStats.Click += new System.EventHandler(this.buttonShowStats_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonShowStats);
            this.Controls.Add(this.listBoxReminders);
            this.Controls.Add(this.buttonAddInteraction);
            this.Controls.Add(this.buttonAddFriend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddFriend;
        private System.Windows.Forms.Button buttonAddInteraction;
        private System.Windows.Forms.ListBox listBoxReminders;
        private System.Windows.Forms.Button buttonShowStats;
        private System.Windows.Forms.Button button1;
    }
}

