namespace ProyectoDiscreta2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Start = new System.Windows.Forms.TabPage();
            this.Comenzar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_cities = new System.Windows.Forms.TabPage();
            this.AddCities_btm_Ready = new System.Windows.Forms.Button();
            this.AddCities_txt_AddCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddCities_btm_Add = new System.Windows.Forms.Button();
            this.Connections = new System.Windows.Forms.TabPage();
            this.Connections_btm_Ready = new System.Windows.Forms.Button();
            this.Connections_btm_Add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Connections_cb_Destination = new System.Windows.Forms.ComboBox();
            this.Connections_cb_Origin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Prices = new System.Windows.Forms.TabPage();
            this.Prices_btm_Add = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Prices_txt_Price = new System.Windows.Forms.TextBox();
            this.Prices_cb_Connections = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Set_First_And_Last = new System.Windows.Forms.TabPage();
            this.SetFirstAndLast_cb_next = new System.Windows.Forms.Button();
            this.SetFirstAndLast_cb_Destination = new System.Windows.Forms.ComboBox();
            this.SetFirstAndLast_cb_Origin = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.TabPage();
            this.Results_lb_Results = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Start.SuspendLayout();
            this.Add_cities.SuspendLayout();
            this.Connections.SuspendLayout();
            this.Prices.SuspendLayout();
            this.Set_First_And_Last.SuspendLayout();
            this.Results.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Start);
            this.tabControl1.Controls.Add(this.Add_cities);
            this.tabControl1.Controls.Add(this.Connections);
            this.tabControl1.Controls.Add(this.Prices);
            this.tabControl1.Controls.Add(this.Set_First_And_Last);
            this.tabControl1.Controls.Add(this.Results);
            this.tabControl1.Location = new System.Drawing.Point(-5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(369, 258);
            this.tabControl1.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Controls.Add(this.Comenzar);
            this.Start.Controls.Add(this.label1);
            this.Start.Location = new System.Drawing.Point(4, 22);
            this.Start.Name = "Start";
            this.Start.Padding = new System.Windows.Forms.Padding(3);
            this.Start.Size = new System.Drawing.Size(361, 232);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // Comenzar
            // 
            this.Comenzar.Location = new System.Drawing.Point(93, 97);
            this.Comenzar.Name = "Comenzar";
            this.Comenzar.Size = new System.Drawing.Size(175, 51);
            this.Comenzar.TabIndex = 1;
            this.Comenzar.Text = "Comenzar";
            this.Comenzar.UseVisualStyleBackColor = true;
            this.Comenzar.Click += new System.EventHandler(this.Comenzar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a Fancy Tours";
            // 
            // Add_cities
            // 
            this.Add_cities.Controls.Add(this.AddCities_btm_Ready);
            this.Add_cities.Controls.Add(this.AddCities_txt_AddCity);
            this.Add_cities.Controls.Add(this.label2);
            this.Add_cities.Controls.Add(this.AddCities_btm_Add);
            this.Add_cities.Location = new System.Drawing.Point(4, 22);
            this.Add_cities.Name = "Add_cities";
            this.Add_cities.Padding = new System.Windows.Forms.Padding(3);
            this.Add_cities.Size = new System.Drawing.Size(361, 232);
            this.Add_cities.TabIndex = 1;
            this.Add_cities.Text = "Add Cities";
            this.Add_cities.UseVisualStyleBackColor = true;
            // 
            // AddCities_btm_Ready
            // 
            this.AddCities_btm_Ready.Location = new System.Drawing.Point(185, 117);
            this.AddCities_btm_Ready.Name = "AddCities_btm_Ready";
            this.AddCities_btm_Ready.Size = new System.Drawing.Size(75, 23);
            this.AddCities_btm_Ready.TabIndex = 2;
            this.AddCities_btm_Ready.Text = "Listo";
            this.AddCities_btm_Ready.UseVisualStyleBackColor = true;
            this.AddCities_btm_Ready.Click += new System.EventHandler(this.AddCities_btm_Ready_Click);
            // 
            // AddCities_txt_AddCity
            // 
            this.AddCities_txt_AddCity.Location = new System.Drawing.Point(95, 78);
            this.AddCities_txt_AddCity.Name = "AddCities_txt_AddCity";
            this.AddCities_txt_AddCity.Size = new System.Drawing.Size(165, 20);
            this.AddCities_txt_AddCity.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agregar Ciudades";
            // 
            // AddCities_btm_Add
            // 
            this.AddCities_btm_Add.Location = new System.Drawing.Point(95, 117);
            this.AddCities_btm_Add.Name = "AddCities_btm_Add";
            this.AddCities_btm_Add.Size = new System.Drawing.Size(75, 23);
            this.AddCities_btm_Add.TabIndex = 0;
            this.AddCities_btm_Add.Text = "Agregar";
            this.AddCities_btm_Add.UseVisualStyleBackColor = true;
            this.AddCities_btm_Add.Click += new System.EventHandler(this.AddCities_btm_Add_Click);
            // 
            // Connections
            // 
            this.Connections.Controls.Add(this.Connections_btm_Ready);
            this.Connections.Controls.Add(this.Connections_btm_Add);
            this.Connections.Controls.Add(this.label7);
            this.Connections.Controls.Add(this.label6);
            this.Connections.Controls.Add(this.Connections_cb_Destination);
            this.Connections.Controls.Add(this.Connections_cb_Origin);
            this.Connections.Controls.Add(this.label5);
            this.Connections.Controls.Add(this.label4);
            this.Connections.Controls.Add(this.label3);
            this.Connections.Location = new System.Drawing.Point(4, 22);
            this.Connections.Name = "Connections";
            this.Connections.Size = new System.Drawing.Size(361, 232);
            this.Connections.TabIndex = 2;
            this.Connections.Text = "Connections";
            this.Connections.UseVisualStyleBackColor = true;
            // 
            // Connections_btm_Ready
            // 
            this.Connections_btm_Ready.Location = new System.Drawing.Point(207, 142);
            this.Connections_btm_Ready.Name = "Connections_btm_Ready";
            this.Connections_btm_Ready.Size = new System.Drawing.Size(75, 23);
            this.Connections_btm_Ready.TabIndex = 9;
            this.Connections_btm_Ready.Text = "Listo";
            this.Connections_btm_Ready.UseVisualStyleBackColor = true;
            this.Connections_btm_Ready.Click += new System.EventHandler(this.Connections_btm_Ready_Click);
            // 
            // Connections_btm_Add
            // 
            this.Connections_btm_Add.Location = new System.Drawing.Point(77, 142);
            this.Connections_btm_Add.Name = "Connections_btm_Add";
            this.Connections_btm_Add.Size = new System.Drawing.Size(75, 23);
            this.Connections_btm_Add.TabIndex = 8;
            this.Connections_btm_Add.Text = "Agregar";
            this.Connections_btm_Add.UseVisualStyleBackColor = true;
            this.Connections_btm_Add.Click += new System.EventHandler(this.Connections_btm_Add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(204, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Destino";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Origen:";
            // 
            // Connections_cb_Destination
            // 
            this.Connections_cb_Destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Connections_cb_Destination.FormattingEnabled = true;
            this.Connections_cb_Destination.Location = new System.Drawing.Point(207, 88);
            this.Connections_cb_Destination.Name = "Connections_cb_Destination";
            this.Connections_cb_Destination.Size = new System.Drawing.Size(121, 21);
            this.Connections_cb_Destination.TabIndex = 5;
            // 
            // Connections_cb_Origin
            // 
            this.Connections_cb_Origin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Connections_cb_Origin.FormattingEnabled = true;
            this.Connections_cb_Origin.Location = new System.Drawing.Point(40, 88);
            this.Connections_cb_Origin.Name = "Connections_cb_Origin";
            this.Connections_cb_Origin.Size = new System.Drawing.Size(121, 21);
            this.Connections_cb_Origin.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "existentes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seleccione las conexiones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // Prices
            // 
            this.Prices.Controls.Add(this.Prices_btm_Add);
            this.Prices.Controls.Add(this.label12);
            this.Prices.Controls.Add(this.label11);
            this.Prices.Controls.Add(this.label10);
            this.Prices.Controls.Add(this.Prices_txt_Price);
            this.Prices.Controls.Add(this.Prices_cb_Connections);
            this.Prices.Controls.Add(this.label9);
            this.Prices.Controls.Add(this.label8);
            this.Prices.Location = new System.Drawing.Point(4, 22);
            this.Prices.Name = "Prices";
            this.Prices.Size = new System.Drawing.Size(361, 232);
            this.Prices.TabIndex = 3;
            this.Prices.Text = "Prices";
            this.Prices.UseVisualStyleBackColor = true;
            // 
            // Prices_btm_Add
            // 
            this.Prices_btm_Add.Location = new System.Drawing.Point(257, 191);
            this.Prices_btm_Add.Name = "Prices_btm_Add";
            this.Prices_btm_Add.Size = new System.Drawing.Size(75, 23);
            this.Prices_btm_Add.TabIndex = 10;
            this.Prices_btm_Add.Text = "Agregar";
            this.Prices_btm_Add.UseVisualStyleBackColor = true;
            this.Prices_btm_Add.Click += new System.EventHandler(this.Prices_btm_Add_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(205, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Precio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Conexion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(147, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 65);
            this.label10.TabIndex = 7;
            this.label10.Text = "↳";
            // 
            // Prices_txt_Price
            // 
            this.Prices_txt_Price.Location = new System.Drawing.Point(208, 155);
            this.Prices_txt_Price.Name = "Prices_txt_Price";
            this.Prices_txt_Price.Size = new System.Drawing.Size(100, 20);
            this.Prices_txt_Price.TabIndex = 6;
            // 
            // Prices_cb_Connections
            // 
            this.Prices_cb_Connections.FormattingEnabled = true;
            this.Prices_cb_Connections.Location = new System.Drawing.Point(3, 96);
            this.Prices_cb_Connections.Name = "Prices_cb_Connections";
            this.Prices_cb_Connections.Size = new System.Drawing.Size(199, 21);
            this.Prices_cb_Connections.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "conexiones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(298, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Seleccione los precios de las";
            // 
            // Set_First_And_Last
            // 
            this.Set_First_And_Last.Controls.Add(this.SetFirstAndLast_cb_next);
            this.Set_First_And_Last.Controls.Add(this.SetFirstAndLast_cb_Destination);
            this.Set_First_And_Last.Controls.Add(this.SetFirstAndLast_cb_Origin);
            this.Set_First_And_Last.Controls.Add(this.label15);
            this.Set_First_And_Last.Controls.Add(this.label14);
            this.Set_First_And_Last.Controls.Add(this.label13);
            this.Set_First_And_Last.Location = new System.Drawing.Point(4, 22);
            this.Set_First_And_Last.Name = "Set_First_And_Last";
            this.Set_First_And_Last.Size = new System.Drawing.Size(361, 232);
            this.Set_First_And_Last.TabIndex = 4;
            this.Set_First_And_Last.Text = "Set First And Last";
            this.Set_First_And_Last.UseVisualStyleBackColor = true;
            // 
            // SetFirstAndLast_cb_next
            // 
            this.SetFirstAndLast_cb_next.Location = new System.Drawing.Point(141, 132);
            this.SetFirstAndLast_cb_next.Name = "SetFirstAndLast_cb_next";
            this.SetFirstAndLast_cb_next.Size = new System.Drawing.Size(75, 23);
            this.SetFirstAndLast_cb_next.TabIndex = 11;
            this.SetFirstAndLast_cb_next.Text = "Siguiente";
            this.SetFirstAndLast_cb_next.UseVisualStyleBackColor = true;
            this.SetFirstAndLast_cb_next.Click += new System.EventHandler(this.SetFirstAndLast_cb_next_Click);
            // 
            // SetFirstAndLast_cb_Destination
            // 
            this.SetFirstAndLast_cb_Destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SetFirstAndLast_cb_Destination.FormattingEnabled = true;
            this.SetFirstAndLast_cb_Destination.Location = new System.Drawing.Point(192, 96);
            this.SetFirstAndLast_cb_Destination.Name = "SetFirstAndLast_cb_Destination";
            this.SetFirstAndLast_cb_Destination.Size = new System.Drawing.Size(121, 21);
            this.SetFirstAndLast_cb_Destination.TabIndex = 10;
            // 
            // SetFirstAndLast_cb_Origin
            // 
            this.SetFirstAndLast_cb_Origin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SetFirstAndLast_cb_Origin.FormattingEnabled = true;
            this.SetFirstAndLast_cb_Origin.Location = new System.Drawing.Point(38, 96);
            this.SetFirstAndLast_cb_Origin.Name = "SetFirstAndLast_cb_Origin";
            this.SetFirstAndLast_cb_Origin.Size = new System.Drawing.Size(121, 21);
            this.SetFirstAndLast_cb_Origin.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(189, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 15);
            this.label15.TabIndex = 8;
            this.label15.Text = "Destino";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 15);
            this.label14.TabIndex = 7;
            this.label14.Text = "Origen:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(278, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Seleccione origen y destino";
            // 
            // Results
            // 
            this.Results.Controls.Add(this.Results_lb_Results);
            this.Results.Controls.Add(this.label16);
            this.Results.Location = new System.Drawing.Point(4, 22);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(361, 232);
            this.Results.TabIndex = 5;
            this.Results.Text = "Results";
            this.Results.UseVisualStyleBackColor = true;
            // 
            // Results_lb_Results
            // 
            this.Results_lb_Results.FormattingEnabled = true;
            this.Results_lb_Results.Location = new System.Drawing.Point(39, 61);
            this.Results_lb_Results.Name = "Results_lb_Results";
            this.Results_lb_Results.Size = new System.Drawing.Size(144, 134);
            this.Results_lb_Results.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(188, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Su mejor opcion es";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 252);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Start.ResumeLayout(false);
            this.Start.PerformLayout();
            this.Add_cities.ResumeLayout(false);
            this.Add_cities.PerformLayout();
            this.Connections.ResumeLayout(false);
            this.Connections.PerformLayout();
            this.Prices.ResumeLayout(false);
            this.Prices.PerformLayout();
            this.Set_First_And_Last.ResumeLayout(false);
            this.Set_First_And_Last.PerformLayout();
            this.Results.ResumeLayout(false);
            this.Results.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Start;
        private System.Windows.Forms.Button Comenzar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Add_cities;
        private System.Windows.Forms.Button AddCities_btm_Ready;
        private System.Windows.Forms.TextBox AddCities_txt_AddCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddCities_btm_Add;
        private System.Windows.Forms.TabPage Connections;
        private System.Windows.Forms.TabPage Prices;
        private System.Windows.Forms.TabPage Set_First_And_Last;
        private System.Windows.Forms.TabPage Results;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Connections_btm_Ready;
        private System.Windows.Forms.Button Connections_btm_Add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Connections_cb_Destination;
        private System.Windows.Forms.ComboBox Connections_cb_Origin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Prices_btm_Add;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Prices_txt_Price;
        private System.Windows.Forms.ComboBox Prices_cb_Connections;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SetFirstAndLast_cb_next;
        private System.Windows.Forms.ComboBox SetFirstAndLast_cb_Destination;
        private System.Windows.Forms.ComboBox SetFirstAndLast_cb_Origin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox Results_lb_Results;
        private System.Windows.Forms.Label label16;
    }
}

