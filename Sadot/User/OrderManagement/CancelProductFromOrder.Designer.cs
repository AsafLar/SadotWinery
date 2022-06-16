namespace Sadot
{
    partial class CancelProductFromOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbReasonForCancellation = new System.Windows.Forms.RichTextBox();
            this.btnCancelProduct = new System.Windows.Forms.Button();
            this.rbProvided = new System.Windows.Forms.RadioButton();
            this.rbNotProvided = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(167, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "סיבת הביטול";
            // 
            // rtbReasonForCancellation
            // 
            this.rtbReasonForCancellation.Location = new System.Drawing.Point(20, 56);
            this.rtbReasonForCancellation.MaxLength = 200;
            this.rtbReasonForCancellation.Name = "rtbReasonForCancellation";
            this.rtbReasonForCancellation.Size = new System.Drawing.Size(456, 108);
            this.rtbReasonForCancellation.TabIndex = 2;
            this.rtbReasonForCancellation.Text = "";
            // 
            // btnCancelProduct
            // 
            this.btnCancelProduct.Location = new System.Drawing.Point(111, 276);
            this.btnCancelProduct.Name = "btnCancelProduct";
            this.btnCancelProduct.Size = new System.Drawing.Size(274, 56);
            this.btnCancelProduct.TabIndex = 3;
            this.btnCancelProduct.Text = "ביטול מוצר";
            this.btnCancelProduct.UseVisualStyleBackColor = true;
            this.btnCancelProduct.Click += new System.EventHandler(this.btnCancelProduct_Click);
            // 
            // rbProvided
            // 
            this.rbProvided.AutoSize = true;
            this.rbProvided.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbProvided.Location = new System.Drawing.Point(50, 208);
            this.rbProvided.Name = "rbProvided";
            this.rbProvided.Size = new System.Drawing.Size(155, 33);
            this.rbProvided.TabIndex = 7;
            this.rbProvided.Text = "המוצר סופק";
            this.rbProvided.UseVisualStyleBackColor = true;
            // 
            // rbNotProvided
            // 
            this.rbNotProvided.AutoSize = true;
            this.rbNotProvided.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbNotProvided.Location = new System.Drawing.Point(273, 208);
            this.rbNotProvided.Name = "rbNotProvided";
            this.rbNotProvided.Size = new System.Drawing.Size(190, 33);
            this.rbNotProvided.TabIndex = 8;
            this.rbNotProvided.Text = "המוצר לא סופק";
            this.rbNotProvided.UseVisualStyleBackColor = true;
            // 
            // CancelProductFromOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 344);
            this.Controls.Add(this.rbNotProvided);
            this.Controls.Add(this.rbProvided);
            this.Controls.Add(this.btnCancelProduct);
            this.Controls.Add(this.rtbReasonForCancellation);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CancelProductFromOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ביטול מוצר מהזמנה";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbReasonForCancellation;
        private System.Windows.Forms.Button btnCancelProduct;
        private System.Windows.Forms.RadioButton rbProvided;
        private System.Windows.Forms.RadioButton rbNotProvided;
    }
}