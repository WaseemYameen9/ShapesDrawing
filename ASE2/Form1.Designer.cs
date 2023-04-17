
namespace ASEProject
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
            this.CommandRchBox = new System.Windows.Forms.RichTextBox();
            this.CommandBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CommandRchBox
            // 
            this.CommandRchBox.Location = new System.Drawing.Point(13, 13);
            this.CommandRchBox.Name = "CommandRchBox";
            this.CommandRchBox.Size = new System.Drawing.Size(629, 552);
            this.CommandRchBox.TabIndex = 0;
            this.CommandRchBox.Text = "";
            // 
            // CommandBox
            // 
            this.CommandBox.Location = new System.Drawing.Point(14, 574);
            this.CommandBox.Name = "CommandBox";
            this.CommandBox.Size = new System.Drawing.Size(627, 20);
            this.CommandBox.TabIndex = 1;
            this.CommandBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandBox_KeyDown);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(669, 13);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(659, 552);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.TabStop = false;
            this.OutputBox.Paint += new System.Windows.Forms.PaintEventHandler(this.OutputBox_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 600);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.CommandBox);
            this.Controls.Add(this.CommandRchBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CommandRchBox;
        private System.Windows.Forms.TextBox CommandBox;
        private System.Windows.Forms.PictureBox OutputBox;
    }
}

