namespace TUGASHALIM
{
    partial class FormEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEquipment));
            this.listimage = new System.Windows.Forms.ImageList(this.components);
            this.btnback = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listimage
            // 
            this.listimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listimage.ImageStream")));
            this.listimage.TransparentColor = System.Drawing.Color.Transparent;
            this.listimage.Images.SetKeyName(0, "WEAPON.png");
            this.listimage.Images.SetKeyName(1, "HELM.png");
            this.listimage.Images.SetKeyName(2, "ARMOR.png");
            this.listimage.Images.SetKeyName(3, "BOOTS.png");
            this.listimage.Images.SetKeyName(4, "AUXILLARY.png");
            this.listimage.Images.SetKeyName(5, "Knight.png");
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(1033, 45);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(50, 55);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "X";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(1033, 129);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(50, 55);
            this.savebtn.TabIndex = 1;
            this.savebtn.Text = "V";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1039, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BACK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1039, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SAVE";
            // 
            // FormEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.btnback);
            this.Name = "FormEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList listimage;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

