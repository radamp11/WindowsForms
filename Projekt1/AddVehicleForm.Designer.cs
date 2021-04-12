
namespace Projekt1
{
    partial class AddVehicleForm
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
            this.brandLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.brand = new System.Windows.Forms.TextBox();
            this.maxSpeed = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.productionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.typeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProviderSpeed = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBrand = new System.Windows.Forms.ErrorProvider(this.components);
            this.vehicleTypeControl2 = new Projekt1.VehicleTypeControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(2, 0);
            this.brandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(67, 13);
            this.brandLabel.TabIndex = 0;
            this.brandLabel.Text = "Brand name:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(2, 55);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(62, 13);
            this.speedLabel.TabIndex = 1;
            this.speedLabel.Text = "Max speed:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 266);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // brand
            // 
            this.brand.Location = new System.Drawing.Point(76, 2);
            this.brand.Margin = new System.Windows.Forms.Padding(2);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(214, 20);
            this.brand.TabIndex = 3;
            this.brand.Validating += new System.ComponentModel.CancelEventHandler(this.brand_validating);
            // 
            // maxSpeed
            // 
            this.maxSpeed.Location = new System.Drawing.Point(76, 57);
            this.maxSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.maxSpeed.Name = "maxSpeed";
            this.maxSpeed.Size = new System.Drawing.Size(214, 20);
            this.maxSpeed.TabIndex = 4;
            this.maxSpeed.Validating += new System.ComponentModel.CancelEventHandler(this.speed_validating);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(2, 113);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(61, 26);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Production date:";
            // 
            // productionDatePicker
            // 
            this.productionDatePicker.Location = new System.Drawing.Point(77, 116);
            this.productionDatePicker.Name = "productionDatePicker";
            this.productionDatePicker.Size = new System.Drawing.Size(210, 20);
            this.productionDatePicker.TabIndex = 12;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(3, 173);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 14;
            this.typeLabel.Text = "Type:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.53192F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.46809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Controls.Add(this.brandLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.vehicleTypeControl2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.typeLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.brand, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.speedLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.productionDatePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.maxSpeed, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.64865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.35135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 298);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // errorProviderSpeed
            // 
            this.errorProviderSpeed.ContainerControl = this;
            // 
            // errorProviderBrand
            // 
            this.errorProviderBrand.ContainerControl = this;
            // 
            // vehicleTypeControl2
            // 
            this.vehicleTypeControl2.Location = new System.Drawing.Point(76, 175);
            this.vehicleTypeControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vehicleTypeControl2.Name = "vehicleTypeControl2";
            this.vehicleTypeControl2.Size = new System.Drawing.Size(75, 81);
            this.vehicleTypeControl2.TabIndex = 13;
            this.vehicleTypeControl2.vehicleType = Projekt1.VehicleType.Car;
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddVehicleForm";
            this.Text = "AddVehicleForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBrand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.TextBox maxSpeed;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker productionDatePicker;
        private VehicleTypeControl vehicleTypeControl2;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ErrorProvider errorProviderSpeed;
        private System.Windows.Forms.ErrorProvider errorProviderBrand;
    }
}