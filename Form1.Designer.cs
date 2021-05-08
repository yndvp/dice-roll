
namespace DiceRoll
{
    partial class DiceRollFrom
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
            this.RollButton = new System.Windows.Forms.Button();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RollButton
            // 
            this.RollButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RollButton.BackColor = System.Drawing.Color.MintCream;
            this.RollButton.Font = new System.Drawing.Font("HCR Dotum Ext", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RollButton.ForeColor = System.Drawing.Color.RosyBrown;
            this.RollButton.Location = new System.Drawing.Point(122, 303);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(215, 60);
            this.RollButton.TabIndex = 1;
            this.RollButton.Text = "Roll-A-Dice";
            this.RollButton.UseVisualStyleBackColor = false;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // LabelNumber
            // 
            this.LabelNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelNumber.Font = new System.Drawing.Font("HCR Dotum Ext", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LabelNumber.ForeColor = System.Drawing.Color.MintCream;
            this.LabelNumber.Location = new System.Drawing.Point(-29, 10);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(312, 279);
            this.LabelNumber.TabIndex = 0;
            this.LabelNumber.Text = "6";
            this.LabelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.Image = global::DiceRoll.Properties.Resources.num6;
            this.pictureBox.InitialImage = global::DiceRoll.Properties.Resources.num6;
            this.pictureBox.Location = new System.Drawing.Point(236, 55);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(195, 198);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // DiceRollFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(458, 416);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.LabelNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DiceRollFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiceRoll";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

