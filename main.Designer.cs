namespace LCC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.openStudioCodeGarbage = new System.Windows.Forms.Button();
            this.openSpotifyGarbage = new System.Windows.Forms.Button();
            this.openMicrosoftGarbage = new System.Windows.Forms.Button();
            this.openAdobeGarbage = new System.Windows.Forms.Button();
            this.buttonsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TT_StudioCode = new System.Windows.Forms.ToolTip(this.components);
            this.TT_AdobeCC = new System.Windows.Forms.ToolTip(this.components);
            this.TT_Spotify = new System.Windows.Forms.ToolTip(this.components);
            this.TT_Microsoft = new System.Windows.Forms.ToolTip(this.components);
            this.buttonsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // openStudioCodeGarbage
            // 
            this.openStudioCodeGarbage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openStudioCodeGarbage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.openStudioCodeGarbage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.openStudioCodeGarbage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.openStudioCodeGarbage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openStudioCodeGarbage.Font = new System.Drawing.Font("Manrope", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openStudioCodeGarbage.Location = new System.Drawing.Point(3, 3);
            this.openStudioCodeGarbage.Name = "openStudioCodeGarbage";
            this.openStudioCodeGarbage.Size = new System.Drawing.Size(152, 41);
            this.openStudioCodeGarbage.TabIndex = 1;
            this.openStudioCodeGarbage.Text = "Studio Code";
            this.TT_StudioCode.SetToolTip(this.openStudioCodeGarbage, "Opens folders containing Studio Code junk files.");
            this.openStudioCodeGarbage.UseVisualStyleBackColor = false;
            this.openStudioCodeGarbage.Click += new System.EventHandler(this.openStudioCodeGarbage_Click);
            // 
            // openSpotifyGarbage
            // 
            this.openSpotifyGarbage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openSpotifyGarbage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.openSpotifyGarbage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.openSpotifyGarbage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.openSpotifyGarbage.FlatAppearance.BorderSize = 2;
            this.openSpotifyGarbage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSpotifyGarbage.Font = new System.Drawing.Font("Manrope", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSpotifyGarbage.Location = new System.Drawing.Point(3, 97);
            this.openSpotifyGarbage.Name = "openSpotifyGarbage";
            this.openSpotifyGarbage.Size = new System.Drawing.Size(152, 41);
            this.openSpotifyGarbage.TabIndex = 2;
            this.openSpotifyGarbage.Text = "Spotify";
            this.TT_Spotify.SetToolTip(this.openSpotifyGarbage, "Opens folders containing junk files related to Spotify.");
            this.openSpotifyGarbage.UseVisualStyleBackColor = false;
            this.openSpotifyGarbage.Click += new System.EventHandler(this.openSpotifyGarbage_Click);
            // 
            // openMicrosoftGarbage
            // 
            this.openMicrosoftGarbage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openMicrosoftGarbage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.openMicrosoftGarbage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.openMicrosoftGarbage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.openMicrosoftGarbage.FlatAppearance.BorderSize = 2;
            this.openMicrosoftGarbage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openMicrosoftGarbage.Font = new System.Drawing.Font("Manrope", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openMicrosoftGarbage.Location = new System.Drawing.Point(3, 144);
            this.openMicrosoftGarbage.Name = "openMicrosoftGarbage";
            this.openMicrosoftGarbage.Size = new System.Drawing.Size(152, 41);
            this.openMicrosoftGarbage.TabIndex = 3;
            this.openMicrosoftGarbage.Text = "Microsoft";
            this.TT_Microsoft.SetToolTip(this.openMicrosoftGarbage, "Opens folders containing junk files related to Windows OS.");
            this.openMicrosoftGarbage.UseVisualStyleBackColor = false;
            this.openMicrosoftGarbage.Click += new System.EventHandler(this.openMicrosoftGarbage_Click);
            // 
            // openAdobeGarbage
            // 
            this.openAdobeGarbage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openAdobeGarbage.BackColor = System.Drawing.Color.Red;
            this.openAdobeGarbage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.openAdobeGarbage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.openAdobeGarbage.FlatAppearance.BorderSize = 2;
            this.openAdobeGarbage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openAdobeGarbage.Font = new System.Drawing.Font("Manrope", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAdobeGarbage.Location = new System.Drawing.Point(3, 50);
            this.openAdobeGarbage.Name = "openAdobeGarbage";
            this.openAdobeGarbage.Size = new System.Drawing.Size(152, 41);
            this.openAdobeGarbage.TabIndex = 4;
            this.openAdobeGarbage.Text = "Adobe CC 2023";
            this.TT_AdobeCC.SetToolTip(this.openAdobeGarbage, "Opens folders containing junk files related to Adobe CC apps.");
            this.openAdobeGarbage.UseVisualStyleBackColor = false;
            this.openAdobeGarbage.Click += new System.EventHandler(this.openAdobeGarbage_Click);
            // 
            // buttonsContainer
            // 
            this.buttonsContainer.Controls.Add(this.openStudioCodeGarbage);
            this.buttonsContainer.Controls.Add(this.openAdobeGarbage);
            this.buttonsContainer.Controls.Add(this.openSpotifyGarbage);
            this.buttonsContainer.Controls.Add(this.openMicrosoftGarbage);
            this.buttonsContainer.Location = new System.Drawing.Point(261, 73);
            this.buttonsContainer.MaximumSize = new System.Drawing.Size(267, 257);
            this.buttonsContainer.Name = "buttonsContainer";
            this.buttonsContainer.Size = new System.Drawing.Size(166, 192);
            this.buttonsContainer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "All files and folders are safe to delete in the folders that open for each app.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(13)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonsContainer);
            this.Font = new System.Drawing.Font("Manrope", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LCC - Log & Cache Cleaner";
            this.buttonsContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openStudioCodeGarbage;
        private System.Windows.Forms.Button openSpotifyGarbage;
        private System.Windows.Forms.Button openMicrosoftGarbage;
        private System.Windows.Forms.Button openAdobeGarbage;
        private System.Windows.Forms.FlowLayoutPanel buttonsContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip TT_StudioCode;
        private System.Windows.Forms.ToolTip TT_Spotify;
        private System.Windows.Forms.ToolTip TT_Microsoft;
        private System.Windows.Forms.ToolTip TT_AdobeCC;
    }
}

