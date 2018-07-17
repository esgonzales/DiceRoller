namespace DiceProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.die_2 = new System.Windows.Forms.PictureBox();
            this.die_1 = new System.Windows.Forms.PictureBox();
            this.roll_Btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.die_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // die_2
            // 
            this.die_2.BackColor = System.Drawing.Color.Transparent;
            this.die_2.Image = global::DiceProgram.Properties.Resources.die_0;
            this.die_2.Location = new System.Drawing.Point(120, 12);
            this.die_2.Name = "die_2";
            this.die_2.Size = new System.Drawing.Size(98, 119);
            this.die_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.die_2.TabIndex = 3;
            this.die_2.TabStop = false;
            // 
            // die_1
            // 
            this.die_1.BackColor = System.Drawing.Color.Transparent;
            this.die_1.Image = global::DiceProgram.Properties.Resources.die_0;
            this.die_1.Location = new System.Drawing.Point(12, 12);
            this.die_1.Name = "die_1";
            this.die_1.Size = new System.Drawing.Size(98, 119);
            this.die_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.die_1.TabIndex = 2;
            this.die_1.TabStop = false;
            // 
            // roll_Btn
            // 
            this.roll_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roll_Btn.Image = global::DiceProgram.Properties.Resources.btn_off;
            this.roll_Btn.Location = new System.Drawing.Point(62, 137);
            this.roll_Btn.Name = "roll_Btn";
            this.roll_Btn.Size = new System.Drawing.Size(100, 107);
            this.roll_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.roll_Btn.TabIndex = 1;
            this.roll_Btn.TabStop = false;
            this.roll_Btn.Click += new System.EventHandler(this.roll_Btn_Click);
            this.roll_Btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roll_Btn_MouseDown);
            this.roll_Btn.MouseEnter += new System.EventHandler(this.roll_Btn_MouseEnter);
            this.roll_Btn.MouseLeave += new System.EventHandler(this.roll_Btn_MouseLeave);
            this.roll_Btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.roll_Btn_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(231, 255);
            this.Controls.Add(this.die_2);
            this.Controls.Add(this.die_1);
            this.Controls.Add(this.roll_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Roller";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.die_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll_Btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox roll_Btn;
        private System.Windows.Forms.PictureBox die_1;
        private System.Windows.Forms.PictureBox die_2;
    }
}

