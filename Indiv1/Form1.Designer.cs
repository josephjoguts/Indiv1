namespace Indiv1
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
            System.Windows.Forms.Button clear;
            this.canvasBox = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.canvasBox)).BeginInit();
            this.SuspendLayout();
            // 
            // clear
            // 
            clear.Location = new System.Drawing.Point(40, 424);
            clear.Name = "clear";
            clear.Size = new System.Drawing.Size(116, 48);
            clear.TabIndex = 2;
            clear.Text = "clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // canvasBox
            // 
            this.canvasBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasBox.Location = new System.Drawing.Point(1, 0);
            this.canvasBox.Name = "canvasBox";
            this.canvasBox.Size = new System.Drawing.Size(798, 396);
            this.canvasBox.TabIndex = 0;
            this.canvasBox.TabStop = false;
            this.canvasBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvasBox_MouseClick);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(298, 424);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(212, 48);
            this.start.TabIndex = 1;
            this.start.Text = "generate";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(clear);
            this.Controls.Add(this.start);
            this.Controls.Add(this.canvasBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.canvasBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox canvasBox;

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button clear;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}