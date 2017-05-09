namespace E_mail_client
{
    partial class NewMessagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMessagesForm));
            this.panelButton = new System.Windows.Forms.Panel();
            this.saveInDrafts = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.lnkAddAttachments = new System.Windows.Forms.LinkLabel();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelButton.SuspendLayout();
            this.panelMessages.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.button2);
            this.panelButton.Controls.Add(this.saveInDrafts);
            this.panelButton.Controls.Add(this.send);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 354);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(424, 47);
            this.panelButton.TabIndex = 0;
            // 
            // saveInDrafts
            // 
            this.saveInDrafts.Image = global::E_mail_client.Properties.Resources.pencil;
            this.saveInDrafts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveInDrafts.Location = new System.Drawing.Point(118, 12);
            this.saveInDrafts.Name = "saveInDrafts";
            this.saveInDrafts.Size = new System.Drawing.Size(151, 23);
            this.saveInDrafts.TabIndex = 1;
            this.saveInDrafts.Text = "Сохранить в черновики";
            this.saveInDrafts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveInDrafts.UseVisualStyleBackColor = true;
            // 
            // send
            // 
            this.send.Image = global::E_mail_client.Properties.Resources.paper_plane;
            this.send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.send.Location = new System.Drawing.Point(25, 12);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(86, 23);
            this.send.TabIndex = 0;
            this.send.Text = "Отправить";
            this.send.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.Send_Click);
            // 
            // panelMessages
            // 
            this.panelMessages.Controls.Add(this.groupBox1);
            this.panelMessages.Controls.Add(this.lnkAddAttachments);
            this.panelMessages.Controls.Add(this.tbMessage);
            this.panelMessages.Controls.Add(this.tbTo);
            this.panelMessages.Controls.Add(this.tbSubject);
            this.panelMessages.Controls.Add(this.label2);
            this.panelMessages.Controls.Add(this.label1);
            this.panelMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessages.Location = new System.Drawing.Point(0, 0);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(424, 354);
            this.panelMessages.TabIndex = 1;
            // 
            // lnkAddAttachments
            // 
            this.lnkAddAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAddAttachments.AutoEllipsis = true;
            this.lnkAddAttachments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lnkAddAttachments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkAddAttachments.Image = global::E_mail_client.Properties.Resources.attach;
            this.lnkAddAttachments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkAddAttachments.LinkColor = System.Drawing.Color.Black;
            this.lnkAddAttachments.Location = new System.Drawing.Point(25, 77);
            this.lnkAddAttachments.Name = "lnkAddAttachments";
            this.lnkAddAttachments.Size = new System.Drawing.Size(375, 25);
            this.lnkAddAttachments.TabIndex = 5;
            this.lnkAddAttachments.TabStop = true;
            this.lnkAddAttachments.Text = "Добавить вложения";
            this.lnkAddAttachments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkAddAttachments.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkAddAttachments_LinkClicked);
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.Location = new System.Drawing.Point(25, 164);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessage.Size = new System.Drawing.Size(375, 190);
            this.tbMessage.TabIndex = 4;
            // 
            // tbTo
            // 
            this.tbTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTo.Location = new System.Drawing.Point(65, 47);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(335, 20);
            this.tbTo.TabIndex = 3;
            // 
            // tbSubject
            // 
            this.tbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSubject.Location = new System.Drawing.Point(65, 20);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(335, 20);
            this.tbSubject.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кому:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тема:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Добавить вложения";
            // 
            // button2
            // 
            this.button2.Image = global::E_mail_client.Properties.Resources.delete_message;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(275, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Удалить вложения";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Текстовое";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(93, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "HTML / CSS";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(118, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 46);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип сообщения";
            // 
            // NewMessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.panelMessages);
            this.Controls.Add(this.panelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(440, 440);
            this.Name = "NewMessagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новое сообщение";
            this.panelButton.ResumeLayout(false);
            this.panelMessages.ResumeLayout(false);
            this.panelMessages.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button saveInDrafts;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.LinkLabel lnkAddAttachments;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}