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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelButton.SuspendLayout();
            this.panelMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.saveInDrafts);
            this.panelButton.Controls.Add(this.send);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 333);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(411, 47);
            this.panelButton.TabIndex = 0;
            // 
            // saveInDrafts
            // 
            this.saveInDrafts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveInDrafts.Image = global::E_mail_client.Properties.Resources.pencil;
            this.saveInDrafts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveInDrafts.Location = new System.Drawing.Point(236, 12);
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
            this.panelMessages.Controls.Add(this.lnkAddAttachments);
            this.panelMessages.Controls.Add(this.textBox3);
            this.panelMessages.Controls.Add(this.textBox2);
            this.panelMessages.Controls.Add(this.textBox1);
            this.panelMessages.Controls.Add(this.label2);
            this.panelMessages.Controls.Add(this.label1);
            this.panelMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessages.Location = new System.Drawing.Point(0, 0);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(411, 333);
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
            this.lnkAddAttachments.Size = new System.Drawing.Size(362, 25);
            this.lnkAddAttachments.TabIndex = 5;
            this.lnkAddAttachments.TabStop = true;
            this.lnkAddAttachments.Text = "Добавить вложения";
            this.lnkAddAttachments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkAddAttachments.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkAddAttachments_LinkClicked);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(25, 111);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(362, 222);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(65, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(322, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(65, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 20);
            this.textBox1.TabIndex = 2;
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
            // NewMessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 380);
            this.Controls.Add(this.panelMessages);
            this.Controls.Add(this.panelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewMessagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новое сообщение";
            this.panelButton.ResumeLayout(false);
            this.panelMessages.ResumeLayout(false);
            this.panelMessages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button saveInDrafts;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.LinkLabel lnkAddAttachments;
    }
}