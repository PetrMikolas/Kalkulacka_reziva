
namespace Kalkulacka {
    partial class Napoveda {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Napoveda));
            this.textNapoveda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textNapoveda
            // 
            this.textNapoveda.BackColor = System.Drawing.Color.White;
            this.textNapoveda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNapoveda.Location = new System.Drawing.Point(12, 12);
            this.textNapoveda.Multiline = true;
            this.textNapoveda.Name = "textNapoveda";
            this.textNapoveda.ReadOnly = true;
            this.textNapoveda.Size = new System.Drawing.Size(802, 527);
            this.textNapoveda.TabIndex = 0;
            this.textNapoveda.TabStop = false;
            this.textNapoveda.Text = resources.GetString("textNapoveda.Text");
            // 
            // Napoveda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 546);
            this.Controls.Add(this.textNapoveda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Napoveda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nápověda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNapoveda;
    }
}