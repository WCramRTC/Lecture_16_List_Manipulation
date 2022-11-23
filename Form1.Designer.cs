namespace Lecture_16_List_Manipulation
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
            this.lbOG = new System.Windows.Forms.ListBox();
            this.lbCurrent = new System.Windows.Forms.ListBox();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveValue = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.cbPhones = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbOG
            // 
            this.lbOG.FormattingEnabled = true;
            this.lbOG.ItemHeight = 24;
            this.lbOG.Location = new System.Drawing.Point(49, 47);
            this.lbOG.Name = "lbOG";
            this.lbOG.Size = new System.Drawing.Size(376, 580);
            this.lbOG.TabIndex = 0;
            // 
            // lbCurrent
            // 
            this.lbCurrent.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbCurrent.FormattingEnabled = true;
            this.lbCurrent.ItemHeight = 24;
            this.lbCurrent.Location = new System.Drawing.Point(696, 143);
            this.lbCurrent.MultiColumn = true;
            this.lbCurrent.Name = "lbCurrent";
            this.lbCurrent.Size = new System.Drawing.Size(376, 484);
            this.lbCurrent.TabIndex = 1;
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Location = new System.Drawing.Point(481, 114);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(161, 51);
            this.btnRemoveAt.TabIndex = 2;
            this.btnRemoveAt.Text = "Remove At";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(445, 475);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(221, 152);
            this.rtbDisplay.TabIndex = 3;
            this.rtbDisplay.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(806, 652);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 652);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "Original";
            // 
            // btnRemoveValue
            // 
            this.btnRemoveValue.Location = new System.Drawing.Point(491, 205);
            this.btnRemoveValue.Name = "btnRemoveValue";
            this.btnRemoveValue.Size = new System.Drawing.Size(136, 60);
            this.btnRemoveValue.TabIndex = 6;
            this.btnRemoveValue.Text = "Remove Value";
            this.btnRemoveValue.UseVisualStyleBackColor = true;
            this.btnRemoveValue.Click += new System.EventHandler(this.btnRemoveValue_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(481, 397);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(142, 42);
            this.btnAddContact.TabIndex = 7;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // cbPhones
            // 
            this.cbPhones.FormattingEnabled = true;
            this.cbPhones.Location = new System.Drawing.Point(738, 63);
            this.cbPhones.Name = "cbPhones";
            this.cbPhones.Size = new System.Drawing.Size(276, 32);
            this.cbPhones.TabIndex = 8;
            this.cbPhones.SelectedIndexChanged += new System.EventHandler(this.cbPhones_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 697);
            this.Controls.Add(this.cbPhones);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.btnRemoveValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.lbCurrent);
            this.Controls.Add(this.lbOG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOG;
        private System.Windows.Forms.ListBox lbCurrent;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveValue;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.ComboBox cbPhones;
    }
}

