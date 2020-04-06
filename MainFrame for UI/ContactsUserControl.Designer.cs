namespace MainFrame_for_UI
{
    partial class ContactsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsUserControl));
            this.ContactsHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContactsHeader
            // 
            this.ContactsHeader.AutoSize = true;
            this.ContactsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(218)))), ((int)(((byte)(239)))));
            this.ContactsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContactsHeader.Font = new System.Drawing.Font("Century Gothic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ContactsHeader.Location = new System.Drawing.Point(0, 0);
            this.ContactsHeader.Name = "ContactsHeader";
            this.ContactsHeader.Size = new System.Drawing.Size(437, 53);
            this.ContactsHeader.TabIndex = 3;
            this.ContactsHeader.Text = "CONTACTS SECTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email: Nameofshop@gmail.com\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contact Number: 09163378237";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(734, 62);
            this.label3.TabIndex = 6;
            this.label3.Text = "Feel free to contact us if you have any inquiries to our store,\r\nand questions an" +
    "d suggestions regarding to our events.";
            // 
            // ContactsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContactsHeader);
            this.Name = "ContactsUserControl";
            this.Size = new System.Drawing.Size(1051, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContactsHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
