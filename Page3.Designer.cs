namespace HelloWorld
{
    partial class Page3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt2Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt3Label = new System.Windows.Forms.Label();
            this.ctlSecondName = new HelloWorld.ClearableTextBox();
            this.ctrlFirstName = new HelloWorld.ClearableTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt2Label
            // 
            this.txt2Label.AutoSize = true;
            this.txt2Label.Location = new System.Drawing.Point(120, 302);
            this.txt2Label.Name = "txt2Label";
            this.txt2Label.Size = new System.Drawing.Size(0, 16);
            this.txt2Label.TabIndex = 3;
            this.txt2Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text 2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txt3Label
            // 
            this.txt3Label.AutoSize = true;
            this.txt3Label.Location = new System.Drawing.Point(120, 362);
            this.txt3Label.Name = "txt3Label";
            this.txt3Label.Size = new System.Drawing.Size(0, 16);
            this.txt3Label.TabIndex = 5;
            // 
            // ctlSecondName
            // 
            this.ctlSecondName.Location = new System.Drawing.Point(26, 108);
            this.ctlSecondName.MinimumSize = new System.Drawing.Size(85, 53);
            this.ctlSecondName.Name = "ctlSecondName";
            this.ctlSecondName.Size = new System.Drawing.Size(474, 80);
            this.ctlSecondName.TabIndex = 1;
            this.ctlSecondName.TextChanged += new System.EventHandler(this.ctlSecondName_TextChanged);
            // 
            // ctrlFirstName
            // 
            this.ctrlFirstName.Location = new System.Drawing.Point(15, 15);
            this.ctrlFirstName.MinimumSize = new System.Drawing.Size(85, 53);
            this.ctrlFirstName.Name = "ctrlFirstName";
            this.ctrlFirstName.Size = new System.Drawing.Size(486, 84);
            this.ctrlFirstName.TabIndex = 0;
            this.ctrlFirstName.TextChanged += new System.EventHandler(this.ctrlFirstName_TextChanged);
            // 
            // Page3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.txt3Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt2Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlSecondName);
            this.Controls.Add(this.ctrlFirstName);
            this.Name = "Page3";
            this.Text = "Page3";
            this.Load += new System.EventHandler(this.Page3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClearableTextBox ctrlFirstName;
        private ClearableTextBox ctlSecondName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt2Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt3Label;
    }
}