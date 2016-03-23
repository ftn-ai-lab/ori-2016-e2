namespace Lavirint
{
    partial class Main
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnPrviUDubinu = new System.Windows.Forms.Button();
            this.btnResenje = new System.Windows.Forms.Button();
            this.btnPrviUSirinu = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnIterativniPrviUDubinu = new System.Windows.Forms.Button();
            this.displayPanel1 = new Lavirint.DisplayPanel();
            this.btnAStar = new System.Windows.Forms.Button();
            this.ADepth = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 384);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(83, 384);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Open";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnPrviUDubinu
            // 
            this.btnPrviUDubinu.Location = new System.Drawing.Point(163, 384);
            this.btnPrviUDubinu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrviUDubinu.Name = "btnPrviUDubinu";
            this.btnPrviUDubinu.Size = new System.Drawing.Size(112, 23);
            this.btnPrviUDubinu.TabIndex = 3;
            this.btnPrviUDubinu.Text = "Prvi u dubinu";
            this.btnPrviUDubinu.UseVisualStyleBackColor = true;
            this.btnPrviUDubinu.Click += new System.EventHandler(this.btnPrviUDubinu_Click);
            // 
            // btnResenje
            // 
            this.btnResenje.Location = new System.Drawing.Point(716, 388);
            this.btnResenje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResenje.Name = "btnResenje";
            this.btnResenje.Size = new System.Drawing.Size(103, 23);
            this.btnResenje.TabIndex = 5;
            this.btnResenje.Text = "Rešenje";
            this.btnResenje.UseVisualStyleBackColor = true;
            this.btnResenje.Click += new System.EventHandler(this.btnResenje_Click);
            // 
            // btnPrviUSirinu
            // 
            this.btnPrviUSirinu.Location = new System.Drawing.Point(281, 384);
            this.btnPrviUSirinu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrviUSirinu.Name = "btnPrviUSirinu";
            this.btnPrviUSirinu.Size = new System.Drawing.Size(93, 23);
            this.btnPrviUSirinu.TabIndex = 6;
            this.btnPrviUSirinu.Text = "Prvi u širinu";
            this.btnPrviUSirinu.UseVisualStyleBackColor = true;
            this.btnPrviUSirinu.Click += new System.EventHandler(this.btnPrviUSirinu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 436);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(828, 25);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(99, 20);
            this.lblStatus.Text = "---------------";
            // 
            // btnIterativniPrviUDubinu
            // 
            this.btnIterativniPrviUDubinu.Location = new System.Drawing.Point(381, 384);
            this.btnIterativniPrviUDubinu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIterativniPrviUDubinu.Name = "btnIterativniPrviUDubinu";
            this.btnIterativniPrviUDubinu.Size = new System.Drawing.Size(112, 23);
            this.btnIterativniPrviUDubinu.TabIndex = 8;
            this.btnIterativniPrviUDubinu.Text = "I Prvi u dubinu";
            this.btnIterativniPrviUDubinu.UseVisualStyleBackColor = true;
            this.btnIterativniPrviUDubinu.Click += new System.EventHandler(this.btnIterativniPrviUDubinu_Click);
            // 
            // displayPanel1
            // 
            this.displayPanel1.Location = new System.Drawing.Point(3, 2);
            this.displayPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayPanel1.Name = "displayPanel1";
            this.displayPanel1.Size = new System.Drawing.Size(816, 378);
            this.displayPanel1.TabIndex = 0;
            // 
            // btnAStar
            // 
            this.btnAStar.Location = new System.Drawing.Point(499, 384);
            this.btnAStar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAStar.Name = "btnAStar";
            this.btnAStar.Size = new System.Drawing.Size(97, 23);
            this.btnAStar.TabIndex = 10;
            this.btnAStar.Text = "A*";
            this.btnAStar.UseVisualStyleBackColor = true;
            this.btnAStar.Click += new System.EventHandler(this.btnAStar_Click);
            // 
            // ADepth
            // 
            this.ADepth.Location = new System.Drawing.Point(609, 384);
            this.ADepth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ADepth.Name = "ADepth";
            this.ADepth.Size = new System.Drawing.Size(100, 28);
            this.ADepth.TabIndex = 11;
            this.ADepth.Text = "ADepth";
            this.ADepth.UseVisualStyleBackColor = true;
            this.ADepth.Click += new System.EventHandler(this.ADepth_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Debug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.showSearchPath_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ADepth);
            this.Controls.Add(this.btnAStar);
            this.Controls.Add(this.btnIterativniPrviUDubinu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPrviUSirinu);
            this.Controls.Add(this.btnResenje);
            this.Controls.Add(this.btnPrviUDubinu);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.displayPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "PRETRAGE Lavirint - Primer za vežbe iz predmeta ORI";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DisplayPanel displayPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnPrviUDubinu;
        private System.Windows.Forms.Button btnResenje;
        private System.Windows.Forms.Button btnPrviUSirinu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnIterativniPrviUDubinu;
        private System.Windows.Forms.Button btnAStar;
        private System.Windows.Forms.Button ADepth;
        private System.Windows.Forms.Button button1;
    }
}

