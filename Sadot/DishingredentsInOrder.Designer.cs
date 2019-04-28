namespace Sadot
{
    partial class DishingredentsInOrder
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
            this.lblDishName = new System.Windows.Forms.Label();
            this.IngredientsPanel = new System.Windows.Forms.Panel();
            this.clbIngredientsOfDish = new System.Windows.Forms.CheckedListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.IngredientsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDishName
            // 
            this.lblDishName.AutoSize = true;
            this.lblDishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDishName.Location = new System.Drawing.Point(133, 9);
            this.lblDishName.Name = "lblDishName";
            this.lblDishName.Size = new System.Drawing.Size(134, 32);
            this.lblDishName.TabIndex = 0;
            this.lblDishName.Text = "שם המנה ";
            // 
            // IngredientsPanel
            // 
            this.IngredientsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IngredientsPanel.Controls.Add(this.clbIngredientsOfDish);
            this.IngredientsPanel.Location = new System.Drawing.Point(12, 56);
            this.IngredientsPanel.Name = "IngredientsPanel";
            this.IngredientsPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IngredientsPanel.Size = new System.Drawing.Size(373, 403);
            this.IngredientsPanel.TabIndex = 1;
            // 
            // clbIngredientsOfDish
            // 
            this.clbIngredientsOfDish.CheckOnClick = true;
            this.clbIngredientsOfDish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbIngredientsOfDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clbIngredientsOfDish.FormattingEnabled = true;
            this.clbIngredientsOfDish.Location = new System.Drawing.Point(0, 0);
            this.clbIngredientsOfDish.Name = "clbIngredientsOfDish";
            this.clbIngredientsOfDish.Size = new System.Drawing.Size(371, 401);
            this.clbIngredientsOfDish.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(13, 475);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(372, 60);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "אישור";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // DishingredentsInOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 547);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.IngredientsPanel);
            this.Controls.Add(this.lblDishName);
            this.Name = "DishingredentsInOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הורדת מרכיבים מהמנה";
            this.Load += new System.EventHandler(this.Dishingredents_Load);
            this.IngredientsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDishName;
        private System.Windows.Forms.Panel IngredientsPanel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckedListBox clbIngredientsOfDish;
    }
}