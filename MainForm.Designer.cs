namespace DesktopViewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.monitorSelection = new System.Windows.Forms.ToolStripComboBox();
            this.enabledButton = new System.Windows.Forms.ToolStripButton();
            this.image = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.aboutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monitorSelection,
            this.enabledButton,
            this.aboutButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(617, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // monitorSelection
            // 
            this.monitorSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monitorSelection.Name = "monitorSelection";
            this.monitorSelection.Size = new System.Drawing.Size(200, 25);
            // 
            // enabledButton
            // 
            this.enabledButton.CheckOnClick = true;
            this.enabledButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.enabledButton.Name = "enabledButton";
            this.enabledButton.Size = new System.Drawing.Size(35, 22);
            this.enabledButton.Text = "Start";
            this.enabledButton.Click += new System.EventHandler(this.enabled_Click);
            // 
            // image
            // 
            this.image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image.Location = new System.Drawing.Point(0, 25);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(617, 423);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // aboutButton
            // 
            this.aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(53, 22);
            this.aboutButton.Text = "About...";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 448);
            this.Controls.Add(this.image);
            this.Controls.Add(this.toolStrip);
            this.Name = "MainForm";
            this.Text = "DesktopViewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripComboBox monitorSelection;
        private System.Windows.Forms.ToolStripButton enabledButton;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripButton aboutButton;
    }
}

