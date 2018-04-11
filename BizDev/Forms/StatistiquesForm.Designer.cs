namespace BizDev.Forms
{
    partial class StatistiquesForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BtnClose = new System.Windows.Forms.Button();
            this.ChaTotal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.TxtP01New = new System.Windows.Forms.TextBox();
            this.TxtT12Abandons = new System.Windows.Forms.TextBox();
            this.TxtT12Conversions = new System.Windows.Forms.TextBox();
            this.TxtT12Contacts = new System.Windows.Forms.TextBox();
            this.TxtT12New = new System.Windows.Forms.TextBox();
            this.TxtT11Abandons = new System.Windows.Forms.TextBox();
            this.TxtT11Conversions = new System.Windows.Forms.TextBox();
            this.TxtT11Contacts = new System.Windows.Forms.TextBox();
            this.TxtT11New = new System.Windows.Forms.TextBox();
            this.TxtT10Abandons = new System.Windows.Forms.TextBox();
            this.TxtT10Conversions = new System.Windows.Forms.TextBox();
            this.TxtT10Contacts = new System.Windows.Forms.TextBox();
            this.TxtT10New = new System.Windows.Forms.TextBox();
            this.TxtT09Abandons = new System.Windows.Forms.TextBox();
            this.TxtT09Conversions = new System.Windows.Forms.TextBox();
            this.TxtT09Contacts = new System.Windows.Forms.TextBox();
            this.TxtT09New = new System.Windows.Forms.TextBox();
            this.TxtT08Abandons = new System.Windows.Forms.TextBox();
            this.TxtT08Conversions = new System.Windows.Forms.TextBox();
            this.TxtT08Contacts = new System.Windows.Forms.TextBox();
            this.TxtT08New = new System.Windows.Forms.TextBox();
            this.TxtT07Abandons = new System.Windows.Forms.TextBox();
            this.TxtT07Conversions = new System.Windows.Forms.TextBox();
            this.TxtT07Contacts = new System.Windows.Forms.TextBox();
            this.TxtT07New = new System.Windows.Forms.TextBox();
            this.TxtT06Abandons = new System.Windows.Forms.TextBox();
            this.TxtT06Conversions = new System.Windows.Forms.TextBox();
            this.TxtT06Contacts = new System.Windows.Forms.TextBox();
            this.TxtT06New = new System.Windows.Forms.TextBox();
            this.TxtT05Abandons = new System.Windows.Forms.TextBox();
            this.TxtT05Conversions = new System.Windows.Forms.TextBox();
            this.TxtT05Contacts = new System.Windows.Forms.TextBox();
            this.TxtT05New = new System.Windows.Forms.TextBox();
            this.TxtT04Abandons = new System.Windows.Forms.TextBox();
            this.TxtT04Conversions = new System.Windows.Forms.TextBox();
            this.TxtT04Contacts = new System.Windows.Forms.TextBox();
            this.TxtT04New = new System.Windows.Forms.TextBox();
            this.TxtT03Abandons = new System.Windows.Forms.TextBox();
            this.TxtT03Conversions = new System.Windows.Forms.TextBox();
            this.TxtT03Contacts = new System.Windows.Forms.TextBox();
            this.TxtT03New = new System.Windows.Forms.TextBox();
            this.TxtT02Abandons = new System.Windows.Forms.TextBox();
            this.TxtT02Conversions = new System.Windows.Forms.TextBox();
            this.TxtT02Contacts = new System.Windows.Forms.TextBox();
            this.TxtT02New = new System.Windows.Forms.TextBox();
            this.TxtT01Abandons = new System.Windows.Forms.TextBox();
            this.TxtT01Conversions = new System.Windows.Forms.TextBox();
            this.TxtT01Contacts = new System.Windows.Forms.TextBox();
            this.TxtT01New = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChaTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(826, 529);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.TabStop = false;
            this.BtnClose.Text = "Fermer";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ChaTotal
            // 
            chartArea2.Name = "ChartArea1";
            this.ChaTotal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChaTotal.Legends.Add(legend2);
            this.ChaTotal.Location = new System.Drawing.Point(17, 201);
            this.ChaTotal.Name = "ChaTotal";
            this.ChaTotal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Prospects";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Contacts";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Conversions";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Abandons";
            this.ChaTotal.Series.Add(series5);
            this.ChaTotal.Series.Add(series6);
            this.ChaTotal.Series.Add(series7);
            this.ChaTotal.Series.Add(series8);
            this.ChaTotal.Size = new System.Drawing.Size(1193, 322);
            this.ChaTotal.TabIndex = 6;
            this.ChaTotal.TabStop = false;
            // 
            // textBox33
            // 
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox33.Location = new System.Drawing.Point(617, 46);
            this.textBox33.Name = "textBox33";
            this.textBox33.ReadOnly = true;
            this.textBox33.Size = new System.Drawing.Size(48, 20);
            this.textBox33.TabIndex = 124;
            this.textBox33.TabStop = false;
            this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox32
            // 
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox32.Location = new System.Drawing.Point(525, 46);
            this.textBox32.Name = "textBox32";
            this.textBox32.ReadOnly = true;
            this.textBox32.Size = new System.Drawing.Size(48, 20);
            this.textBox32.TabIndex = 123;
            this.textBox32.TabStop = false;
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox31
            // 
            this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox31.Location = new System.Drawing.Point(433, 46);
            this.textBox31.Name = "textBox31";
            this.textBox31.ReadOnly = true;
            this.textBox31.Size = new System.Drawing.Size(48, 20);
            this.textBox31.TabIndex = 122;
            this.textBox31.TabStop = false;
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox30
            // 
            this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox30.Location = new System.Drawing.Point(341, 46);
            this.textBox30.Name = "textBox30";
            this.textBox30.ReadOnly = true;
            this.textBox30.Size = new System.Drawing.Size(48, 20);
            this.textBox30.TabIndex = 121;
            this.textBox30.TabStop = false;
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox29
            // 
            this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox29.Location = new System.Drawing.Point(249, 46);
            this.textBox29.Name = "textBox29";
            this.textBox29.ReadOnly = true;
            this.textBox29.Size = new System.Drawing.Size(48, 20);
            this.textBox29.TabIndex = 120;
            this.textBox29.TabStop = false;
            this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtP01New
            // 
            this.TxtP01New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtP01New.Location = new System.Drawing.Point(157, 46);
            this.TxtP01New.Name = "TxtP01New";
            this.TxtP01New.ReadOnly = true;
            this.TxtP01New.Size = new System.Drawing.Size(48, 20);
            this.TxtP01New.TabIndex = 119;
            this.TxtP01New.TabStop = false;
            this.TxtP01New.Text = "100.00 %";
            this.TxtP01New.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtT12Abandons
            // 
            this.TxtT12Abandons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT12Abandons.Location = new System.Drawing.Point(1127, 125);
            this.TxtT12Abandons.Name = "TxtT12Abandons";
            this.TxtT12Abandons.ReadOnly = true;
            this.TxtT12Abandons.Size = new System.Drawing.Size(40, 20);
            this.TxtT12Abandons.TabIndex = 118;
            this.TxtT12Abandons.TabStop = false;
            this.TxtT12Abandons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT12Conversions
            // 
            this.TxtT12Conversions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT12Conversions.Location = new System.Drawing.Point(1127, 99);
            this.TxtT12Conversions.Name = "TxtT12Conversions";
            this.TxtT12Conversions.ReadOnly = true;
            this.TxtT12Conversions.Size = new System.Drawing.Size(40, 20);
            this.TxtT12Conversions.TabIndex = 117;
            this.TxtT12Conversions.TabStop = false;
            this.TxtT12Conversions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT12Contacts
            // 
            this.TxtT12Contacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT12Contacts.Location = new System.Drawing.Point(1127, 73);
            this.TxtT12Contacts.Name = "TxtT12Contacts";
            this.TxtT12Contacts.ReadOnly = true;
            this.TxtT12Contacts.Size = new System.Drawing.Size(40, 20);
            this.TxtT12Contacts.TabIndex = 116;
            this.TxtT12Contacts.TabStop = false;
            this.TxtT12Contacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT12New
            // 
            this.TxtT12New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT12New.Location = new System.Drawing.Point(1127, 46);
            this.TxtT12New.Name = "TxtT12New";
            this.TxtT12New.ReadOnly = true;
            this.TxtT12New.Size = new System.Drawing.Size(40, 20);
            this.TxtT12New.TabIndex = 115;
            this.TxtT12New.TabStop = false;
            this.TxtT12New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT11Abandons
            // 
            this.TxtT11Abandons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT11Abandons.Location = new System.Drawing.Point(1035, 125);
            this.TxtT11Abandons.Name = "TxtT11Abandons";
            this.TxtT11Abandons.ReadOnly = true;
            this.TxtT11Abandons.Size = new System.Drawing.Size(40, 20);
            this.TxtT11Abandons.TabIndex = 114;
            this.TxtT11Abandons.TabStop = false;
            this.TxtT11Abandons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT11Conversions
            // 
            this.TxtT11Conversions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT11Conversions.Location = new System.Drawing.Point(1035, 99);
            this.TxtT11Conversions.Name = "TxtT11Conversions";
            this.TxtT11Conversions.ReadOnly = true;
            this.TxtT11Conversions.Size = new System.Drawing.Size(40, 20);
            this.TxtT11Conversions.TabIndex = 113;
            this.TxtT11Conversions.TabStop = false;
            this.TxtT11Conversions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT11Contacts
            // 
            this.TxtT11Contacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT11Contacts.Location = new System.Drawing.Point(1035, 73);
            this.TxtT11Contacts.Name = "TxtT11Contacts";
            this.TxtT11Contacts.ReadOnly = true;
            this.TxtT11Contacts.Size = new System.Drawing.Size(40, 20);
            this.TxtT11Contacts.TabIndex = 112;
            this.TxtT11Contacts.TabStop = false;
            this.TxtT11Contacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT11New
            // 
            this.TxtT11New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT11New.Location = new System.Drawing.Point(1035, 46);
            this.TxtT11New.Name = "TxtT11New";
            this.TxtT11New.ReadOnly = true;
            this.TxtT11New.Size = new System.Drawing.Size(40, 20);
            this.TxtT11New.TabIndex = 111;
            this.TxtT11New.TabStop = false;
            this.TxtT11New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT10Abandons
            // 
            this.TxtT10Abandons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT10Abandons.Location = new System.Drawing.Point(943, 125);
            this.TxtT10Abandons.Name = "TxtT10Abandons";
            this.TxtT10Abandons.ReadOnly = true;
            this.TxtT10Abandons.Size = new System.Drawing.Size(40, 20);
            this.TxtT10Abandons.TabIndex = 110;
            this.TxtT10Abandons.TabStop = false;
            this.TxtT10Abandons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT10Conversions
            // 
            this.TxtT10Conversions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT10Conversions.Location = new System.Drawing.Point(943, 99);
            this.TxtT10Conversions.Name = "TxtT10Conversions";
            this.TxtT10Conversions.ReadOnly = true;
            this.TxtT10Conversions.Size = new System.Drawing.Size(40, 20);
            this.TxtT10Conversions.TabIndex = 109;
            this.TxtT10Conversions.TabStop = false;
            this.TxtT10Conversions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT10Contacts
            // 
            this.TxtT10Contacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT10Contacts.Location = new System.Drawing.Point(943, 73);
            this.TxtT10Contacts.Name = "TxtT10Contacts";
            this.TxtT10Contacts.ReadOnly = true;
            this.TxtT10Contacts.Size = new System.Drawing.Size(40, 20);
            this.TxtT10Contacts.TabIndex = 108;
            this.TxtT10Contacts.TabStop = false;
            this.TxtT10Contacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT10New
            // 
            this.TxtT10New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT10New.Location = new System.Drawing.Point(943, 46);
            this.TxtT10New.Name = "TxtT10New";
            this.TxtT10New.ReadOnly = true;
            this.TxtT10New.Size = new System.Drawing.Size(40, 20);
            this.TxtT10New.TabIndex = 107;
            this.TxtT10New.TabStop = false;
            this.TxtT10New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT09Abandons
            // 
            this.TxtT09Abandons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT09Abandons.Location = new System.Drawing.Point(852, 125);
            this.TxtT09Abandons.Name = "TxtT09Abandons";
            this.TxtT09Abandons.ReadOnly = true;
            this.TxtT09Abandons.Size = new System.Drawing.Size(40, 20);
            this.TxtT09Abandons.TabIndex = 106;
            this.TxtT09Abandons.TabStop = false;
            this.TxtT09Abandons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT09Conversions
            // 
            this.TxtT09Conversions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT09Conversions.Location = new System.Drawing.Point(852, 99);
            this.TxtT09Conversions.Name = "TxtT09Conversions";
            this.TxtT09Conversions.ReadOnly = true;
            this.TxtT09Conversions.Size = new System.Drawing.Size(40, 20);
            this.TxtT09Conversions.TabIndex = 105;
            this.TxtT09Conversions.TabStop = false;
            this.TxtT09Conversions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT09Contacts
            // 
            this.TxtT09Contacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT09Contacts.Location = new System.Drawing.Point(852, 73);
            this.TxtT09Contacts.Name = "TxtT09Contacts";
            this.TxtT09Contacts.ReadOnly = true;
            this.TxtT09Contacts.Size = new System.Drawing.Size(40, 20);
            this.TxtT09Contacts.TabIndex = 104;
            this.TxtT09Contacts.TabStop = false;
            this.TxtT09Contacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT09New
            // 
            this.TxtT09New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT09New.Location = new System.Drawing.Point(852, 46);
            this.TxtT09New.Name = "TxtT09New";
            this.TxtT09New.ReadOnly = true;
            this.TxtT09New.Size = new System.Drawing.Size(40, 20);
            this.TxtT09New.TabIndex = 103;
            this.TxtT09New.TabStop = false;
            this.TxtT09New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT08Abandons
            // 
            this.TxtT08Abandons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT08Abandons.Location = new System.Drawing.Point(760, 125);
            this.TxtT08Abandons.Name = "TxtT08Abandons";
            this.TxtT08Abandons.ReadOnly = true;
            this.TxtT08Abandons.Size = new System.Drawing.Size(40, 20);
            this.TxtT08Abandons.TabIndex = 102;
            this.TxtT08Abandons.TabStop = false;
            this.TxtT08Abandons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT08Conversions
            // 
            this.TxtT08Conversions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT08Conversions.Location = new System.Drawing.Point(760, 99);
            this.TxtT08Conversions.Name = "TxtT08Conversions";
            this.TxtT08Conversions.ReadOnly = true;
            this.TxtT08Conversions.Size = new System.Drawing.Size(40, 20);
            this.TxtT08Conversions.TabIndex = 101;
            this.TxtT08Conversions.TabStop = false;
            this.TxtT08Conversions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT08Contacts
            // 
            this.TxtT08Contacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT08Contacts.Location = new System.Drawing.Point(760, 73);
            this.TxtT08Contacts.Name = "TxtT08Contacts";
            this.TxtT08Contacts.ReadOnly = true;
            this.TxtT08Contacts.Size = new System.Drawing.Size(40, 20);
            this.TxtT08Contacts.TabIndex = 100;
            this.TxtT08Contacts.TabStop = false;
            this.TxtT08Contacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT08New
            // 
            this.TxtT08New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT08New.Location = new System.Drawing.Point(760, 46);
            this.TxtT08New.Name = "TxtT08New";
            this.TxtT08New.ReadOnly = true;
            this.TxtT08New.Size = new System.Drawing.Size(40, 20);
            this.TxtT08New.TabIndex = 99;
            this.TxtT08New.TabStop = false;
            this.TxtT08New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT07Abandons
            // 
            this.TxtT07Abandons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT07Abandons.Location = new System.Drawing.Point(668, 125);
            this.TxtT07Abandons.Name = "TxtT07Abandons";
            this.TxtT07Abandons.ReadOnly = true;
            this.TxtT07Abandons.Size = new System.Drawing.Size(40, 20);
            this.TxtT07Abandons.TabIndex = 98;
            this.TxtT07Abandons.TabStop = false;
            this.TxtT07Abandons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT07Conversions
            // 
            this.TxtT07Conversions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT07Conversions.Location = new System.Drawing.Point(668, 99);
            this.TxtT07Conversions.Name = "TxtT07Conversions";
            this.TxtT07Conversions.ReadOnly = true;
            this.TxtT07Conversions.Size = new System.Drawing.Size(40, 20);
            this.TxtT07Conversions.TabIndex = 97;
            this.TxtT07Conversions.TabStop = false;
            this.TxtT07Conversions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT07Contacts
            // 
            this.TxtT07Contacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT07Contacts.Location = new System.Drawing.Point(668, 73);
            this.TxtT07Contacts.Name = "TxtT07Contacts";
            this.TxtT07Contacts.ReadOnly = true;
            this.TxtT07Contacts.Size = new System.Drawing.Size(40, 20);
            this.TxtT07Contacts.TabIndex = 96;
            this.TxtT07Contacts.TabStop = false;
            this.TxtT07Contacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT07New
            // 
            this.TxtT07New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT07New.Location = new System.Drawing.Point(668, 46);
            this.TxtT07New.Name = "TxtT07New";
            this.TxtT07New.ReadOnly = true;
            this.TxtT07New.Size = new System.Drawing.Size(40, 20);
            this.TxtT07New.TabIndex = 95;
            this.TxtT07New.TabStop = false;
            this.TxtT07New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT06Abandons
            // 
            this.TxtT06Abandons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT06Abandons.Location = new System.Drawing.Point(576, 125);
            this.TxtT06Abandons.Name = "TxtT06Abandons";
            this.TxtT06Abandons.ReadOnly = true;
            this.TxtT06Abandons.Size = new System.Drawing.Size(40, 20);
            this.TxtT06Abandons.TabIndex = 94;
            this.TxtT06Abandons.TabStop = false;
            this.TxtT06Abandons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT06Conversions
            // 
            this.TxtT06Conversions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT06Conversions.Location = new System.Drawing.Point(576, 99);
            this.TxtT06Conversions.Name = "TxtT06Conversions";
            this.TxtT06Conversions.ReadOnly = true;
            this.TxtT06Conversions.Size = new System.Drawing.Size(40, 20);
            this.TxtT06Conversions.TabIndex = 93;
            this.TxtT06Conversions.TabStop = false;
            this.TxtT06Conversions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT06Contacts
            // 
            this.TxtT06Contacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT06Contacts.Location = new System.Drawing.Point(576, 73);
            this.TxtT06Contacts.Name = "TxtT06Contacts";
            this.TxtT06Contacts.ReadOnly = true;
            this.TxtT06Contacts.Size = new System.Drawing.Size(40, 20);
            this.TxtT06Contacts.TabIndex = 92;
            this.TxtT06Contacts.TabStop = false;
            this.TxtT06Contacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT06New
            // 
            this.TxtT06New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT06New.Location = new System.Drawing.Point(576, 46);
            this.TxtT06New.Name = "TxtT06New";
            this.TxtT06New.ReadOnly = true;
            this.TxtT06New.Size = new System.Drawing.Size(40, 20);
            this.TxtT06New.TabIndex = 91;
            this.TxtT06New.TabStop = false;
            this.TxtT06New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT05Abandons
            // 
            this.TxtT05Abandons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT05Abandons.Location = new System.Drawing.Point(484, 125);
            this.TxtT05Abandons.Name = "TxtT05Abandons";
            this.TxtT05Abandons.ReadOnly = true;
            this.TxtT05Abandons.Size = new System.Drawing.Size(40, 20);
            this.TxtT05Abandons.TabIndex = 90;
            this.TxtT05Abandons.TabStop = false;
            this.TxtT05Abandons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT05Conversions
            // 
            this.TxtT05Conversions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT05Conversions.Location = new System.Drawing.Point(484, 99);
            this.TxtT05Conversions.Name = "TxtT05Conversions";
            this.TxtT05Conversions.ReadOnly = true;
            this.TxtT05Conversions.Size = new System.Drawing.Size(40, 20);
            this.TxtT05Conversions.TabIndex = 89;
            this.TxtT05Conversions.TabStop = false;
            this.TxtT05Conversions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT05Contacts
            // 
            this.TxtT05Contacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT05Contacts.Location = new System.Drawing.Point(484, 73);
            this.TxtT05Contacts.Name = "TxtT05Contacts";
            this.TxtT05Contacts.ReadOnly = true;
            this.TxtT05Contacts.Size = new System.Drawing.Size(40, 20);
            this.TxtT05Contacts.TabIndex = 88;
            this.TxtT05Contacts.TabStop = false;
            this.TxtT05Contacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT05New
            // 
            this.TxtT05New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT05New.Location = new System.Drawing.Point(484, 46);
            this.TxtT05New.Name = "TxtT05New";
            this.TxtT05New.ReadOnly = true;
            this.TxtT05New.Size = new System.Drawing.Size(40, 20);
            this.TxtT05New.TabIndex = 87;
            this.TxtT05New.TabStop = false;
            this.TxtT05New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT04Abandons
            // 
            this.TxtT04Abandons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT04Abandons.Location = new System.Drawing.Point(392, 125);
            this.TxtT04Abandons.Name = "TxtT04Abandons";
            this.TxtT04Abandons.ReadOnly = true;
            this.TxtT04Abandons.Size = new System.Drawing.Size(40, 20);
            this.TxtT04Abandons.TabIndex = 86;
            this.TxtT04Abandons.TabStop = false;
            this.TxtT04Abandons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT04Conversions
            // 
            this.TxtT04Conversions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT04Conversions.Location = new System.Drawing.Point(392, 99);
            this.TxtT04Conversions.Name = "TxtT04Conversions";
            this.TxtT04Conversions.ReadOnly = true;
            this.TxtT04Conversions.Size = new System.Drawing.Size(40, 20);
            this.TxtT04Conversions.TabIndex = 85;
            this.TxtT04Conversions.TabStop = false;
            this.TxtT04Conversions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT04Contacts
            // 
            this.TxtT04Contacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT04Contacts.Location = new System.Drawing.Point(392, 73);
            this.TxtT04Contacts.Name = "TxtT04Contacts";
            this.TxtT04Contacts.ReadOnly = true;
            this.TxtT04Contacts.Size = new System.Drawing.Size(40, 20);
            this.TxtT04Contacts.TabIndex = 84;
            this.TxtT04Contacts.TabStop = false;
            this.TxtT04Contacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT04New
            // 
            this.TxtT04New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT04New.Location = new System.Drawing.Point(392, 46);
            this.TxtT04New.Name = "TxtT04New";
            this.TxtT04New.ReadOnly = true;
            this.TxtT04New.Size = new System.Drawing.Size(40, 20);
            this.TxtT04New.TabIndex = 83;
            this.TxtT04New.TabStop = false;
            this.TxtT04New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT03Abandons
            // 
            this.TxtT03Abandons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT03Abandons.Location = new System.Drawing.Point(300, 125);
            this.TxtT03Abandons.Name = "TxtT03Abandons";
            this.TxtT03Abandons.ReadOnly = true;
            this.TxtT03Abandons.Size = new System.Drawing.Size(40, 20);
            this.TxtT03Abandons.TabIndex = 82;
            this.TxtT03Abandons.TabStop = false;
            this.TxtT03Abandons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT03Conversions
            // 
            this.TxtT03Conversions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT03Conversions.Location = new System.Drawing.Point(300, 99);
            this.TxtT03Conversions.Name = "TxtT03Conversions";
            this.TxtT03Conversions.ReadOnly = true;
            this.TxtT03Conversions.Size = new System.Drawing.Size(40, 20);
            this.TxtT03Conversions.TabIndex = 81;
            this.TxtT03Conversions.TabStop = false;
            this.TxtT03Conversions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT03Contacts
            // 
            this.TxtT03Contacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT03Contacts.Location = new System.Drawing.Point(300, 73);
            this.TxtT03Contacts.Name = "TxtT03Contacts";
            this.TxtT03Contacts.ReadOnly = true;
            this.TxtT03Contacts.Size = new System.Drawing.Size(40, 20);
            this.TxtT03Contacts.TabIndex = 80;
            this.TxtT03Contacts.TabStop = false;
            this.TxtT03Contacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT03New
            // 
            this.TxtT03New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT03New.Location = new System.Drawing.Point(300, 46);
            this.TxtT03New.Name = "TxtT03New";
            this.TxtT03New.ReadOnly = true;
            this.TxtT03New.Size = new System.Drawing.Size(40, 20);
            this.TxtT03New.TabIndex = 79;
            this.TxtT03New.TabStop = false;
            this.TxtT03New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT02Abandons
            // 
            this.TxtT02Abandons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT02Abandons.Location = new System.Drawing.Point(208, 125);
            this.TxtT02Abandons.Name = "TxtT02Abandons";
            this.TxtT02Abandons.ReadOnly = true;
            this.TxtT02Abandons.Size = new System.Drawing.Size(40, 20);
            this.TxtT02Abandons.TabIndex = 78;
            this.TxtT02Abandons.TabStop = false;
            this.TxtT02Abandons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT02Conversions
            // 
            this.TxtT02Conversions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT02Conversions.Location = new System.Drawing.Point(208, 99);
            this.TxtT02Conversions.Name = "TxtT02Conversions";
            this.TxtT02Conversions.ReadOnly = true;
            this.TxtT02Conversions.Size = new System.Drawing.Size(40, 20);
            this.TxtT02Conversions.TabIndex = 77;
            this.TxtT02Conversions.TabStop = false;
            this.TxtT02Conversions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT02Contacts
            // 
            this.TxtT02Contacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT02Contacts.Location = new System.Drawing.Point(208, 73);
            this.TxtT02Contacts.Name = "TxtT02Contacts";
            this.TxtT02Contacts.ReadOnly = true;
            this.TxtT02Contacts.Size = new System.Drawing.Size(40, 20);
            this.TxtT02Contacts.TabIndex = 76;
            this.TxtT02Contacts.TabStop = false;
            this.TxtT02Contacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT02New
            // 
            this.TxtT02New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT02New.Location = new System.Drawing.Point(208, 46);
            this.TxtT02New.Name = "TxtT02New";
            this.TxtT02New.ReadOnly = true;
            this.TxtT02New.Size = new System.Drawing.Size(40, 20);
            this.TxtT02New.TabIndex = 75;
            this.TxtT02New.TabStop = false;
            this.TxtT02New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT01Abandons
            // 
            this.TxtT01Abandons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT01Abandons.Location = new System.Drawing.Point(116, 125);
            this.TxtT01Abandons.Name = "TxtT01Abandons";
            this.TxtT01Abandons.ReadOnly = true;
            this.TxtT01Abandons.Size = new System.Drawing.Size(40, 20);
            this.TxtT01Abandons.TabIndex = 74;
            this.TxtT01Abandons.TabStop = false;
            this.TxtT01Abandons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT01Conversions
            // 
            this.TxtT01Conversions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT01Conversions.Location = new System.Drawing.Point(116, 99);
            this.TxtT01Conversions.Name = "TxtT01Conversions";
            this.TxtT01Conversions.ReadOnly = true;
            this.TxtT01Conversions.Size = new System.Drawing.Size(40, 20);
            this.TxtT01Conversions.TabIndex = 73;
            this.TxtT01Conversions.TabStop = false;
            this.TxtT01Conversions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT01Contacts
            // 
            this.TxtT01Contacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT01Contacts.Location = new System.Drawing.Point(116, 73);
            this.TxtT01Contacts.Name = "TxtT01Contacts";
            this.TxtT01Contacts.ReadOnly = true;
            this.TxtT01Contacts.Size = new System.Drawing.Size(40, 20);
            this.TxtT01Contacts.TabIndex = 72;
            this.TxtT01Contacts.TabStop = false;
            this.TxtT01Contacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT01New
            // 
            this.TxtT01New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT01New.Location = new System.Drawing.Point(116, 46);
            this.TxtT01New.Name = "TxtT01New";
            this.TxtT01New.ReadOnly = true;
            this.TxtT01New.Size = new System.Drawing.Size(40, 20);
            this.TxtT01New.TabIndex = 71;
            this.TxtT01New.TabStop = false;
            this.TxtT01New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Prospects :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Abandons :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Prises de contacts :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Conversions :";
            // 
            // textBox34
            // 
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox34.Location = new System.Drawing.Point(709, 46);
            this.textBox34.Name = "textBox34";
            this.textBox34.ReadOnly = true;
            this.textBox34.Size = new System.Drawing.Size(48, 20);
            this.textBox34.TabIndex = 125;
            this.textBox34.TabStop = false;
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox35
            // 
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox35.Location = new System.Drawing.Point(801, 46);
            this.textBox35.Name = "textBox35";
            this.textBox35.ReadOnly = true;
            this.textBox35.Size = new System.Drawing.Size(48, 20);
            this.textBox35.TabIndex = 126;
            this.textBox35.TabStop = false;
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox36
            // 
            this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox36.Location = new System.Drawing.Point(893, 46);
            this.textBox36.Name = "textBox36";
            this.textBox36.ReadOnly = true;
            this.textBox36.Size = new System.Drawing.Size(48, 20);
            this.textBox36.TabIndex = 127;
            this.textBox36.TabStop = false;
            this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox37
            // 
            this.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox37.Location = new System.Drawing.Point(984, 46);
            this.textBox37.Name = "textBox37";
            this.textBox37.ReadOnly = true;
            this.textBox37.Size = new System.Drawing.Size(48, 20);
            this.textBox37.TabIndex = 128;
            this.textBox37.TabStop = false;
            this.textBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox38
            // 
            this.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox38.Location = new System.Drawing.Point(1076, 46);
            this.textBox38.Name = "textBox38";
            this.textBox38.ReadOnly = true;
            this.textBox38.Size = new System.Drawing.Size(48, 20);
            this.textBox38.TabIndex = 129;
            this.textBox38.TabStop = false;
            this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox39
            // 
            this.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox39.Location = new System.Drawing.Point(1168, 46);
            this.textBox39.Name = "textBox39";
            this.textBox39.ReadOnly = true;
            this.textBox39.Size = new System.Drawing.Size(48, 20);
            this.textBox39.TabIndex = 130;
            this.textBox39.TabStop = false;
            this.textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StatistiquesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(1229, 576);
            this.Controls.Add(this.textBox39);
            this.Controls.Add(this.textBox38);
            this.Controls.Add(this.textBox37);
            this.Controls.Add(this.textBox36);
            this.Controls.Add(this.textBox35);
            this.Controls.Add(this.textBox34);
            this.Controls.Add(this.textBox33);
            this.Controls.Add(this.textBox32);
            this.Controls.Add(this.textBox31);
            this.Controls.Add(this.textBox30);
            this.Controls.Add(this.textBox29);
            this.Controls.Add(this.TxtP01New);
            this.Controls.Add(this.TxtT12Abandons);
            this.Controls.Add(this.TxtT12Conversions);
            this.Controls.Add(this.TxtT12Contacts);
            this.Controls.Add(this.TxtT12New);
            this.Controls.Add(this.TxtT11Abandons);
            this.Controls.Add(this.TxtT11Conversions);
            this.Controls.Add(this.TxtT11Contacts);
            this.Controls.Add(this.TxtT11New);
            this.Controls.Add(this.TxtT10Abandons);
            this.Controls.Add(this.TxtT10Conversions);
            this.Controls.Add(this.TxtT10Contacts);
            this.Controls.Add(this.TxtT10New);
            this.Controls.Add(this.TxtT09Abandons);
            this.Controls.Add(this.TxtT09Conversions);
            this.Controls.Add(this.TxtT09Contacts);
            this.Controls.Add(this.TxtT09New);
            this.Controls.Add(this.TxtT08Abandons);
            this.Controls.Add(this.TxtT08Conversions);
            this.Controls.Add(this.TxtT08Contacts);
            this.Controls.Add(this.TxtT08New);
            this.Controls.Add(this.TxtT07Abandons);
            this.Controls.Add(this.TxtT07Conversions);
            this.Controls.Add(this.TxtT07Contacts);
            this.Controls.Add(this.TxtT07New);
            this.Controls.Add(this.TxtT06Abandons);
            this.Controls.Add(this.TxtT06Conversions);
            this.Controls.Add(this.TxtT06Contacts);
            this.Controls.Add(this.TxtT06New);
            this.Controls.Add(this.TxtT05Abandons);
            this.Controls.Add(this.TxtT05Conversions);
            this.Controls.Add(this.TxtT05Contacts);
            this.Controls.Add(this.TxtT05New);
            this.Controls.Add(this.TxtT04Abandons);
            this.Controls.Add(this.TxtT04Conversions);
            this.Controls.Add(this.TxtT04Contacts);
            this.Controls.Add(this.TxtT04New);
            this.Controls.Add(this.TxtT03Abandons);
            this.Controls.Add(this.TxtT03Conversions);
            this.Controls.Add(this.TxtT03Contacts);
            this.Controls.Add(this.TxtT03New);
            this.Controls.Add(this.TxtT02Abandons);
            this.Controls.Add(this.TxtT02Conversions);
            this.Controls.Add(this.TxtT02Contacts);
            this.Controls.Add(this.TxtT02New);
            this.Controls.Add(this.TxtT01Abandons);
            this.Controls.Add(this.TxtT01Conversions);
            this.Controls.Add(this.TxtT01Contacts);
            this.Controls.Add(this.TxtT01New);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChaTotal);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatistiquesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.StatistiquesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChaTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChaTotal;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox TxtP01New;
        private System.Windows.Forms.TextBox TxtT12Abandons;
        private System.Windows.Forms.TextBox TxtT12Conversions;
        private System.Windows.Forms.TextBox TxtT12Contacts;
        private System.Windows.Forms.TextBox TxtT12New;
        private System.Windows.Forms.TextBox TxtT11Abandons;
        private System.Windows.Forms.TextBox TxtT11Conversions;
        private System.Windows.Forms.TextBox TxtT11Contacts;
        private System.Windows.Forms.TextBox TxtT11New;
        private System.Windows.Forms.TextBox TxtT10Abandons;
        private System.Windows.Forms.TextBox TxtT10Conversions;
        private System.Windows.Forms.TextBox TxtT10Contacts;
        private System.Windows.Forms.TextBox TxtT10New;
        private System.Windows.Forms.TextBox TxtT09Abandons;
        private System.Windows.Forms.TextBox TxtT09Conversions;
        private System.Windows.Forms.TextBox TxtT09Contacts;
        private System.Windows.Forms.TextBox TxtT09New;
        private System.Windows.Forms.TextBox TxtT08Abandons;
        private System.Windows.Forms.TextBox TxtT08Conversions;
        private System.Windows.Forms.TextBox TxtT08Contacts;
        private System.Windows.Forms.TextBox TxtT08New;
        private System.Windows.Forms.TextBox TxtT07Abandons;
        private System.Windows.Forms.TextBox TxtT07Conversions;
        private System.Windows.Forms.TextBox TxtT07Contacts;
        private System.Windows.Forms.TextBox TxtT07New;
        private System.Windows.Forms.TextBox TxtT06Abandons;
        private System.Windows.Forms.TextBox TxtT06Conversions;
        private System.Windows.Forms.TextBox TxtT06Contacts;
        private System.Windows.Forms.TextBox TxtT06New;
        private System.Windows.Forms.TextBox TxtT05Abandons;
        private System.Windows.Forms.TextBox TxtT05Conversions;
        private System.Windows.Forms.TextBox TxtT05Contacts;
        private System.Windows.Forms.TextBox TxtT05New;
        private System.Windows.Forms.TextBox TxtT04Abandons;
        private System.Windows.Forms.TextBox TxtT04Conversions;
        private System.Windows.Forms.TextBox TxtT04Contacts;
        private System.Windows.Forms.TextBox TxtT04New;
        private System.Windows.Forms.TextBox TxtT03Abandons;
        private System.Windows.Forms.TextBox TxtT03Conversions;
        private System.Windows.Forms.TextBox TxtT03Contacts;
        private System.Windows.Forms.TextBox TxtT03New;
        private System.Windows.Forms.TextBox TxtT02Abandons;
        private System.Windows.Forms.TextBox TxtT02Conversions;
        private System.Windows.Forms.TextBox TxtT02Contacts;
        private System.Windows.Forms.TextBox TxtT02New;
        private System.Windows.Forms.TextBox TxtT01Abandons;
        private System.Windows.Forms.TextBox TxtT01Conversions;
        private System.Windows.Forms.TextBox TxtT01Contacts;
        private System.Windows.Forms.TextBox TxtT01New;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox39;
    }
}