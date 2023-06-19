namespace breakout
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
            this.Nameofgame = new System.Windows.Forms.Label();
            this.EXIT = new System.Windows.Forms.Label();
            this.DOnt = new System.Windows.Forms.Button();
            this.Do = new System.Windows.Forms.Button();
            this.Gaming = new System.Windows.Forms.Timer(this.components);
            this.ah = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nameofgame
            // 
            this.Nameofgame.AutoSize = true;
            this.Nameofgame.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nameofgame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nameofgame.Location = new System.Drawing.Point(254, 63);
            this.Nameofgame.Name = "Nameofgame";
            this.Nameofgame.Size = new System.Drawing.Size(140, 31);
            this.Nameofgame.TabIndex = 1;
            this.Nameofgame.Text = "BREAKOUT";
            // 
            // EXIT
            // 
            this.EXIT.AutoSize = true;
            this.EXIT.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EXIT.Location = new System.Drawing.Point(266, 167);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(0, 31);
            this.EXIT.TabIndex = 2;
            // 
            // DOnt
            // 
            this.DOnt.BackColor = System.Drawing.Color.Black;
            this.DOnt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DOnt.FlatAppearance.BorderSize = 0;
            this.DOnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DOnt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOnt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DOnt.Location = new System.Drawing.Point(150, 179);
            this.DOnt.Name = "DOnt";
            this.DOnt.Size = new System.Drawing.Size(95, 56);
            this.DOnt.TabIndex = 3;
            this.DOnt.Text = "EXIT";
            this.DOnt.UseVisualStyleBackColor = false;
            this.DOnt.Click += new System.EventHandler(this.DOnt_Click);
            // 
            // Do
            // 
            this.Do.BackColor = System.Drawing.Color.Black;
            this.Do.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Do.FlatAppearance.BorderSize = 0;
            this.Do.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Do.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Do.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Do.Location = new System.Drawing.Point(393, 179);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(95, 56);
            this.Do.TabIndex = 4;
            this.Do.Text = "PLAY";
            this.Do.UseVisualStyleBackColor = false;
            this.Do.Click += new System.EventHandler(this.Do_Click);
            // 
            // Gaming
            // 
            this.Gaming.Interval = 20;
            this.Gaming.Tick += new System.EventHandler(this.Gaming_Tick);
            // 
            // ah
            // 
            this.ah.AutoSize = true;
            this.ah.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ah.Location = new System.Drawing.Point(281, 156);
            this.ah.Name = "ah";
            this.ah.Size = new System.Drawing.Size(0, 18);
            this.ah.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(673, 365);
            this.Controls.Add(this.ah);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.DOnt);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.Nameofgame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Nameofgame;
        private System.Windows.Forms.Label EXIT;
        private System.Windows.Forms.Button DOnt;
        private System.Windows.Forms.Button Do;
        private System.Windows.Forms.Timer Gaming;
        private System.Windows.Forms.Label ah;
    }
}

