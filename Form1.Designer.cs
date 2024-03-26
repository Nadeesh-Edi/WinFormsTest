namespace HelloWorld
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
            this.btnClickMe = new System.Windows.Forms.Button();
            this.labelHelloWorld = new System.Windows.Forms.Label();
            this.nxtPageBtn = new System.Windows.Forms.Button();
            this.userControlFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClickMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClickMe.Location = new System.Drawing.Point(37, 32);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(136, 44);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = false;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // labelHelloWorld
            // 
            this.labelHelloWorld.AutoSize = true;
            this.labelHelloWorld.Location = new System.Drawing.Point(457, 46);
            this.labelHelloWorld.Name = "labelHelloWorld";
            this.labelHelloWorld.Size = new System.Drawing.Size(0, 16);
            this.labelHelloWorld.TabIndex = 1;
            this.labelHelloWorld.Click += new System.EventHandler(this.label1_Click);
            // 
            // nxtPageBtn
            // 
            this.nxtPageBtn.BackColor = System.Drawing.Color.Purple;
            this.nxtPageBtn.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxtPageBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nxtPageBtn.Location = new System.Drawing.Point(37, 280);
            this.nxtPageBtn.Name = "nxtPageBtn";
            this.nxtPageBtn.Size = new System.Drawing.Size(136, 40);
            this.nxtPageBtn.TabIndex = 2;
            this.nxtPageBtn.Text = "Go To NASA";
            this.nxtPageBtn.UseVisualStyleBackColor = false;
            this.nxtPageBtn.Click += new System.EventHandler(this.nxtPageBtn_Click);
            // 
            // userControlFormBtn
            // 
            this.userControlFormBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.userControlFormBtn.Location = new System.Drawing.Point(443, 31);
            this.userControlFormBtn.Name = "userControlFormBtn";
            this.userControlFormBtn.Size = new System.Drawing.Size(142, 44);
            this.userControlFormBtn.TabIndex = 3;
            this.userControlFormBtn.Text = "Open User Controls";
            this.userControlFormBtn.UseVisualStyleBackColor = false;
            this.userControlFormBtn.Click += new System.EventHandler(this.userControlFormBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.userControlFormBtn);
            this.Controls.Add(this.nxtPageBtn);
            this.Controls.Add(this.labelHelloWorld);
            this.Controls.Add(this.btnClickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label labelHelloWorld;
        private System.Windows.Forms.Button nxtPageBtn;
        private System.Windows.Forms.Button userControlFormBtn;
    }
}

