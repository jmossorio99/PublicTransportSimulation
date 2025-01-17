﻿namespace MIOSimulation
{
    partial class SimulacionMetroCali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulacionMetroCali));
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.StationStop_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.timeInterval = new System.Windows.Forms.TextBox();
            this.LabelExample = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listLines = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.horaFinTxt = new System.Windows.Forms.TextBox();
            this.horaInicioTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zonesCheckedList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.zoom = new System.Windows.Forms.Button();
            this.zoomplus = new System.Windows.Forms.Button();
            this.slower = new System.Windows.Forms.Button();
            this.faster = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.goSimulation = new System.Windows.Forms.Button();
            this.prueba = new System.Windows.Forms.Label();
            this.startSimulation = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(2, -2);
            this.gmap.Margin = new System.Windows.Forms.Padding(2);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 10;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(1535, 860);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 14D;
            this.gmap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.addStationsOverlay);
            this.gmap.Load += new System.EventHandler(this.Gmap_Load_1);
            // 
            // StationStop_CB
            // 
            this.StationStop_CB.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationStop_CB.FormattingEnabled = true;
            this.StationStop_CB.Location = new System.Drawing.Point(73, 53);
            this.StationStop_CB.Margin = new System.Windows.Forms.Padding(2);
            this.StationStop_CB.Name = "StationStop_CB";
            this.StationStop_CB.Size = new System.Drawing.Size(148, 27);
            this.StationStop_CB.TabIndex = 1;
            this.StationStop_CB.Text = "Estaciones y paradas";
            this.StationStop_CB.SelectedIndexChanged += new System.EventHandler(this.StationStop_CB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(123, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.timeInterval);
            this.panel1.Controls.Add(this.LabelExample);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.listLines);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.horaFinTxt);
            this.panel1.Controls.Add(this.horaInicioTxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.zonesCheckedList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.zoom);
            this.panel1.Controls.Add(this.zoomplus);
            this.panel1.Controls.Add(this.slower);
            this.panel1.Controls.Add(this.faster);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.goSimulation);
            this.panel1.Controls.Add(this.prueba);
            this.panel1.Controls.Add(this.startSimulation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StationStop_CB);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(1523, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 860);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 574);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 34);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tiempo de escala de simulacion en \r\n                        segundos";
            this.label10.Click += new System.EventHandler(this.Label10_Click_1);
            // 
            // timeInterval
            // 
            this.timeInterval.Location = new System.Drawing.Point(214, 588);
            this.timeInterval.Name = "timeInterval";
            this.timeInterval.Size = new System.Drawing.Size(41, 22);
            this.timeInterval.TabIndex = 25;
            // 
            // LabelExample
            // 
            this.LabelExample.AutoSize = true;
            this.LabelExample.ForeColor = System.Drawing.Color.Black;
            this.LabelExample.Location = new System.Drawing.Point(49, 270);
            this.LabelExample.Name = "LabelExample";
            this.LabelExample.Size = new System.Drawing.Size(204, 17);
            this.LabelExample.TabIndex = 24;
            this.LabelExample.Text = "Ejemplo:  2019-06-20 11:16:47";
            this.LabelExample.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 638);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Filtrar por bus";
            // 
            // listLines
            // 
            this.listLines.FormattingEnabled = true;
            this.listLines.Location = new System.Drawing.Point(151, 636);
            this.listLines.Name = "listLines";
            this.listLines.Size = new System.Drawing.Size(121, 24);
            this.listLines.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(66, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Simulacion";
            // 
            // horaFinTxt
            // 
            this.horaFinTxt.Location = new System.Drawing.Point(169, 324);
            this.horaFinTxt.Name = "horaFinTxt";
            this.horaFinTxt.Size = new System.Drawing.Size(100, 22);
            this.horaFinTxt.TabIndex = 18;
            // 
            // horaInicioTxt
            // 
            this.horaInicioTxt.Location = new System.Drawing.Point(25, 324);
            this.horaInicioTxt.Name = "horaInicioTxt";
            this.horaInicioTxt.Size = new System.Drawing.Size(100, 22);
            this.horaInicioTxt.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(192, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hora fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(41, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hora inicio";
            // 
            // zonesCheckedList
            // 
            this.zonesCheckedList.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zonesCheckedList.FormattingEnabled = true;
            this.zonesCheckedList.Items.AddRange(new object[] {
            "Zone 0 - Centro",
            "Zone 1 - Universidades",
            "Zone 2 - Menga",
            "Zone 3 - Paso del Comercio",
            "Zone 4 - Sanín",
            "Zone 5 - Nuevo Latír",
            "Zone 6 - Simón Bolivar",
            "Zone 7 - Cañaveralejo",
            "Zone 8 - Calipso"});
            this.zonesCheckedList.Location = new System.Drawing.Point(14, 91);
            this.zonesCheckedList.Name = "zonesCheckedList";
            this.zonesCheckedList.Size = new System.Drawing.Size(266, 88);
            this.zonesCheckedList.TabIndex = 14;
            this.zonesCheckedList.SelectedIndexChanged += new System.EventHandler(this.ZonesCheckedList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Velocidad simulación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(130, 704);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Zoom";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 3;
            this.trackBar1.Location = new System.Drawing.Point(66, 720);
            this.trackBar1.Maximum = 18;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(162, 56);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 10;
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // zoom
            // 
            this.zoom.ForeColor = System.Drawing.Color.Black;
            this.zoom.Location = new System.Drawing.Point(42, 720);
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(18, 31);
            this.zoom.TabIndex = 10;
            this.zoom.Text = "-";
            this.zoom.UseVisualStyleBackColor = true;
            this.zoom.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // zoomplus
            // 
            this.zoomplus.ForeColor = System.Drawing.Color.Black;
            this.zoomplus.Location = new System.Drawing.Point(237, 720);
            this.zoomplus.Name = "zoomplus";
            this.zoomplus.Size = new System.Drawing.Size(18, 31);
            this.zoomplus.TabIndex = 9;
            this.zoomplus.Text = "+";
            this.zoomplus.UseVisualStyleBackColor = true;
            this.zoomplus.Click += new System.EventHandler(this.Zoomplus_Click);
            // 
            // slower
            // 
            this.slower.ForeColor = System.Drawing.Color.Black;
            this.slower.Location = new System.Drawing.Point(28, 526);
            this.slower.Name = "slower";
            this.slower.Size = new System.Drawing.Size(18, 31);
            this.slower.TabIndex = 8;
            this.slower.Text = "-";
            this.slower.UseVisualStyleBackColor = true;
            this.slower.Click += new System.EventHandler(this.Slower_Click);
            // 
            // faster
            // 
            this.faster.ForeColor = System.Drawing.Color.Black;
            this.faster.Location = new System.Drawing.Point(251, 526);
            this.faster.Name = "faster";
            this.faster.Size = new System.Drawing.Size(18, 31);
            this.faster.TabIndex = 7;
            this.faster.Text = "+";
            this.faster.UseVisualStyleBackColor = true;
            this.faster.Click += new System.EventHandler(this.Faster_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(63, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Pausar simulación";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // goSimulation
            // 
            this.goSimulation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goSimulation.ForeColor = System.Drawing.Color.Black;
            this.goSimulation.Location = new System.Drawing.Point(64, 443);
            this.goSimulation.Name = "goSimulation";
            this.goSimulation.Size = new System.Drawing.Size(179, 29);
            this.goSimulation.TabIndex = 5;
            this.goSimulation.Text = "Reanudar simulación";
            this.goSimulation.UseVisualStyleBackColor = true;
            this.goSimulation.Click += new System.EventHandler(this.GoSimulation_Click);
            // 
            // prueba
            // 
            this.prueba.AutoSize = true;
            this.prueba.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prueba.ForeColor = System.Drawing.Color.Black;
            this.prueba.Location = new System.Drawing.Point(26, 392);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(180, 23);
            this.prueba.TabIndex = 4;
            this.prueba.Text = "Informacion de la ruta";
            // 
            // startSimulation
            // 
            this.startSimulation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSimulation.ForeColor = System.Drawing.Color.Black;
            this.startSimulation.Location = new System.Drawing.Point(102, 360);
            this.startSimulation.Name = "startSimulation";
            this.startSimulation.Size = new System.Drawing.Size(80, 29);
            this.startSimulation.TabIndex = 3;
            this.startSimulation.Text = "Simular movimiento";
            this.startSimulation.UseVisualStyleBackColor = true;
            this.startSimulation.Click += new System.EventHandler(this.StartSimulation_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // SimulacionMetroCali
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1833, 857);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gmap);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "SimulacionMetroCali";
            this.Text = "SimulacionMetroCali";
            this.Load += new System.EventHandler(this.Map_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.ComboBox StationStop_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startSimulation;
        private System.Windows.Forms.Label prueba;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button goSimulation;
        private System.Windows.Forms.Button slower;
        private System.Windows.Forms.Button faster;
        private System.Windows.Forms.Button zoom;
        private System.Windows.Forms.Button zoomplus;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox zonesCheckedList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox horaFinTxt;
        private System.Windows.Forms.TextBox horaInicioTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox listLines;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelExample;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox timeInterval;
    }
}
