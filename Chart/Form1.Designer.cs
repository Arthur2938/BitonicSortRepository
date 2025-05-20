namespace Chart
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1.25F;
            formsPlot1.Location = new Point(74, 12);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(438, 385);
            formsPlot1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 478);
            Controls.Add(formsPlot1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}
