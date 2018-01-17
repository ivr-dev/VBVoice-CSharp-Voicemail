namespace VoicemailApp
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.removeDelMessagesBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.hideLinestatusBtn = new System.Windows.Forms.Button();
            this.showLineStatusBtn = new System.Windows.Forms.Button();
            this.hideDesignBtn = new System.Windows.Forms.Button();
            this.showDesignBtn = new System.Windows.Forms.Button();
            this.initializeMBBtn = new System.Windows.Forms.Button();
            this.deleteMBBtn = new System.Windows.Forms.Button();
            this.mbGrid = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailboxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriberInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subscriberDataSet = new VoicemailApp.SubscriberDataSet();
            this.subscriber_InformationTableAdapter = new VoicemailApp.SubscriberDataSetTableAdapters.Subscriber_InformationTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mbGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(7, 40);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(74, 24);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(7, 70);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(74, 24);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.stopBtn);
            this.panel1.Location = new System.Drawing.Point(32, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 110);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "System";
            // 
            // removeDelMessagesBtn
            // 
            this.removeDelMessagesBtn.Location = new System.Drawing.Point(139, 39);
            this.removeDelMessagesBtn.Name = "removeDelMessagesBtn";
            this.removeDelMessagesBtn.Size = new System.Drawing.Size(114, 85);
            this.removeDelMessagesBtn.TabIndex = 3;
            this.removeDelMessagesBtn.Text = "Remove Deleted Messages";
            this.removeDelMessagesBtn.UseVisualStyleBackColor = true;
            this.removeDelMessagesBtn.Click += new System.EventHandler(this.removeDelMessagesBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.hideLinestatusBtn);
            this.panel2.Controls.Add(this.showLineStatusBtn);
            this.panel2.Controls.Add(this.hideDesignBtn);
            this.panel2.Controls.Add(this.showDesignBtn);
            this.panel2.Location = new System.Drawing.Point(445, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 135);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Logs";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(155, 102);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(74, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Channel 4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(155, 79);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Channel 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(155, 56);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(74, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Channel 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(155, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Channel 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // hideLinestatusBtn
            // 
            this.hideLinestatusBtn.Location = new System.Drawing.Point(18, 99);
            this.hideLinestatusBtn.Name = "hideLinestatusBtn";
            this.hideLinestatusBtn.Size = new System.Drawing.Size(111, 20);
            this.hideLinestatusBtn.TabIndex = 3;
            this.hideLinestatusBtn.Text = "Hide Linestatus";
            this.hideLinestatusBtn.UseVisualStyleBackColor = true;
            this.hideLinestatusBtn.Click += new System.EventHandler(this.hideLinestatusBtn_Click);
            // 
            // showLineStatusBtn
            // 
            this.showLineStatusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.showLineStatusBtn.Location = new System.Drawing.Point(18, 72);
            this.showLineStatusBtn.Name = "showLineStatusBtn";
            this.showLineStatusBtn.Size = new System.Drawing.Size(111, 21);
            this.showLineStatusBtn.TabIndex = 2;
            this.showLineStatusBtn.Text = "Show Linestatus";
            this.showLineStatusBtn.UseVisualStyleBackColor = true;
            this.showLineStatusBtn.Click += new System.EventHandler(this.showLineStatusBtn_Click);
            // 
            // hideDesignBtn
            // 
            this.hideDesignBtn.Location = new System.Drawing.Point(18, 45);
            this.hideDesignBtn.Name = "hideDesignBtn";
            this.hideDesignBtn.Size = new System.Drawing.Size(111, 21);
            this.hideDesignBtn.TabIndex = 1;
            this.hideDesignBtn.Text = "Hide Design";
            this.hideDesignBtn.UseVisualStyleBackColor = true;
            this.hideDesignBtn.Click += new System.EventHandler(this.hideDesignBtn_Click);
            // 
            // showDesignBtn
            // 
            this.showDesignBtn.Location = new System.Drawing.Point(18, 14);
            this.showDesignBtn.Name = "showDesignBtn";
            this.showDesignBtn.Size = new System.Drawing.Size(111, 21);
            this.showDesignBtn.TabIndex = 0;
            this.showDesignBtn.Text = "Show Design";
            this.showDesignBtn.UseVisualStyleBackColor = true;
            this.showDesignBtn.Click += new System.EventHandler(this.showDesignBtn_Click);
            // 
            // initializeMBBtn
            // 
            this.initializeMBBtn.Location = new System.Drawing.Point(515, 243);
            this.initializeMBBtn.Name = "initializeMBBtn";
            this.initializeMBBtn.Size = new System.Drawing.Size(76, 48);
            this.initializeMBBtn.TabIndex = 6;
            this.initializeMBBtn.Text = "Initialize MailBox";
            this.initializeMBBtn.UseVisualStyleBackColor = true;
            this.initializeMBBtn.Click += new System.EventHandler(this.initializeMBBtn_Click);
            // 
            // deleteMBBtn
            // 
            this.deleteMBBtn.Location = new System.Drawing.Point(628, 243);
            this.deleteMBBtn.Name = "deleteMBBtn";
            this.deleteMBBtn.Size = new System.Drawing.Size(76, 48);
            this.deleteMBBtn.TabIndex = 7;
            this.deleteMBBtn.Text = "Delete MailBox";
            this.deleteMBBtn.UseVisualStyleBackColor = true;
            this.deleteMBBtn.Click += new System.EventHandler(this.deleteMBBtn_Click);
            // 
            // mbGrid
            // 
            this.mbGrid.AutoGenerateColumns = false;
            this.mbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mbGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.mailboxDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.extensionDataGridViewTextBoxColumn});
            this.mbGrid.DataSource = this.subscriberInformationBindingSource;
            this.mbGrid.Location = new System.Drawing.Point(23, 217);
            this.mbGrid.Name = "mbGrid";
            this.mbGrid.Size = new System.Drawing.Size(454, 98);
            this.mbGrid.TabIndex = 8;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // mailboxDataGridViewTextBoxColumn
            // 
            this.mailboxDataGridViewTextBoxColumn.DataPropertyName = "Mailbox";
            this.mailboxDataGridViewTextBoxColumn.HeaderText = "Mailbox";
            this.mailboxDataGridViewTextBoxColumn.Name = "mailboxDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // extensionDataGridViewTextBoxColumn
            // 
            this.extensionDataGridViewTextBoxColumn.DataPropertyName = "Extension";
            this.extensionDataGridViewTextBoxColumn.HeaderText = "Extension";
            this.extensionDataGridViewTextBoxColumn.Name = "extensionDataGridViewTextBoxColumn";
            // 
            // subscriberInformationBindingSource
            // 
            this.subscriberInformationBindingSource.DataMember = "Subscriber_Information";
            this.subscriberInformationBindingSource.DataSource = this.subscriberDataSet;
            // 
            // subscriberDataSet
            // 
            this.subscriberDataSet.DataSetName = "SubscriberDataSet";
            this.subscriberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subscriber_InformationTableAdapter
            // 
            this.subscriber_InformationTableAdapter.ClearBeforeFill = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 318);
            this.Controls.Add(this.mbGrid);
            this.Controls.Add(this.deleteMBBtn);
            this.Controls.Add(this.initializeMBBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.removeDelMessagesBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mbGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeDelMessagesBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button hideLinestatusBtn;
        private System.Windows.Forms.Button showLineStatusBtn;
        private System.Windows.Forms.Button hideDesignBtn;
        private System.Windows.Forms.Button showDesignBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button initializeMBBtn;
        private System.Windows.Forms.Button deleteMBBtn;
        private System.Windows.Forms.DataGridView mbGrid;
        private SubscriberDataSet subscriberDataSet;
        private System.Windows.Forms.BindingSource subscriberInformationBindingSource;
        private SubscriberDataSetTableAdapters.Subscriber_InformationTableAdapter subscriber_InformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailboxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionDataGridViewTextBoxColumn;
    }
}