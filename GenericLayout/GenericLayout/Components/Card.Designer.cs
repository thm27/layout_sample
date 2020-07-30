namespace GenericLayout.Components
{
    partial class Card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));
            this.imgCard = new System.Windows.Forms.PictureBox();
            this.panelCardDesc = new System.Windows.Forms.Panel();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblSpecCount = new System.Windows.Forms.Label();
            this.btnTag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCard)).BeginInit();
            this.panelCardDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgCard
            // 
            this.imgCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgCard.Image = ((System.Drawing.Image)(resources.GetObject("imgCard.Image")));
            this.imgCard.Location = new System.Drawing.Point(0, 0);
            this.imgCard.Margin = new System.Windows.Forms.Padding(0);
            this.imgCard.Name = "imgCard";
            this.imgCard.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.imgCard.Size = new System.Drawing.Size(210, 280);
            this.imgCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCard.TabIndex = 0;
            this.imgCard.TabStop = false;
            // 
            // panelCardDesc
            // 
            this.panelCardDesc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCardDesc.Controls.Add(this.btnTag);
            this.panelCardDesc.Controls.Add(this.lblSpecCount);
            this.panelCardDesc.Controls.Add(this.lblCardTitle);
            this.panelCardDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardDesc.Location = new System.Drawing.Point(0, 280);
            this.panelCardDesc.Margin = new System.Windows.Forms.Padding(0);
            this.panelCardDesc.Name = "panelCardDesc";
            this.panelCardDesc.Size = new System.Drawing.Size(210, 81);
            this.panelCardDesc.TabIndex = 1;
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.lblCardTitle.Location = new System.Drawing.Point(3, 5);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(102, 18);
            this.lblCardTitle.TabIndex = 2;
            this.lblCardTitle.Text = "Just Chatting";
            // 
            // lblSpecCount
            // 
            this.lblSpecCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSpecCount.AutoSize = true;
            this.lblSpecCount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
            this.lblSpecCount.Location = new System.Drawing.Point(3, 23);
            this.lblSpecCount.Name = "lblSpecCount";
            this.lblSpecCount.Size = new System.Drawing.Size(113, 15);
            this.lblSpecCount.TabIndex = 3;
            this.lblSpecCount.Text = "208.124 spectators";
            // 
            // btnTag
            // 
            this.btnTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.btnTag.FlatAppearance.BorderSize = 0;
            this.btnTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTag.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
            this.btnTag.Location = new System.Drawing.Point(6, 42);
            this.btnTag.Margin = new System.Windows.Forms.Padding(0);
            this.btnTag.Name = "btnTag";
            this.btnTag.Size = new System.Drawing.Size(75, 29);
            this.btnTag.TabIndex = 4;
            this.btnTag.Text = "Real Life";
            this.btnTag.UseVisualStyleBackColor = false;
            this.btnTag.Paint += new System.Windows.Forms.PaintEventHandler(this.btnTag_Paint);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelCardDesc);
            this.Controls.Add(this.imgCard);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(210, 361);
            ((System.ComponentModel.ISupportInitialize)(this.imgCard)).EndInit();
            this.panelCardDesc.ResumeLayout(false);
            this.panelCardDesc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCard;
        private System.Windows.Forms.Panel panelCardDesc;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblSpecCount;
        private System.Windows.Forms.Button btnTag;
    }
}
