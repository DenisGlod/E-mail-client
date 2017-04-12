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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Входящие");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Отправленные");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Черновики");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Спам");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Корзина");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("-------------------------------");
            this.tableLayoutPanelNameEmail = new System.Windows.Forms.TableLayoutPanel();
            this.labelNameEmail = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonDeleteMessage = new System.Windows.Forms.Button();
            this.buttonNewMessage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeViewFolder = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMessages = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelNameEmail.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelNameEmail
            // 
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
            this.tableLayoutPanelNameEmail.Size = new System.Drawing.Size(891, 40);
            this.tableLayoutPanelNameEmail.TabIndex = 0;
            // 
            // labelNameEmail
            // 
            this.labelNameEmail.AutoSize = true;
            this.labelNameEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNameEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameEmail.Location = new System.Drawing.Point(3, 3);
            this.labelNameEmail.Margin = new System.Windows.Forms.Padding(3);
            this.labelNameEmail.Name = "labelNameEmail";
            this.labelNameEmail.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelNameEmail.Size = new System.Drawing.Size(885, 34);
            this.labelNameEmail.TabIndex = 0;
            this.labelNameEmail.Text = "email address";
            this.labelNameEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonLogout);
            this.panelButton.Controls.Add(this.buttonDeleteMessage);
            this.panelButton.Controls.Add(this.buttonNewMessage);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 383);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(891, 46);
            this.panelButton.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.Location = new System.Drawing.Point(772, 11);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(107, 23);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Завершить сеанс";
            this.buttonLogout.UseVisualStyleBackColor = true;
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 343);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Папки";
            // 
            // treeViewFolder
            // 
            this.treeViewFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFolder.Location = new System.Drawing.Point(3, 16);
            this.treeViewFolder.Name = "treeViewFolder";
            treeNode1.Name = "inbox";
            treeNode1.Text = "Входящие";
            treeNode2.Name = "sent";
            treeNode2.Text = "Отправленные";
            treeNode3.Name = "draft";
            treeNode3.Text = "Черновики";
            treeNode4.Name = "junk";
            treeNode4.Text = "Спам";
            treeNode5.Name = "trash";
            treeNode5.Text = "Корзина";
            treeNode6.Name = "end";
            treeNode6.Text = "-------------------------------";
            this.treeViewFolder.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeViewFolder.Size = new System.Drawing.Size(194, 324);
            this.treeViewFolder.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(691, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 343);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Просмотр";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 40);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 343);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(688, 40);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 343);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewMessages);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(203, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 343);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Письма";
            // 
            // dataGridViewMessages
            // 
            this.dataGridViewMessages.AllowUserToAddRows = false;
            this.dataGridViewMessages.AllowUserToDeleteRows = false;
            this.dataGridViewMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMessages.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewMessages.MultiSelect = false;
            this.dataGridViewMessages.Name = "dataGridViewMessages";
            this.dataGridViewMessages.ReadOnly = true;
            this.dataGridViewMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMessages.Size = new System.Drawing.Size(479, 324);
            this.dataGridViewMessages.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // EMailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 429);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.tableLayoutPanelNameEmail);
            this.Name = "EMailClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-mail client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            this.tableLayoutPanelNameEmail.ResumeLayout(false);
            this.tableLayoutPanelNameEmail.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNameEmail;
        private System.Windows.Forms.Label labelNameEmail;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonDeleteMessage;
        private System.Windows.Forms.Button buttonNewMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeViewFolder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}