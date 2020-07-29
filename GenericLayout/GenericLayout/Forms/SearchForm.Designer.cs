namespace GenericLayout.Forms
{
    partial class SearchForm
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
            this.textInput1 = new GenericLayout.Components.TextInput();
            this.innerContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // innerContentPanel
            // 
            this.innerContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
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
            this.btnCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCenter.FlatAppearance.BorderSize = 0;
            this.btnCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCenter.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
            this.btnCenter.Location = new System.Drawing.Point(337, 198);
            this.btnCenter.Margin = new System.Windows.Forms.Padding(0);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(126, 54);
            this.btnCenter.TabIndex = 7;
            this.btnCenter.Text = "Search";
            this.btnCenter.UseVisualStyleBackColor = true;
            // 
            // textInput1
            // 
            this.textInput1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textInput1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.textInput1.Location = new System.Drawing.Point(519, 12);
            this.textInput1.Name = "textInput1";
            this.textInput1.PlaceHolder = "SearchPlaceHolder";
            this.textInput1.Size = new System.Drawing.Size(269, 25);
            this.textInput1.TabIndex = 8;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.innerContentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.innerContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel innerContentPanel;
        private System.Windows.Forms.Button btnCenter;
        private Components.TextInput textInput1;
    }
}