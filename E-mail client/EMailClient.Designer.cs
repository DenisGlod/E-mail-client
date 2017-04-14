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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.treeViewFolder = new System.Windows.Forms.TreeView();
            this.dataGridViewMessages = new System.Windows.Forms.DataGridView();
            this.DateMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Theme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanelNameEmail = new System.Windows.Forms.TableLayoutPanel();
            this.labelNameEmail = new System.Windows.Forms.Label();
            this.panelButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).BeginInit();
            this.tableLayoutPanelNameEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonDeleteMessage);
            this.panelButton.Controls.Add(this.buttonNewMessage);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 598);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1289, 46);
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
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 558);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Папки";
            // 
            // groupBox3
            // 
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(852, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 558);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Просмотр";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 40);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 558);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(849, 40);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 558);
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
            this.groupBox2.Size = new System.Drawing.Size(646, 558);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Письма";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel9);
            this.panel1.Controls.Add(this.linkLabel8);
            this.panel1.Controls.Add(this.linkLabel7);
            this.panel1.Controls.Add(this.linkLabel6);
            this.panel1.Controls.Add(this.linkLabel5);
            this.panel1.Controls.Add(this.linkLabel4);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(194, 250);
            this.panel1.TabIndex = 8;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel2.Image = global::E_mail_client.Properties.Resources.paper_plane;
            this.linkLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel2.Location = new System.Drawing.Point(8, 27);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabel2.Size = new System.Drawing.Size(186, 27);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Отправленные";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel3.Image = global::E_mail_client.Properties.Resources.pencil;
            this.linkLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel3.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel3.Location = new System.Drawing.Point(8, 54);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabel3.Size = new System.Drawing.Size(186, 27);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Черновики";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel4.Image = global::E_mail_client.Properties.Resources.important;
            this.linkLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel4.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel4.Location = new System.Drawing.Point(8, 81);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabel4.Size = new System.Drawing.Size(186, 27);
            this.linkLabel4.TabIndex = 3;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Важные";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel5.Image = global::E_mail_client.Properties.Resources.flag;
            this.linkLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel5.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel5.Location = new System.Drawing.Point(8, 108);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabel5.Size = new System.Drawing.Size(186, 27);
            this.linkLabel5.TabIndex = 4;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Помеченные";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel6.Image = global::E_mail_client.Properties.Resources.junk;
            this.linkLabel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel6.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel6.Location = new System.Drawing.Point(8, 135);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabel6.Size = new System.Drawing.Size(186, 27);
            this.linkLabel6.TabIndex = 5;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Спам";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel7.Image = global::E_mail_client.Properties.Resources.empty_trash;
            this.linkLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel7.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel7.Location = new System.Drawing.Point(8, 162);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabel7.Size = new System.Drawing.Size(186, 27);
            this.linkLabel7.TabIndex = 6;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Корзина";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabel8
            // 
            this.linkLabel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel8.Image = global::E_mail_client.Properties.Resources.mails;
            this.linkLabel8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel8.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel8.Location = new System.Drawing.Point(8, 189);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabel8.Size = new System.Drawing.Size(186, 27);
            this.linkLabel8.TabIndex = 7;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Вся почта";
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // linkLabel9
            // 
            this.linkLabel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel9.Image = global::E_mail_client.Properties.Resources.archive;
            this.linkLabel9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel9.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel9.Location = new System.Drawing.Point(8, 216);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabel9.Size = new System.Drawing.Size(186, 27);
            this.linkLabel9.TabIndex = 8;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "Архив";
            // 
            // treeViewFolder
            // 
            this.treeViewFolder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.treeViewFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.treeViewFolder.Location = new System.Drawing.Point(3, 269);
            this.treeViewFolder.Name = "treeViewFolder";
            this.treeViewFolder.Size = new System.Drawing.Size(194, 286);
            this.treeViewFolder.TabIndex = 9;
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
            this.dataGridViewMessages.Size = new System.Drawing.Size(640, 536);
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
            // linkLabel1
            // 
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Image = global::E_mail_client.Properties.Resources.inbox;
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel1.Location = new System.Drawing.Point(8, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.linkLabel1.Size = new System.Drawing.Size(186, 27);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Входящие";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.tableLayoutPanelNameEmail.Size = new System.Drawing.Size(1289, 40);
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
            this.labelNameEmail.Size = new System.Drawing.Size(1283, 34);
            this.labelNameEmail.TabIndex = 0;
            this.labelNameEmail.Text = "email address";
            this.labelNameEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EMailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 644);
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
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TreeView treeViewFolder;
        private System.Windows.Forms.DataGridView dataGridViewMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNameEmail;
        private System.Windows.Forms.Label labelNameEmail;
    }
}