
namespace Projekt1
{
    partial class VehicleTypeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.BackgroundImage = global::Projekt1.Properties.Resources.car;
            this.Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button.Location = new System.Drawing.Point(10, 10);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(80, 80);
            this.Button.TabIndex = 0;
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // FigureTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button);
            this.Name = "VehicleTypeControl";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button;
    }
}
