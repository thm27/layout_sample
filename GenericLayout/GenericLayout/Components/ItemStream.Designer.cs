namespace GenericLayout.Components
{
    partial class ItemStream
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemStream));
            this.panelItem = new System.Windows.Forms.Panel();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.imageItem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelItem
            // 
            this.panelItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.panelItem.Controls.Add(this.label1);
            this.panelItem.Controls.Add(this.lblNumbers);
            this.panelItem.Controls.Add(this.lblGame);
            this.panelItem.Controls.Add(this.lblName);
            this.panelItem.Controls.Add(this.imageItem);
            this.panelItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelItem.Location = new System.Drawing.Point(0, 0);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(235, 65);
            this.panelItem.TabIndex = 2;
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
            this.lblNumbers.Location = new System.Drawing.Point(178, 16);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(40, 16);
            this.lblNumbers.TabIndex = 3;
            this.lblNumbers.Text = "1.321";
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
            this.lblGame.Location = new System.Drawing.Point(47, 34);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(35, 14);
            this.lblGame.TabIndex = 2;
            this.lblGame.Text = "Game";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
            this.lblName.Location = new System.Drawing.Point(47, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nickname";
            // 
            // imageItem
            // 
            this.imageItem.Image = ((System.Drawing.Image)(resources.GetObject("imageItem.Image")));
            this.imageItem.Location = new System.Drawing.Point(9, 14);
            this.imageItem.Name = "imageItem";
            this.imageItem.Size = new System.Drawing.Size(32, 34);
            this.imageItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageItem.TabIndex = 0;
            this.imageItem.TabStop = false;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(166, 20);
            this.label1.MaximumSize = new System.Drawing.Size(16, 16);
            this.label1.MinimumSize = new System.Drawing.Size(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 8);
            this.label1.TabIndex = 4;
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
            // 
            // ItemStream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelItem);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ItemStream";
            this.Size = new System.Drawing.Size(235, 65);
            this.panelItem.ResumeLayout(false);
            this.panelItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.PictureBox imageItem;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label label1;
    }
}
