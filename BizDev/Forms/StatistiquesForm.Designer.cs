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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BtnClose = new System.Windows.Forms.Button();
            this.ChaTotal = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtTOTAbandons = new System.Windows.Forms.TextBox();
            this.TxtTOTConversions = new System.Windows.Forms.TextBox();
            this.TxtTOTContacts = new System.Windows.Forms.TextBox();
            this.TxtTOTNew = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChaTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(1048, 529);
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
            chartArea1.Name = "ChartArea1";
            this.ChaTotal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChaTotal.Legends.Add(legend1);
            this.ChaTotal.Location = new System.Drawing.Point(17, 201);
            this.ChaTotal.Name = "ChaTotal";
            this.ChaTotal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Prospects";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Contacts";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Conversions";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Abandons";
            this.ChaTotal.Series.Add(series1);
            this.ChaTotal.Series.Add(series2);
            this.ChaTotal.Series.Add(series3);
            this.ChaTotal.Series.Add(series4);
            this.ChaTotal.Size = new System.Drawing.Size(1106, 322);
            this.ChaTotal.TabIndex = 6;
            this.ChaTotal.TabStop = false;
            // 
            // TxtT12Abandons
            // 
            this.TxtT12Abandons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT12Abandons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT12Abandons.Location = new System.Drawing.Point(963, 125);
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
            this.TxtT12Conversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT12Conversions.Location = new System.Drawing.Point(963, 99);
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
            this.TxtT12Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT12Contacts.Location = new System.Drawing.Point(963, 73);
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
            this.TxtT12New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT12New.Location = new System.Drawing.Point(963, 46);
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
            this.TxtT11Abandons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT11Abandons.Location = new System.Drawing.Point(886, 125);
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
            this.TxtT11Conversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT11Conversions.Location = new System.Drawing.Point(886, 99);
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
            this.TxtT11Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT11Contacts.Location = new System.Drawing.Point(886, 73);
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
            this.TxtT11New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT11New.Location = new System.Drawing.Point(886, 46);
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
            this.TxtT10Abandons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT10Abandons.Location = new System.Drawing.Point(809, 125);
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
            this.TxtT10Conversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT10Conversions.Location = new System.Drawing.Point(809, 99);
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
            this.TxtT10Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT10Contacts.Location = new System.Drawing.Point(809, 73);
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
            this.TxtT10New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT10New.Location = new System.Drawing.Point(809, 46);
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
            this.TxtT09Abandons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT09Abandons.Location = new System.Drawing.Point(732, 125);
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
            this.TxtT09Conversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT09Conversions.Location = new System.Drawing.Point(732, 99);
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
            this.TxtT09Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT09Contacts.Location = new System.Drawing.Point(732, 73);
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
            this.TxtT09New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT09New.Location = new System.Drawing.Point(732, 46);
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
            this.TxtT08Abandons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT08Abandons.Location = new System.Drawing.Point(655, 125);
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
            this.TxtT08Conversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT08Conversions.Location = new System.Drawing.Point(655, 99);
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
            this.TxtT08Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT08Contacts.Location = new System.Drawing.Point(655, 73);
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
            this.TxtT08New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT08New.Location = new System.Drawing.Point(655, 46);
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
            this.TxtT07Abandons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT07Abandons.Location = new System.Drawing.Point(578, 125);
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
            this.TxtT07Conversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT07Conversions.Location = new System.Drawing.Point(578, 99);
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
            this.TxtT07Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT07Contacts.Location = new System.Drawing.Point(578, 73);
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
            this.TxtT07New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT07New.Location = new System.Drawing.Point(578, 46);
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
            this.TxtT06Abandons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT06Abandons.Location = new System.Drawing.Point(501, 125);
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
            this.TxtT06Conversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT06Conversions.Location = new System.Drawing.Point(501, 99);
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
            this.TxtT06Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT06Contacts.Location = new System.Drawing.Point(501, 73);
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
            this.TxtT06New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT06New.Location = new System.Drawing.Point(501, 46);
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
            this.TxtT05Abandons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT05Abandons.Location = new System.Drawing.Point(424, 125);
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
            this.TxtT05Conversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT05Conversions.Location = new System.Drawing.Point(424, 99);
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
            this.TxtT05Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT05Contacts.Location = new System.Drawing.Point(424, 73);
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
            this.TxtT05New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT05New.Location = new System.Drawing.Point(424, 46);
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
            this.TxtT04Abandons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT04Abandons.Location = new System.Drawing.Point(347, 125);
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
            this.TxtT04Conversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT04Conversions.Location = new System.Drawing.Point(347, 99);
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
            this.TxtT04Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT04Contacts.Location = new System.Drawing.Point(347, 73);
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
            this.TxtT04New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT04New.Location = new System.Drawing.Point(347, 46);
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
            this.TxtT03Abandons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT03Abandons.Location = new System.Drawing.Point(270, 125);
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
            this.TxtT03Conversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT03Conversions.Location = new System.Drawing.Point(270, 99);
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
            this.TxtT03Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT03Contacts.Location = new System.Drawing.Point(270, 73);
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
            this.TxtT03New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT03New.Location = new System.Drawing.Point(270, 46);
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
            this.TxtT02Abandons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT02Abandons.Location = new System.Drawing.Point(193, 125);
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
            this.TxtT02Conversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT02Conversions.Location = new System.Drawing.Point(193, 99);
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
            this.TxtT02Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT02Contacts.Location = new System.Drawing.Point(193, 73);
            this.TxtT02Contacts.Name = "TxtT02Contacts";
            this.TxtT02Contacts.ReadOnly = true;
            this.TxtT02Contacts.Size = new System.Drawing.Size(40, 20);
            this.TxtT02Contacts.TabIndex = 76;
            this.TxtT02Contacts.TabStop = false;
            this.TxtT02Contacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtT02New
            // 
            this.TxtT02New.BackColor = System.Drawing.SystemColors.Control;
            this.TxtT02New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT02New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT02New.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtT02New.Location = new System.Drawing.Point(193, 46);
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
            this.TxtT01Abandons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TxtT01Conversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TxtT01Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TxtT01New.BackColor = System.Drawing.SystemColors.Control;
            this.TxtT01New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtT01New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtT01New.ForeColor = System.Drawing.SystemColors.WindowText;
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
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(1081, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 135;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtTOTAbandons
            // 
            this.TxtTOTAbandons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTOTAbandons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTOTAbandons.Location = new System.Drawing.Point(1040, 125);
            this.TxtTOTAbandons.Name = "TxtTOTAbandons";
            this.TxtTOTAbandons.ReadOnly = true;
            this.TxtTOTAbandons.Size = new System.Drawing.Size(40, 20);
            this.TxtTOTAbandons.TabIndex = 134;
            this.TxtTOTAbandons.TabStop = false;
            this.TxtTOTAbandons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTOTConversions
            // 
            this.TxtTOTConversions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTOTConversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTOTConversions.Location = new System.Drawing.Point(1040, 99);
            this.TxtTOTConversions.Name = "TxtTOTConversions";
            this.TxtTOTConversions.ReadOnly = true;
            this.TxtTOTConversions.Size = new System.Drawing.Size(40, 20);
            this.TxtTOTConversions.TabIndex = 133;
            this.TxtTOTConversions.TabStop = false;
            this.TxtTOTConversions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTOTContacts
            // 
            this.TxtTOTContacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTOTContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTOTContacts.Location = new System.Drawing.Point(1040, 73);
            this.TxtTOTContacts.Name = "TxtTOTContacts";
            this.TxtTOTContacts.ReadOnly = true;
            this.TxtTOTContacts.Size = new System.Drawing.Size(40, 20);
            this.TxtTOTContacts.TabIndex = 132;
            this.TxtTOTContacts.TabStop = false;
            this.TxtTOTContacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTOTNew
            // 
            this.TxtTOTNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTOTNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTOTNew.Location = new System.Drawing.Point(1040, 46);
            this.TxtTOTNew.Name = "TxtTOTNew";
            this.TxtTOTNew.ReadOnly = true;
            this.TxtTOTNew.Size = new System.Drawing.Size(40, 20);
            this.TxtTOTNew.TabIndex = 131;
            this.TxtTOTNew.TabStop = false;
            this.TxtTOTNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox28
            // 
            this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox28.Location = new System.Drawing.Point(1081, 99);
            this.textBox28.Name = "textBox28";
            this.textBox28.ReadOnly = true;
            this.textBox28.Size = new System.Drawing.Size(33, 20);
            this.textBox28.TabIndex = 159;
            this.textBox28.TabStop = false;
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox41
            // 
            this.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox41.Location = new System.Drawing.Point(1081, 125);
            this.textBox41.Name = "textBox41";
            this.textBox41.ReadOnly = true;
            this.textBox41.Size = new System.Drawing.Size(33, 20);
            this.textBox41.TabIndex = 161;
            this.textBox41.TabStop = false;
            this.textBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StatistiquesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(1139, 576);
            this.Controls.Add(this.textBox41);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxtTOTAbandons);
            this.Controls.Add(this.TxtTOTConversions);
            this.Controls.Add(this.TxtTOTContacts);
            this.Controls.Add(this.TxtTOTNew);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtTOTAbandons;
        private System.Windows.Forms.TextBox TxtTOTConversions;
        private System.Windows.Forms.TextBox TxtTOTContacts;
        private System.Windows.Forms.TextBox TxtTOTNew;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox41;
    }
}