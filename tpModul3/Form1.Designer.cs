namespace tpModul3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNama = new TextBox();
            btnSubmit = new Button();
            tbOutput = new TextBox();
            SuspendLayout();
            // 
            // tbNama
            // 
            tbNama.ForeColor = SystemColors.ControlText;
            tbNama.Location = new Point(159, 149);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(338, 27);
            tbNama.TabIndex = 0;
            tbNama.Text = "Masukan nama";
            tbNama.TextChanged += tbNama_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(545, 147);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(159, 202);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(480, 27);
            tbOutput.TabIndex = 3;
            tbOutput.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbOutput);
            Controls.Add(btnSubmit);
            Controls.Add(tbNama);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNama;
        private Button btnSubmit;
        private TextBox tbOutput;
    }
}
