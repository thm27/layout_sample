namespace GenericLayout.Forms
{
    partial class FollowingForm
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
            this.innerContentPanel = new System.Windows.Forms.Panel();
            this.btnCenter = new System.Windows.Forms.Button();
            this.card3 = new GenericLayout.Components.Card();
            this.card2 = new GenericLayout.Components.Card();
            this.card1 = new GenericLayout.Components.Card();
            this.innerContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // innerContentPanel
            // 
            this.innerContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.innerContentPanel.Controls.Add(this.card3);
            this.innerContentPanel.Controls.Add(this.card2);
            this.innerContentPanel.Controls.Add(this.card1);
            this.innerContentPanel.Controls.Add(this.btnCenter);
            this.innerContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerContentPanel.Location = new System.Drawing.Point(0, 0);
            this.innerContentPanel.Name = "innerContentPanel";
            this.innerContentPanel.Size = new System.Drawing.Size(800, 450);
            this.innerContentPanel.TabIndex = 0;
            // 
            // btnCenter
            // 
            this.btnCenter.FlatAppearance.BorderSize = 0;
            this.btnCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCenter.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
            this.btnCenter.Location = new System.Drawing.Point(9, 12);
            this.btnCenter.Margin = new System.Windows.Forms.Padding(0);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(126, 54);
            this.btnCenter.TabIndex = 7;
            this.btnCenter.Text = "Seguindo";
            this.btnCenter.UseVisualStyleBackColor = true;
            // 
            // card3
            // 
            this.card3.BackColor = System.Drawing.Color.Transparent;
            this.card3.Location = new System.Drawing.Point(485, 69);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(209, 362);
            this.card3.TabIndex = 12;
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.Transparent;
            this.card2.Location = new System.Drawing.Point(249, 69);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(209, 362);
            this.card2.TabIndex = 11;
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.Transparent;
            this.card1.Location = new System.Drawing.Point(12, 69);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(209, 362);
            this.card1.TabIndex = 10;
            // 
            // FollowingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.innerContentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FollowingForm";
            this.innerContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel innerContentPanel;
        private System.Windows.Forms.Button btnCenter;
        private Components.Card card1;
        private Components.Card card2;
        private Components.Card card3;
    }
}