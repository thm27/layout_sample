using System.Drawing;

namespace GenericLayout
{
    partial class MainUI
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMusica = new System.Windows.Forms.Button();
            this.btnEsports = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnSeguindo = new System.Windows.Forms.Button();
            this.verticalSeparator = new System.Windows.Forms.Panel();
            this.iconHome = new FontAwesome.Sharp.IconButton();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelChannels = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblShowMore = new System.Windows.Forms.Label();
            this.itemStream9 = new GenericLayout.Components.ItemStream();
            this.itemStream8 = new GenericLayout.Components.ItemStream();
            this.itemStream7 = new GenericLayout.Components.ItemStream();
            this.itemStream6 = new GenericLayout.Components.ItemStream();
            this.itemStream5 = new GenericLayout.Components.ItemStream();
            this.itemStream4 = new GenericLayout.Components.ItemStream();
            this.itemStream3 = new GenericLayout.Components.ItemStream();
            this.itemStream2 = new GenericLayout.Components.ItemStream();
            this.itemStream1 = new GenericLayout.Components.ItemStream();
            this.panelHeader.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelChannels.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panelHeader.Controls.Add(this.btnMin);
            this.panelHeader.Controls.Add(this.btnMax);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.btnMusica);
            this.panelHeader.Controls.Add(this.btnEsports);
            this.panelHeader.Controls.Add(this.btnProcurar);
            this.panelHeader.Controls.Add(this.btnSeguindo);
            this.panelHeader.Controls.Add(this.verticalSeparator);
            this.panelHeader.Controls.Add(this.iconHome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1184, 54);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.IconSize = 16;
            this.btnMin.Location = new System.Drawing.Point(1124, 8);
            this.btnMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Rotation = 0D;
            this.btnMin.Size = new System.Drawing.Size(18, 18);
            this.btnMin.TabIndex = 12;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.IconSize = 16;
            this.btnMax.Location = new System.Drawing.Point(1142, 9);
            this.btnMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Rotation = 0D;
            this.btnMax.Size = new System.Drawing.Size(18, 18);
            this.btnMax.TabIndex = 11;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconSize = 16;
            this.btnExit.Location = new System.Drawing.Point(1160, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(18, 18);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMusica
            // 
            this.btnMusica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnMusica.FlatAppearance.BorderSize = 0;
            this.btnMusica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMusica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMusica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusica.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
            this.btnMusica.Location = new System.Drawing.Point(515, -1);
            this.btnMusica.Margin = new System.Windows.Forms.Padding(0);
            this.btnMusica.Name = "btnMusica";
            this.btnMusica.Size = new System.Drawing.Size(99, 54);
            this.btnMusica.TabIndex = 9;
            this.btnMusica.Text = "Música";
            this.btnMusica.UseVisualStyleBackColor = true;
            this.btnMusica.Click += new System.EventHandler(this.btnMusica_Click);
            // 
            // btnEsports
            // 
            this.btnEsports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEsports.FlatAppearance.BorderSize = 0;
            this.btnEsports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEsports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEsports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsports.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
            this.btnEsports.Location = new System.Drawing.Point(383, 0);
            this.btnEsports.Margin = new System.Windows.Forms.Padding(0);
            this.btnEsports.Name = "btnEsports";
            this.btnEsports.Size = new System.Drawing.Size(107, 52);
            this.btnEsports.TabIndex = 8;
            this.btnEsports.Text = "Esports";
            this.btnEsports.UseVisualStyleBackColor = true;
            this.btnEsports.Click += new System.EventHandler(this.btnEsports_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnProcurar.FlatAppearance.BorderSize = 0;
            this.btnProcurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
            this.btnProcurar.Location = new System.Drawing.Point(227, 0);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(0);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(126, 52);
            this.btnProcurar.TabIndex = 7;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnSeguindo
            // 
            this.btnSeguindo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSeguindo.FlatAppearance.BorderSize = 0;
            this.btnSeguindo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSeguindo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSeguindo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguindo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguindo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(208)))));
            this.btnSeguindo.Location = new System.Drawing.Point(89, 0);
            this.btnSeguindo.Margin = new System.Windows.Forms.Padding(0);
            this.btnSeguindo.Name = "btnSeguindo";
            this.btnSeguindo.Size = new System.Drawing.Size(126, 54);
            this.btnSeguindo.TabIndex = 6;
            this.btnSeguindo.Text = "Seguindo";
            this.btnSeguindo.UseVisualStyleBackColor = true;
            this.btnSeguindo.Click += new System.EventHandler(this.btnSeguindo_Click);
            // 
            // verticalSeparator
            // 
            this.verticalSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.verticalSeparator.Location = new System.Drawing.Point(367, 9);
            this.verticalSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.verticalSeparator.Name = "verticalSeparator";
            this.verticalSeparator.Size = new System.Drawing.Size(1, 32);
            this.verticalSeparator.TabIndex = 3;
            // 
            // iconHome
            // 
            this.iconHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.iconHome.FlatAppearance.BorderSize = 0;
            this.iconHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.Twitch;
            this.iconHome.IconColor = System.Drawing.Color.White;
            this.iconHome.IconSize = 42;
            this.iconHome.Location = new System.Drawing.Point(9, 0);
            this.iconHome.Margin = new System.Windows.Forms.Padding(0);
            this.iconHome.Name = "iconHome";
            this.iconHome.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.iconHome.Rotation = 0D;
            this.iconHome.Size = new System.Drawing.Size(61, 52);
            this.iconHome.TabIndex = 1;
            this.iconHome.UseVisualStyleBackColor = true;
            this.iconHome.Click += new System.EventHandler(this.iconHome_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.panelSide.Controls.Add(this.lblShowMore);
            this.panelSide.Controls.Add(this.itemStream9);
            this.panelSide.Controls.Add(this.itemStream8);
            this.panelSide.Controls.Add(this.itemStream7);
            this.panelSide.Controls.Add(this.itemStream6);
            this.panelSide.Controls.Add(this.itemStream5);
            this.panelSide.Controls.Add(this.itemStream4);
            this.panelSide.Controls.Add(this.itemStream3);
            this.panelSide.Controls.Add(this.itemStream2);
            this.panelSide.Controls.Add(this.itemStream1);
            this.panelSide.Controls.Add(this.panelChannels);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 54);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(245, 626);
            this.panelSide.TabIndex = 1;
            // 
            // panelChannels
            // 
            this.panelChannels.Controls.Add(this.label1);
            this.panelChannels.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChannels.Location = new System.Drawing.Point(0, 0);
            this.panelChannels.Name = "panelChannels";
            this.panelChannels.Size = new System.Drawing.Size(245, 35);
            this.panelChannels.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CANAIS SEGUIDOS";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(245, 54);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(939, 626);
            this.panelContent.TabIndex = 2;
            // 
            // lblShowMore
            // 
            this.lblShowMore.AutoSize = true;
            this.lblShowMore.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.lblShowMore.Location = new System.Drawing.Point(6, 533);
            this.lblShowMore.Name = "lblShowMore";
            this.lblShowMore.Size = new System.Drawing.Size(79, 15);
            this.lblShowMore.TabIndex = 10;
            this.lblShowMore.Text = "Mostrar mais";
            // 
            // itemStream9
            // 
            this.itemStream9.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemStream9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemStream9.Location = new System.Drawing.Point(0, 475);
            this.itemStream9.Name = "itemStream9";
            this.itemStream9.Size = new System.Drawing.Size(245, 55);
            this.itemStream9.TabIndex = 9;
            // 
            // itemStream8
            // 
            this.itemStream8.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemStream8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemStream8.Location = new System.Drawing.Point(0, 420);
            this.itemStream8.Name = "itemStream8";
            this.itemStream8.Size = new System.Drawing.Size(245, 55);
            this.itemStream8.TabIndex = 8;
            // 
            // itemStream7
            // 
            this.itemStream7.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemStream7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemStream7.Location = new System.Drawing.Point(0, 365);
            this.itemStream7.Name = "itemStream7";
            this.itemStream7.Size = new System.Drawing.Size(245, 55);
            this.itemStream7.TabIndex = 7;
            // 
            // itemStream6
            // 
            this.itemStream6.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemStream6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemStream6.Location = new System.Drawing.Point(0, 310);
            this.itemStream6.Name = "itemStream6";
            this.itemStream6.Size = new System.Drawing.Size(245, 55);
            this.itemStream6.TabIndex = 6;
            // 
            // itemStream5
            // 
            this.itemStream5.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemStream5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemStream5.Location = new System.Drawing.Point(0, 255);
            this.itemStream5.Name = "itemStream5";
            this.itemStream5.Size = new System.Drawing.Size(245, 55);
            this.itemStream5.TabIndex = 5;
            // 
            // itemStream4
            // 
            this.itemStream4.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemStream4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemStream4.Location = new System.Drawing.Point(0, 200);
            this.itemStream4.Name = "itemStream4";
            this.itemStream4.Size = new System.Drawing.Size(245, 55);
            this.itemStream4.TabIndex = 4;
            // 
            // itemStream3
            // 
            this.itemStream3.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemStream3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemStream3.Location = new System.Drawing.Point(0, 145);
            this.itemStream3.Name = "itemStream3";
            this.itemStream3.Size = new System.Drawing.Size(245, 55);
            this.itemStream3.TabIndex = 3;
            // 
            // itemStream2
            // 
            this.itemStream2.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemStream2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemStream2.Location = new System.Drawing.Point(0, 90);
            this.itemStream2.Name = "itemStream2";
            this.itemStream2.Size = new System.Drawing.Size(245, 55);
            this.itemStream2.TabIndex = 2;
            // 
            // itemStream1
            // 
            this.itemStream1.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemStream1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemStream1.Location = new System.Drawing.Point(0, 35);
            this.itemStream1.Name = "itemStream1";
            this.itemStream1.Size = new System.Drawing.Size(245, 55);
            this.itemStream1.TabIndex = 1;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 680);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.panelHeader.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.panelChannels.ResumeLayout(false);
            this.panelChannels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSide;
        private FontAwesome.Sharp.IconButton iconHome;
        private System.Windows.Forms.Panel verticalSeparator;
        private System.Windows.Forms.Button btnSeguindo;
        private System.Windows.Forms.Button btnMusica;
        private System.Windows.Forms.Button btnEsports;
        private System.Windows.Forms.Button btnProcurar;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panelChannels;
        private System.Windows.Forms.Label label1;
        private Components.ItemStream itemStream1;
        private Components.ItemStream itemStream6;
        private Components.ItemStream itemStream5;
        private Components.ItemStream itemStream4;
        private Components.ItemStream itemStream3;
        private Components.ItemStream itemStream2;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblShowMore;
        private Components.ItemStream itemStream9;
        private Components.ItemStream itemStream8;
        private Components.ItemStream itemStream7;
    }
}