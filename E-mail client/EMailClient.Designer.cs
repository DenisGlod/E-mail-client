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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMailClient));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeViewFolder = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelFolders = new System.Windows.Forms.Panel();
            this.lnkArchive = new System.Windows.Forms.LinkLabel();
            this.lnkAll = new System.Windows.Forms.LinkLabel();
            this.lnkTrash = new System.Windows.Forms.LinkLabel();
            this.lnkJunk = new System.Windows.Forms.LinkLabel();
            this.lnkFlagged = new System.Windows.Forms.LinkLabel();
            this.lnkImportant = new System.Windows.Forms.LinkLabel();
            this.lnkDrafts = new System.Windows.Forms.LinkLabel();
            this.lnkSent = new System.Windows.Forms.LinkLabel();
            this.lnkInbox = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonDeleteMessage = new System.Windows.Forms.Button();
            this.buttonNewMessage = new System.Windows.Forms.Button();
            this.tableLayoutPanelNameEmail = new System.Windows.Forms.TableLayoutPanel();
            this.labelNameEmail = new System.Windows.Forms.Label();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panelFolders.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.tableLayoutPanelNameEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeViewFolder);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panelFolders);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 364);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Папки";
            // 
            // treeViewFolder
            // 
            this.treeViewFolder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.treeViewFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewFolder.FullRowSelect = true;
            this.treeViewFolder.HideSelection = false;
            this.treeViewFolder.Location = new System.Drawing.Point(3, 293);
            this.treeViewFolder.Name = "treeViewFolder";
            this.treeViewFolder.Size = new System.Drawing.Size(194, 68);
            this.treeViewFolder.TabIndex = 9;
            this.treeViewFolder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFolder_AfterSelect);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 10);
            this.panel3.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 1);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 10);
            this.panel2.TabIndex = 10;
            // 
            // panelFolders
            // 
            this.panelFolders.Controls.Add(this.lnkArchive);
            this.panelFolders.Controls.Add(this.lnkAll);
            this.panelFolders.Controls.Add(this.lnkTrash);
            this.panelFolders.Controls.Add(this.lnkJunk);
            this.panelFolders.Controls.Add(this.lnkFlagged);
            this.panelFolders.Controls.Add(this.lnkImportant);
            this.panelFolders.Controls.Add(this.lnkDrafts);
            this.panelFolders.Controls.Add(this.lnkSent);
            this.panelFolders.Controls.Add(this.lnkInbox);
            this.panelFolders.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFolders.Location = new System.Drawing.Point(3, 25);
            this.panelFolders.Name = "panelFolders";
            this.panelFolders.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panelFolders.Size = new System.Drawing.Size(194, 247);
            this.panelFolders.TabIndex = 8;
            // 
            // lnkArchive
            // 
            this.lnkArchive.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkArchive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkArchive.Image = global::E_mail_client.Properties.Resources.archive;
            this.lnkArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkArchive.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkArchive.Location = new System.Drawing.Point(8, 216);
            this.lnkArchive.Name = "lnkArchive";
            this.lnkArchive.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkArchive.Size = new System.Drawing.Size(186, 27);
            this.lnkArchive.TabIndex = 8;
            this.lnkArchive.TabStop = true;
            this.lnkArchive.Text = "Архив";
            this.lnkArchive.Visible = false;
            this.lnkArchive.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkAll
            // 
            this.lnkAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkAll.Image = global::E_mail_client.Properties.Resources.mails;
            this.lnkAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkAll.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkAll.Location = new System.Drawing.Point(8, 189);
            this.lnkAll.Name = "lnkAll";
            this.lnkAll.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkAll.Size = new System.Drawing.Size(186, 27);
            this.lnkAll.TabIndex = 7;
            this.lnkAll.TabStop = true;
            this.lnkAll.Text = "Вся почта";
            this.lnkAll.Visible = false;
            this.lnkAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkTrash
            // 
            this.lnkTrash.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkTrash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkTrash.Image = global::E_mail_client.Properties.Resources.empty_trash;
            this.lnkTrash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkTrash.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkTrash.Location = new System.Drawing.Point(8, 162);
            this.lnkTrash.Name = "lnkTrash";
            this.lnkTrash.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkTrash.Size = new System.Drawing.Size(186, 27);
            this.lnkTrash.TabIndex = 6;
            this.lnkTrash.TabStop = true;
            this.lnkTrash.Text = "Корзина";
            this.lnkTrash.Visible = false;
            this.lnkTrash.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkJunk
            // 
            this.lnkJunk.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkJunk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkJunk.Image = global::E_mail_client.Properties.Resources.junk;
            this.lnkJunk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkJunk.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkJunk.Location = new System.Drawing.Point(8, 135);
            this.lnkJunk.Name = "lnkJunk";
            this.lnkJunk.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkJunk.Size = new System.Drawing.Size(186, 27);
            this.lnkJunk.TabIndex = 5;
            this.lnkJunk.TabStop = true;
            this.lnkJunk.Text = "Спам";
            this.lnkJunk.Visible = false;
            this.lnkJunk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkFlagged
            // 
            this.lnkFlagged.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkFlagged.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkFlagged.Image = global::E_mail_client.Properties.Resources.flag;
            this.lnkFlagged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkFlagged.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkFlagged.Location = new System.Drawing.Point(8, 108);
            this.lnkFlagged.Name = "lnkFlagged";
            this.lnkFlagged.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkFlagged.Size = new System.Drawing.Size(186, 27);
            this.lnkFlagged.TabIndex = 4;
            this.lnkFlagged.TabStop = true;
            this.lnkFlagged.Text = "Помеченные";
            this.lnkFlagged.Visible = false;
            this.lnkFlagged.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkImportant
            // 
            this.lnkImportant.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkImportant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkImportant.Image = global::E_mail_client.Properties.Resources.important;
            this.lnkImportant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkImportant.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkImportant.Location = new System.Drawing.Point(8, 81);
            this.lnkImportant.Name = "lnkImportant";
            this.lnkImportant.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkImportant.Size = new System.Drawing.Size(186, 27);
            this.lnkImportant.TabIndex = 3;
            this.lnkImportant.TabStop = true;
            this.lnkImportant.Text = "Важные";
            this.lnkImportant.Visible = false;
            this.lnkImportant.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkDrafts
            // 
            this.lnkDrafts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkDrafts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkDrafts.Image = global::E_mail_client.Properties.Resources.pencil;
            this.lnkDrafts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkDrafts.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkDrafts.Location = new System.Drawing.Point(8, 54);
            this.lnkDrafts.Name = "lnkDrafts";
            this.lnkDrafts.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkDrafts.Size = new System.Drawing.Size(186, 27);
            this.lnkDrafts.TabIndex = 2;
            this.lnkDrafts.TabStop = true;
            this.lnkDrafts.Text = "Черновики";
            this.lnkDrafts.Visible = false;
            this.lnkDrafts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkSent
            // 
            this.lnkSent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkSent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkSent.Image = global::E_mail_client.Properties.Resources.paper_plane;
            this.lnkSent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkSent.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkSent.Location = new System.Drawing.Point(8, 27);
            this.lnkSent.Name = "lnkSent";
            this.lnkSent.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkSent.Size = new System.Drawing.Size(186, 27);
            this.lnkSent.TabIndex = 1;
            this.lnkSent.TabStop = true;
            this.lnkSent.Text = "Отправленные";
            this.lnkSent.Visible = false;
            this.lnkSent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkInbox
            // 
            this.lnkInbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkInbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkInbox.Image = global::E_mail_client.Properties.Resources.inbox;
            this.lnkInbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkInbox.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkInbox.Location = new System.Drawing.Point(8, 0);
            this.lnkInbox.Name = "lnkInbox";
            this.lnkInbox.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkInbox.Size = new System.Drawing.Size(186, 27);
            this.lnkInbox.TabIndex = 0;
            this.lnkInbox.TabStop = true;
            this.lnkInbox.Text = "Входящие";
            this.lnkInbox.Visible = false;
            this.lnkInbox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(634, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 364);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Просмотр";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 40);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 364);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(631, 40);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 364);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMessages);
            this.groupBox2.Controls.Add(this.panelButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(203, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 364);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Письма";
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonDeleteMessage);
            this.panelButton.Controls.Add(this.buttonNewMessage);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelButton.Location = new System.Drawing.Point(3, 319);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(422, 42);
            this.panelButton.TabIndex = 2;
            // 
            // buttonDeleteMessage
            // 
            this.buttonDeleteMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonDeleteMessage.Location = new System.Drawing.Point(220, 10);
            this.buttonDeleteMessage.Name = "buttonDeleteMessage";
            this.buttonDeleteMessage.Size = new System.Drawing.Size(131, 23);
            this.buttonDeleteMessage.TabIndex = 1;
            this.buttonDeleteMessage.Text = "Удалить сообщение";
            this.buttonDeleteMessage.UseVisualStyleBackColor = true;
            // 
            // buttonNewMessage
            // 
            this.buttonNewMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonNewMessage.Location = new System.Drawing.Point(66, 10);
            this.buttonNewMessage.Name = "buttonNewMessage";
            this.buttonNewMessage.Size = new System.Drawing.Size(112, 23);
            this.buttonNewMessage.TabIndex = 0;
            this.buttonNewMessage.Text = "Новое сообщение";
            this.buttonNewMessage.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanelNameEmail.Size = new System.Drawing.Size(897, 40);
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
            this.labelNameEmail.Size = new System.Drawing.Size(891, 34);
            this.labelNameEmail.TabIndex = 0;
            this.labelNameEmail.Text = "email address";
            this.labelNameEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMessages
            // 
            this.dgvMessages.AllowUserToAddRows = false;
            this.dgvMessages.AllowUserToDeleteRows = false;
            this.dgvMessages.AllowUserToResizeRows = false;
            this.dgvMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMessages.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMessages.Location = new System.Drawing.Point(3, 19);
            this.dgvMessages.MultiSelect = false;
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            this.dgvMessages.RowHeadersVisible = false;
            this.dgvMessages.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMessages.Size = new System.Drawing.Size(422, 300);
            this.dgvMessages.TabIndex = 3;
            // 
            // EMailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanelNameEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EMailClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-mail Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            this.groupBox1.ResumeLayout(false);
            this.panelFolders.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.tableLayoutPanelNameEmail.ResumeLayout(false);
            this.tableLayoutPanelNameEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelFolders;
        private System.Windows.Forms.LinkLabel lnkArchive;
        private System.Windows.Forms.LinkLabel lnkAll;
        private System.Windows.Forms.LinkLabel lnkTrash;
        private System.Windows.Forms.LinkLabel lnkJunk;
        private System.Windows.Forms.LinkLabel lnkFlagged;
        private System.Windows.Forms.LinkLabel lnkImportant;
        private System.Windows.Forms.LinkLabel lnkDrafts;
        private System.Windows.Forms.LinkLabel lnkSent;
        private System.Windows.Forms.LinkLabel lnkInbox;
        private System.Windows.Forms.TreeView treeViewFolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNameEmail;
        private System.Windows.Forms.Label labelNameEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonDeleteMessage;
        private System.Windows.Forms.Button buttonNewMessage;
        private System.Windows.Forms.DataGridView dgvMessages;
    }
}