namespace MultiScad
{
    partial class LoadingSVGFile
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
            this.processText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputMD5Text = new System.Windows.Forms.Label();
            this.inputNameText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // processText
            // 
            this.processText.Location = new System.Drawing.Point(118, 41);
            this.processText.Name = "processText";
            this.processText.Size = new System.Drawing.Size(226, 16);
            this.processText.TabIndex = 0;
            this.processText.Text = "PROCESSING TEXT";
            this.processText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.processText.UseWaitCursor = true;
            this.processText.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Processing: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "MD5 Hash: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Input File: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseWaitCursor = true;
            // 
            // inputMD5Text
            // 
            this.inputMD5Text.Location = new System.Drawing.Point(118, 25);
            this.inputMD5Text.Name = "inputMD5Text";
            this.inputMD5Text.Size = new System.Drawing.Size(226, 16);
            this.inputMD5Text.TabIndex = 5;
            this.inputMD5Text.Text = "INPUT MD5 HASH";
            this.inputMD5Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inputMD5Text.UseWaitCursor = true;
            // 
            // inputNameText
            // 
            this.inputNameText.Location = new System.Drawing.Point(118, 9);
            this.inputNameText.Name = "inputNameText";
            this.inputNameText.Size = new System.Drawing.Size(226, 16);
            this.inputNameText.TabIndex = 6;
            this.inputNameText.Text = "INPUT FILE NAME";
            this.inputNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inputNameText.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel Import";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LoadingSVGFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 97);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputNameText);
            this.Controls.Add(this.inputMD5Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingSVGFile";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Loading SVG File";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.LoadingSVGFile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label processText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label inputMD5Text;
        private System.Windows.Forms.Label inputNameText;
        private System.Windows.Forms.Button button1;
    }
}