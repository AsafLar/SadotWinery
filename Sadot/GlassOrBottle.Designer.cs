namespace Sadot
{
    partial class GlassOrBottle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlassOrBottle));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGlass = new System.Windows.Forms.Button();
            this.btnBottle = new System.Windows.Forms.Button();
            this.btnToTake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.Location = new System.Drawing.Point(136, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "יש לבחור כוס או בקבוק";
            // 
            // btnGlass
            // 
            this.btnGlass.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGlass.Location = new System.Drawing.Point(13, 92);
            this.btnGlass.Name = "btnGlass";
            this.btnGlass.Size = new System.Drawing.Size(178, 59);
            this.btnGlass.TabIndex = 1;
            this.btnGlass.Text = "כוס";
            this.btnGlass.UseVisualStyleBackColor = true;
            this.btnGlass.Click += new System.EventHandler(this.btnGlass_Click);
            // 
            // btnBottle
            // 
            this.btnBottle.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBottle.Location = new System.Drawing.Point(196, 92);
            this.btnBottle.Name = "btnBottle";
            this.btnBottle.Size = new System.Drawing.Size(178, 59);
            this.btnBottle.TabIndex = 2;
            this.btnBottle.Text = "בקבוק";
            this.btnBottle.UseVisualStyleBackColor = true;
            this.btnBottle.Click += new System.EventHandler(this.btnBottle_Click);
            // 
            // btnToTake
            // 
            this.btnToTake.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnToTake.Location = new System.Drawing.Point(380, 92);
            this.btnToTake.Name = "btnToTake";
            this.btnToTake.Size = new System.Drawing.Size(178, 59);
            this.btnToTake.TabIndex = 3;
            this.btnToTake.Text = "בקבוק לקחת";
            this.btnToTake.UseVisualStyleBackColor = true;
            this.btnToTake.Click += new System.EventHandler(this.btnToTake_Click);
            // 
            // GlassOrBottle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 183);
            this.Controls.Add(this.btnToTake);
            this.Controls.Add(this.btnBottle);
            this.Controls.Add(this.btnGlass);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlassOrBottle";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הודעת מערכת";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGlass;
        private System.Windows.Forms.Button btnBottle;
        private System.Windows.Forms.Button btnToTake;
    }
}