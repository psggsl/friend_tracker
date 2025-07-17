namespace WindowsFormsApp1
{
    partial class InteractionForm
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
            this.comboFriends = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.groupInteraction = new System.Windows.Forms.GroupBox();
            this.rbEvent = new System.Windows.Forms.RadioButton();
            this.rbMeeting = new System.Windows.Forms.RadioButton();
            this.rbMessage = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rbCall = new System.Windows.Forms.RadioButton();
            this.groupInteraction.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboFriends
            // 
            this.comboFriends.FormattingEnabled = true;
            this.comboFriends.Location = new System.Drawing.Point(34, 75);
            this.comboFriends.Name = "comboFriends";
            this.comboFriends.Size = new System.Drawing.Size(158, 21);
            this.comboFriends.TabIndex = 0;
            this.comboFriends.Text = "Список друзей";
            this.comboFriends.SelectedIndexChanged += new System.EventHandler(this.comboFriends_SelectedIndexChanged);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(198, 76);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 1;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // groupInteraction
            // 
            this.groupInteraction.Controls.Add(this.rbCall);
            this.groupInteraction.Controls.Add(this.rbEvent);
            this.groupInteraction.Controls.Add(this.rbMeeting);
            this.groupInteraction.Controls.Add(this.rbMessage);
            this.groupInteraction.Location = new System.Drawing.Point(431, 76);
            this.groupInteraction.Name = "groupInteraction";
            this.groupInteraction.Size = new System.Drawing.Size(200, 226);
            this.groupInteraction.TabIndex = 2;
            this.groupInteraction.TabStop = false;
            this.groupInteraction.Text = "Варианты взаимодействия";
            this.groupInteraction.Enter += new System.EventHandler(this.groupInteraction_Enter);
            // 
            // rbEvent
            // 
            this.rbEvent.AutoSize = true;
            this.rbEvent.Location = new System.Drawing.Point(17, 106);
            this.rbEvent.Name = "rbEvent";
            this.rbEvent.Size = new System.Drawing.Size(93, 17);
            this.rbEvent.TabIndex = 6;
            this.rbEvent.TabStop = true;
            this.rbEvent.Text = "Мероприятие";
            this.rbEvent.UseVisualStyleBackColor = true;
            this.rbEvent.CheckedChanged += new System.EventHandler(this.rbEvent_CheckedChanged);
            // 
            // rbMeeting
            // 
            this.rbMeeting.AutoSize = true;
            this.rbMeeting.Location = new System.Drawing.Point(17, 83);
            this.rbMeeting.Name = "rbMeeting";
            this.rbMeeting.Size = new System.Drawing.Size(66, 17);
            this.rbMeeting.TabIndex = 5;
            this.rbMeeting.TabStop = true;
            this.rbMeeting.Text = "Встреча";
            this.rbMeeting.UseVisualStyleBackColor = true;
            this.rbMeeting.CheckedChanged += new System.EventHandler(this.rbMeeting_CheckedChanged);
            // 
            // rbMessage
            // 
            this.rbMessage.AutoSize = true;
            this.rbMessage.Location = new System.Drawing.Point(17, 37);
            this.rbMessage.Name = "rbMessage";
            this.rbMessage.Size = new System.Drawing.Size(83, 17);
            this.rbMessage.TabIndex = 3;
            this.rbMessage.TabStop = true;
            this.rbMessage.Text = "Сообщение";
            this.rbMessage.UseVisualStyleBackColor = true;
            this.rbMessage.CheckedChanged += new System.EventHandler(this.rbMessage_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(431, 347);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 34);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Подтвердить";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rbCall
            // 
            this.rbCall.AutoSize = true;
            this.rbCall.Location = new System.Drawing.Point(17, 60);
            this.rbCall.Name = "rbCall";
            this.rbCall.Size = new System.Drawing.Size(62, 17);
            this.rbCall.TabIndex = 7;
            this.rbCall.TabStop = true;
            this.rbCall.Text = "Звонок";
            this.rbCall.UseVisualStyleBackColor = true;
            this.rbCall.CheckedChanged += new System.EventHandler(this.rbCall_CheckedChanged);
            // 
            // InteractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupInteraction);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.comboFriends);
            this.Name = "InteractionForm";
            this.Text = "InteractionForm";
            this.groupInteraction.ResumeLayout(false);
            this.groupInteraction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFriends;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.GroupBox groupInteraction;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rbMeeting;
        private System.Windows.Forms.RadioButton rbMessage;
        private System.Windows.Forms.RadioButton rbEvent;
        private System.Windows.Forms.RadioButton rbCall;
    }
}