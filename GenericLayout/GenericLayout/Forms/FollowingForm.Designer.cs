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
            this.card2 = new GenericLayout.Components.Card();
            this.card1 = new GenericLayout.Components.Card();
            this.textInput2 = new GenericLayout.Components.TextInput();
            this.textInput1 = new GenericLayout.Components.TextInput();
            this.innerContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // innerContentPanel
            // 
            this.innerContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.innerContentPanel.Controls.Add(this.card2);
            this.innerContentPanel.Controls.Add(this.card1);
            this.innerContentPanel.Controls.Add(this.textInput2);
            this.innerContentPanel.Controls.Add(this.textInput1);
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
            this.btnCenter.Location = new System.Drawing.Point(12, 84);
            this.btnCenter.Margin = new System.Windows.Forms.Padding(0);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(126, 54);
            this.btnCenter.TabIndex = 7;
            this.btnCenter.Text = "Seguindo";
            this.btnCenter.UseVisualStyleBackColor = true;
            // 
            // card2
            // 
            this.card2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.card2.BackColor = System.Drawing.Color.Transparent;
            this.card2.Location = new System.Drawing.Point(530, 12);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(209, 362);
            this.card2.TabIndex = 11;
            // 
            // card1
            // 
            this.card1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.card1.BackColor = System.Drawing.Color.Transparent;
            this.card1.Location = new System.Drawing.Point(303, 12);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(209, 362);
            this.card1.TabIndex = 10;
            // 
            // textInput2
            // 
            this.textInput2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.textInput2.Location = new System.Drawing.Point(12, 56);
            this.textInput2.Name = "textInput2";
            this.textInput2.PlaceHolder = "PlaceHolder2Sample";
            this.textInput2.Size = new System.Drawing.Size(269, 25);
            this.textInput2.TabIndex = 9;
            // 
            // textInput1
            // 
            this.textInput1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.textInput1.Location = new System.Drawing.Point(12, 12);
            this.textInput1.Name = "textInput1";
            this.textInput1.PlaceHolder = "PlaceHolderSample";
            this.textInput1.Size = new System.Drawing.Size(269, 25);
            this.textInput1.TabIndex = 8;
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
        private Components.TextInput textInput1;
        private Components.TextInput textInput2;
        private Components.Card card1;
        private Components.Card card2;
    }
}