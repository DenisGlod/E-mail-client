namespace E_mail_client
{
    partial class EMailClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMailClient));
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonDeleteMessage = new System.Windows.Forms.Button();
            this.buttonNewMessage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeViewFolder = new System.Windows.Forms.TreeView();
            this.panelFolders = new System.Windows.Forms.Panel();
            this.linkLabelArchive = new System.Windows.Forms.LinkLabel();
            this.linkLabelAll = new System.Windows.Forms.LinkLabel();
            this.linkLabelTrash = new System.Windows.Forms.LinkLabel();
            this.linkLabelJunk = new System.Windows.Forms.LinkLabel();
            this.linkLabelFlagged = new System.Windows.Forms.LinkLabel();
            this.linkLabelImportant = new System.Windows.Forms.LinkLabel();
            this.linkLabelDrafts = new System.Windows.Forms.LinkLabel();
            this.linkLabelSent = new System.Windows.Forms.LinkLabel();
            this.linkLabelInbox = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMessages = new System.Windows.Forms.DataGridView();
            this.DateMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Theme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelNameEmail = new System.Windows.Forms.TableLayoutPanel();
            this.labelNameEmail = new System.Windows.Forms.Label();
            this.panelButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelFolders.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).BeginInit();
            this.tableLayoutPanelNameEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonDeleteMessage);
            this.panelButton.Controls.Add(this.buttonNewMessage);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 447);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(882, 46);
            this.panelButton.TabIndex = 1;
            // 
            // buttonDeleteMessage
            // 
            this.buttonDeleteMessage.Location = new System.Drawing.Point(130, 11);
            this.buttonDeleteMessage.Name = "buttonDeleteMessage";
            this.buttonDeleteMessage.Size = new System.Drawing.Size(131, 23);
            this.buttonDeleteMessage.TabIndex = 1;
            this.buttonDeleteMessage.Text = "Удалить сообщение";
            this.buttonDeleteMessage.UseVisualStyleBackColor = true;
            // 
            // buttonNewMessage
            // 
            this.buttonNewMessage.Location = new System.Drawing.Point(12, 11);
            this.buttonNewMessage.Name = "buttonNewMessage";
            this.buttonNewMessage.Size = new System.Drawing.Size(112, 23);
            this.buttonNewMessage.TabIndex = 0;
            this.buttonNewMessage.Text = "Новое сообщение";
            this.buttonNewMessage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeViewFolder);
            this.groupBox1.Controls.Add(this.panelFolders);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 407);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Папки";
            // 
            // treeViewFolder
            // 
            this.treeViewFolder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.treeViewFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.treeViewFolder.Location = new System.Drawing.Point(3, 269);
            this.treeViewFolder.Name = "treeViewFolder";
            this.treeViewFolder.Size = new System.Drawing.Size(194, 135);
            this.treeViewFolder.TabIndex = 9;
            // 
            // panelFolders
            // 
            this.panelFolders.Controls.Add(this.linkLabelArchive);
            this.panelFolders.Controls.Add(this.linkLabelAll);
            this.panelFolders.Controls.Add(this.linkLabelTrash);
            this.panelFolders.Controls.Add(this.linkLabelJunk);
            this.panelFolders.Controls.Add(this.linkLabelFlagged);
            this.panelFolders.Controls.Add(this.linkLabelImportant);
            this.panelFolders.Controls.Add(this.linkLabelDrafts);
            this.panelFolders.Controls.Add(this.linkLabelSent);
            this.panelFolders.Controls.Add(this.linkLabelInbox);
            this.panelFolders.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFolders.Location = new System.Drawing.Point(3, 19);
            this.panelFolders.Name = "panelFolders";
            this.panelFolders.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panelFolders.Size = new System.Drawing.Size(194, 250);
            this.panelFolders.TabIndex = 8;
            // 
            // linkLabelArchive
            // 
            this.linkLabelArchive.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelArchive.Image = global::E_mail_client.Properties.Resources.archive;
            this.linkLabelArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelArchive.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelArchive.Location = new System.Drawing.Point(8, 216);
            this.linkLabelArchive.Name = "linkLabelArchive";
            this.linkLabelArchive.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabelArchive.Size = new System.Drawing.Size(186, 27);
            this.linkLabelArchive.TabIndex = 8;
            this.linkLabelArchive.TabStop = true;
            this.linkLabelArchive.Text = "Архив";
            this.linkLabelArchive.Visible = false;
            // 
            // linkLabelAll
            // 
            this.linkLabelAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelAll.Image = global::E_mail_client.Properties.Resources.mails;
            this.linkLabelAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelAll.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelAll.Location = new System.Drawing.Point(8, 189);
            this.linkLabelAll.Name = "linkLabelAll";
            this.linkLabelAll.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabelAll.Size = new System.Drawing.Size(186, 27);
            this.linkLabelAll.TabIndex = 7;
            this.linkLabelAll.TabStop = true;
            this.linkLabelAll.Text = "Вся почта";
            this.linkLabelAll.Visible = false;
            this.linkLabelAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // linkLabelTrash
            // 
            this.linkLabelTrash.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelTrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelTrash.Image = global::E_mail_client.Properties.Resources.empty_trash;
            this.linkLabelTrash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelTrash.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelTrash.Location = new System.Drawing.Point(8, 162);
            this.linkLabelTrash.Name = "linkLabelTrash";
            this.linkLabelTrash.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabelTrash.Size = new System.Drawing.Size(186, 27);
            this.linkLabelTrash.TabIndex = 6;
            this.linkLabelTrash.TabStop = true;
            this.linkLabelTrash.Text = "Корзина";
            this.linkLabelTrash.Visible = false;
            this.linkLabelTrash.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabelJunk
            // 
            this.linkLabelJunk.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelJunk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelJunk.Image = global::E_mail_client.Properties.Resources.junk;
            this.linkLabelJunk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelJunk.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelJunk.Location = new System.Drawing.Point(8, 135);
            this.linkLabelJunk.Name = "linkLabelJunk";
            this.linkLabelJunk.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabelJunk.Size = new System.Drawing.Size(186, 27);
            this.linkLabelJunk.TabIndex = 5;
            this.linkLabelJunk.TabStop = true;
            this.linkLabelJunk.Text = "Спам";
            this.linkLabelJunk.Visible = false;
            this.linkLabelJunk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabelFlagged
            // 
            this.linkLabelFlagged.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelFlagged.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelFlagged.Image = global::E_mail_client.Properties.Resources.flag;
            this.linkLabelFlagged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelFlagged.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelFlagged.Location = new System.Drawing.Point(8, 108);
            this.linkLabelFlagged.Name = "linkLabelFlagged";
            this.linkLabelFlagged.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabelFlagged.Size = new System.Drawing.Size(186, 27);
            this.linkLabelFlagged.TabIndex = 4;
            this.linkLabelFlagged.TabStop = true;
            this.linkLabelFlagged.Text = "Помеченные";
            this.linkLabelFlagged.Visible = false;
            this.linkLabelFlagged.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabelImportant
            // 
            this.linkLabelImportant.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelImportant.Image = global::E_mail_client.Properties.Resources.important;
            this.linkLabelImportant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelImportant.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelImportant.Location = new System.Drawing.Point(8, 81);
            this.linkLabelImportant.Name = "linkLabelImportant";
            this.linkLabelImportant.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabelImportant.Size = new System.Drawing.Size(186, 27);
            this.linkLabelImportant.TabIndex = 3;
            this.linkLabelImportant.TabStop = true;
            this.linkLabelImportant.Text = "Важные";
            this.linkLabelImportant.Visible = false;
            this.linkLabelImportant.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabelDrafts
            // 
            this.linkLabelDrafts.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelDrafts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelDrafts.Image = global::E_mail_client.Properties.Resources.pencil;
            this.linkLabelDrafts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelDrafts.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelDrafts.Location = new System.Drawing.Point(8, 54);
            this.linkLabelDrafts.Name = "linkLabelDrafts";
            this.linkLabelDrafts.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabelDrafts.Size = new System.Drawing.Size(186, 27);
            this.linkLabelDrafts.TabIndex = 2;
            this.linkLabelDrafts.TabStop = true;
            this.linkLabelDrafts.Text = "Черновики";
            this.linkLabelDrafts.Visible = false;
            this.linkLabelDrafts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabelSent
            // 
            this.linkLabelSent.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelSent.Image = global::E_mail_client.Properties.Resources.paper_plane;
            this.linkLabelSent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelSent.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelSent.Location = new System.Drawing.Point(8, 27);
            this.linkLabelSent.Name = "linkLabelSent";
            this.linkLabelSent.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabelSent.Size = new System.Drawing.Size(186, 27);
            this.linkLabelSent.TabIndex = 1;
            this.linkLabelSent.TabStop = true;
            this.linkLabelSent.Text = "Отправленные";
            this.linkLabelSent.Visible = false;
            this.linkLabelSent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabelInbox
            // 
            this.linkLabelInbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelInbox.Image = global::E_mail_client.Properties.Resources.inbox;
            this.linkLabelInbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelInbox.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelInbox.Location = new System.Drawing.Point(8, 0);
            this.linkLabelInbox.Name = "linkLabelInbox";
            this.linkLabelInbox.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabelInbox.Size = new System.Drawing.Size(186, 27);
            this.linkLabelInbox.TabIndex = 0;
            this.linkLabelInbox.TabStop = true;
            this.linkLabelInbox.Text = "Входящие";
            this.linkLabelInbox.Visible = false;
            this.linkLabelInbox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(619, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 407);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Просмотр";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 40);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 407);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(616, 40);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 407);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewMessages);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(203, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 407);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Письма";
            // 
            // dataGridViewMessages
            // 
            this.dataGridViewMessages.AllowUserToAddRows = false;
            this.dataGridViewMessages.AllowUserToDeleteRows = false;
            this.dataGridViewMessages.AllowUserToResizeRows = false;
            this.dataGridViewMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMessages.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateMessage,
            this.Theme,
            this.Status});
            this.dataGridViewMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMessages.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewMessages.MultiSelect = false;
            this.dataGridViewMessages.Name = "dataGridViewMessages";
            this.dataGridViewMessages.ReadOnly = true;
            this.dataGridViewMessages.RowHeadersVisible = false;
            this.dataGridViewMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMessages.Size = new System.Drawing.Size(407, 385);
            this.dataGridViewMessages.TabIndex = 0;
            // 
            // DateMessage
            // 
            this.DateMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DateMessage.HeaderText = "Дата";
            this.DateMessage.Name = "DateMessage";
            this.DateMessage.ReadOnly = true;
            this.DateMessage.Width = 150;
            // 
            // Theme
            // 
            this.Theme.HeaderText = "Тема";
            this.Theme.Name = "Theme";
            this.Theme.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // tableLayoutPanelNameEmail
            // 
            this.tableLayoutPanelNameEmail.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelNameEmail.ColumnCount = 1;
            this.tableLayoutPanelNameEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNameEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNameEmail.Controls.Add(this.labelNameEmail, 0, 0);
            this.tableLayoutPanelNameEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelNameEmail.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelNameEmail.Name = "tableLayoutPanelNameEmail";
            this.tableLayoutPanelNameEmail.RowCount = 1;
            this.tableLayoutPanelNameEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNameEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelNameEmail.Size = new System.Drawing.Size(882, 40);
            this.tableLayoutPanelNameEmail.TabIndex = 0;
            // 
            // labelNameEmail
            // 
            this.labelNameEmail.AutoSize = true;
            this.labelNameEmail.BackColor = System.Drawing.SystemColors.Window;
            this.labelNameEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNameEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameEmail.ForeColor = System.Drawing.Color.Green;
            this.labelNameEmail.Location = new System.Drawing.Point(3, 3);
            this.labelNameEmail.Margin = new System.Windows.Forms.Padding(3);
            this.labelNameEmail.Name = "labelNameEmail";
            this.labelNameEmail.Size = new System.Drawing.Size(876, 34);
            this.labelNameEmail.TabIndex = 0;
            this.labelNameEmail.Text = "email address";
            this.labelNameEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EMailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.tableLayoutPanelNameEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EMailClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-mail Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            this.panelButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panelFolders.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).EndInit();
            this.tableLayoutPanelNameEmail.ResumeLayout(false);
            this.tableLayoutPanelNameEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonDeleteMessage;
        private System.Windows.Forms.Button buttonNewMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelFolders;
        private System.Windows.Forms.LinkLabel linkLabelArchive;
        private System.Windows.Forms.LinkLabel linkLabelAll;
        private System.Windows.Forms.LinkLabel linkLabelTrash;
        private System.Windows.Forms.LinkLabel linkLabelJunk;
        private System.Windows.Forms.LinkLabel linkLabelFlagged;
        private System.Windows.Forms.LinkLabel linkLabelImportant;
        private System.Windows.Forms.LinkLabel linkLabelDrafts;
        private System.Windows.Forms.LinkLabel linkLabelSent;
        private System.Windows.Forms.LinkLabel linkLabelInbox;
        private System.Windows.Forms.TreeView treeViewFolder;
        private System.Windows.Forms.DataGridView dataGridViewMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNameEmail;
        private System.Windows.Forms.Label labelNameEmail;
    }
}