namespace TestForms
{
    partial class Form5
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.automaticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revolversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sidearms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automaticsToolStripMenuItem,
            this.revolversToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // automaticsToolStripMenuItem
            // 
            this.automaticsToolStripMenuItem.Name = "automaticsToolStripMenuItem";
            this.automaticsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.automaticsToolStripMenuItem.Text = "Automatics";
            this.automaticsToolStripMenuItem.Click += new System.EventHandler(this.automaticsToolStripMenuItem_Click);
            // 
            // revolversToolStripMenuItem
            // 
            this.revolversToolStripMenuItem.Name = "revolversToolStripMenuItem";
            this.revolversToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revolversToolStripMenuItem.Text = "Revolvers";
            this.revolversToolStripMenuItem.Click += new System.EventHandler(this.revolversToolStripMenuItem_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem automaticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revolversToolStripMenuItem;
    }
}