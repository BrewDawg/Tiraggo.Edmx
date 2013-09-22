namespace ReadEdmxFiles
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
            this.btnV2 = new System.Windows.Forms.Button();
            this.btnV3 = new System.Windows.Forms.Button();
            this.lnkTiraggoEdmx = new System.Windows.Forms.LinkLabel();
            this.lnkTiraggoEF = new System.Windows.Forms.LinkLabel();
            this.codeWindow = new ScintillaNET.Scintilla();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.codeWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnV2
            // 
            this.btnV2.Location = new System.Drawing.Point(13, 12);
            this.btnV2.Name = "btnV2";
            this.btnV2.Size = new System.Drawing.Size(131, 28);
            this.btnV2.TabIndex = 0;
            this.btnV2.Text = "Load V2 EDMX File";
            this.btnV2.UseVisualStyleBackColor = true;
            this.btnV2.Click += new System.EventHandler(this.btnV2_Click);
            // 
            // btnV3
            // 
            this.btnV3.Location = new System.Drawing.Point(163, 12);
            this.btnV3.Name = "btnV3";
            this.btnV3.Size = new System.Drawing.Size(131, 28);
            this.btnV3.TabIndex = 1;
            this.btnV3.Text = "Load V3 EDMX File";
            this.btnV3.UseVisualStyleBackColor = true;
            this.btnV3.Click += new System.EventHandler(this.btnV3_Click);
            // 
            // lnkTiraggoEdmx
            // 
            this.lnkTiraggoEdmx.AutoSize = true;
            this.lnkTiraggoEdmx.Location = new System.Drawing.Point(334, 20);
            this.lnkTiraggoEdmx.Name = "lnkTiraggoEdmx";
            this.lnkTiraggoEdmx.Size = new System.Drawing.Size(72, 13);
            this.lnkTiraggoEdmx.TabIndex = 3;
            this.lnkTiraggoEdmx.TabStop = true;
            this.lnkTiraggoEdmx.Text = "Tiraggo.Edmx";
            this.lnkTiraggoEdmx.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTiraggoEdmx_LinkClicked);
            // 
            // lnkTiraggoEF
            // 
            this.lnkTiraggoEF.AutoSize = true;
            this.lnkTiraggoEF.Location = new System.Drawing.Point(432, 20);
            this.lnkTiraggoEF.Name = "lnkTiraggoEF";
            this.lnkTiraggoEF.Size = new System.Drawing.Size(59, 13);
            this.lnkTiraggoEF.TabIndex = 4;
            this.lnkTiraggoEF.TabStop = true;
            this.lnkTiraggoEF.Text = "Tiraggo.EF";
            this.lnkTiraggoEF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTiraggoEF_LinkClicked);
            // 
            // codeWindow
            // 
            this.codeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeWindow.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeWindow.Location = new System.Drawing.Point(13, 48);
            this.codeWindow.Name = "codeWindow";
            this.codeWindow.Size = new System.Drawing.Size(588, 317);
            this.codeWindow.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "In reality you would use \'TiraggoEdmx\' in your T4 Templates, See Tiraggo.EF which" +
    " does just that.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeWindow);
            this.Controls.Add(this.lnkTiraggoEF);
            this.Controls.Add(this.lnkTiraggoEdmx);
            this.Controls.Add(this.btnV3);
            this.Controls.Add(this.btnV2);
            this.Name = "Form1";
            this.Text = "TiraggoEdmx.EF Demonstration by Mike Griffin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codeWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnV2;
        private System.Windows.Forms.Button btnV3;
        private System.Windows.Forms.LinkLabel lnkTiraggoEdmx;
        private System.Windows.Forms.LinkLabel lnkTiraggoEF;
        private ScintillaNET.Scintilla codeWindow;
        private System.Windows.Forms.Label label1;
    }
}

