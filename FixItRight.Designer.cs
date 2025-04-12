namespace WindowsFormsApp8
{
    partial class FixItRight
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
            this.txbSubject = new System.Windows.Forms.RichTextBox();
            this.txbName = new System.Windows.Forms.RichTextBox();
            this.txbContactNumber = new System.Windows.Forms.RichTextBox();
            this.txbAddress = new System.Windows.Forms.RichTextBox();
            this.txbDescription = new System.Windows.Forms.RichTextBox();
            this.txbHazards = new System.Windows.Forms.RichTextBox();
            this.SubmitButton_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbSubject
            // 
            this.txbSubject.Location = new System.Drawing.Point(451, 33);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(270, 96);
            this.txbSubject.TabIndex = 0;
            this.txbSubject.Text = "         \n           \n                           Subject";
            this.txbSubject.Click += new System.EventHandler(this.txbSubject_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(354, 162);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(199, 103);
            this.txbName.TabIndex = 1;
            this.txbName.Text = "\n\n\tName";
            this.txbName.Click += new System.EventHandler(this.txbName_Click);
            // 
            // txbContactNumber
            // 
            this.txbContactNumber.Location = new System.Drawing.Point(609, 162);
            this.txbContactNumber.Name = "txbContactNumber";
            this.txbContactNumber.Size = new System.Drawing.Size(205, 103);
            this.txbContactNumber.TabIndex = 2;
            this.txbContactNumber.Text = "\n\n        Contact Number";
            this.txbContactNumber.Click += new System.EventHandler(this.txbContactNumber_Click);
            this.txbContactNumber.TextChanged += new System.EventHandler(this.txbContactNumber_TextChanged);
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(442, 293);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(270, 96);
            this.txbAddress.TabIndex = 3;
            this.txbAddress.Text = "         \n           \n                        Address";
            this.txbAddress.Click += new System.EventHandler(this.txbAddress_Click);
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(442, 428);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(270, 96);
            this.txbDescription.TabIndex = 4;
            this.txbDescription.Text = "         \n           \n        \t     Description";
            this.txbDescription.Click += new System.EventHandler(this.txbDescription_Click);
            // 
            // txbHazards
            // 
            this.txbHazards.Location = new System.Drawing.Point(451, 562);
            this.txbHazards.Name = "txbHazards";
            this.txbHazards.Size = new System.Drawing.Size(270, 96);
            this.txbHazards.TabIndex = 5;
            this.txbHazards.Text = "         \n           \n                         Hazards";
            this.txbHazards.Click += new System.EventHandler(this.txbHazards_Click);
            // 
            // SubmitButton_Click
            // 
            this.SubmitButton_Click.Location = new System.Drawing.Point(481, 686);
            this.SubmitButton_Click.Name = "SubmitButton_Click";
            this.SubmitButton_Click.Size = new System.Drawing.Size(217, 95);
            this.SubmitButton_Click.TabIndex = 6;
            this.SubmitButton_Click.Text = "Submit";
            this.SubmitButton_Click.UseVisualStyleBackColor = true;
            // 
            // FixItRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 842);
            this.Controls.Add(this.SubmitButton_Click);
            this.Controls.Add(this.txbHazards);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbContactNumber);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbSubject);
            this.Name = "FixItRight";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txbSubject;
        private System.Windows.Forms.RichTextBox txbName;
        private System.Windows.Forms.RichTextBox txbContactNumber;
        private System.Windows.Forms.RichTextBox txbAddress;
        private System.Windows.Forms.RichTextBox txbDescription;
        private System.Windows.Forms.RichTextBox txbHazards;
        private System.Windows.Forms.Button SubmitButton_Click;
    }
}

