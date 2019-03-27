namespace TestForms
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.assaultRiflesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.battleRiflesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMGsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lMGsGPMGsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shotgunsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sniperRiflesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Weapons";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assaultRiflesToolStripMenuItem,
            this.battleRiflesToolStripMenuItem,
            this.sMGsToolStripMenuItem,
            this.lMGsGPMGsToolStripMenuItem,
            this.shotgunsToolStripMenuItem,
            this.sniperRiflesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 136);
            // 
            // assaultRiflesToolStripMenuItem
            // 
            this.assaultRiflesToolStripMenuItem.Name = "assaultRiflesToolStripMenuItem";
            this.assaultRiflesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.assaultRiflesToolStripMenuItem.Text = "Assault Rifles";
            this.assaultRiflesToolStripMenuItem.Click += new System.EventHandler(this.assaultRiflesToolStripMenuItem_Click);
            // 
            // battleRiflesToolStripMenuItem
            // 
            this.battleRiflesToolStripMenuItem.Name = "battleRiflesToolStripMenuItem";
            this.battleRiflesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.battleRiflesToolStripMenuItem.Text = "Battle Rifles";
            this.battleRiflesToolStripMenuItem.Click += new System.EventHandler(this.battleRiflesToolStripMenuItem_Click);
            // 
            // sMGsToolStripMenuItem
            // 
            this.sMGsToolStripMenuItem.Name = "sMGsToolStripMenuItem";
            this.sMGsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sMGsToolStripMenuItem.Text = "SMGs";
            this.sMGsToolStripMenuItem.Click += new System.EventHandler(this.sMGsToolStripMenuItem_Click);
            // 
            // lMGsGPMGsToolStripMenuItem
            // 
            this.lMGsGPMGsToolStripMenuItem.Name = "lMGsGPMGsToolStripMenuItem";
            this.lMGsGPMGsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lMGsGPMGsToolStripMenuItem.Text = "LMGs/GPMGs";
            this.lMGsGPMGsToolStripMenuItem.Click += new System.EventHandler(this.lMGsGPMGsToolStripMenuItem_Click);
            // 
            // shotgunsToolStripMenuItem
            // 
            this.shotgunsToolStripMenuItem.Name = "shotgunsToolStripMenuItem";
            this.shotgunsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shotgunsToolStripMenuItem.Text = "Shotguns";
            this.shotgunsToolStripMenuItem.Click += new System.EventHandler(this.shotgunsToolStripMenuItem_Click);
            // 
            // sniperRiflesToolStripMenuItem
            // 
            this.sniperRiflesToolStripMenuItem.Name = "sniperRiflesToolStripMenuItem";
            this.sniperRiflesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sniperRiflesToolStripMenuItem.Text = "Sniper Rifles";
            this.sniperRiflesToolStripMenuItem.Click += new System.EventHandler(this.sniperRiflesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem assaultRiflesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem battleRiflesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMGsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lMGsGPMGsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shotgunsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sniperRiflesToolStripMenuItem;
    }
}

