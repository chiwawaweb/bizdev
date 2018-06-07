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
            this.DgvStats = new System.Windows.Forms.DataGridView();
            this.LblTitre = new System.Windows.Forms.Label();
            this.BtnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChaTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStats)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(995, 529);
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
            this.ChaTotal.Location = new System.Drawing.Point(17, 172);
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
            this.ChaTotal.Size = new System.Drawing.Size(1053, 351);
            this.ChaTotal.TabIndex = 6;
            this.ChaTotal.TabStop = false;
            // 
            // DgvStats
            // 
            this.DgvStats.AllowUserToAddRows = false;
            this.DgvStats.AllowUserToDeleteRows = false;
            this.DgvStats.AllowUserToResizeColumns = false;
            this.DgvStats.AllowUserToResizeRows = false;
            this.DgvStats.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvStats.Location = new System.Drawing.Point(17, 55);
            this.DgvStats.MultiSelect = false;
            this.DgvStats.Name = "DgvStats";
            this.DgvStats.ReadOnly = true;
            this.DgvStats.RowHeadersVisible = false;
            this.DgvStats.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DgvStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStats.ShowCellErrors = false;
            this.DgvStats.ShowCellToolTips = false;
            this.DgvStats.ShowEditingIcon = false;
            this.DgvStats.ShowRowErrors = false;
            this.DgvStats.Size = new System.Drawing.Size(1053, 111);
            this.DgvStats.TabIndex = 163;
            // 
            // LblTitre
            // 
            this.LblTitre.AutoSize = true;
            this.LblTitre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitre.Location = new System.Drawing.Point(17, 23);
            this.LblTitre.Name = "LblTitre";
            this.LblTitre.Size = new System.Drawing.Size(58, 19);
            this.LblTitre.TabIndex = 164;
            this.LblTitre.Text = "Année";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(995, 22);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 165;
            this.BtnRefresh.Text = "Rafraîchir";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // StatistiquesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(1088, 576);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.LblTitre);
            this.Controls.Add(this.DgvStats);
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
            this.Shown += new System.EventHandler(this.StatistiquesForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ChaTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChaTotal;
        private System.Windows.Forms.DataGridView DgvStats;
        private System.Windows.Forms.Label LblTitre;
        private System.Windows.Forms.Button BtnRefresh;
    }
}