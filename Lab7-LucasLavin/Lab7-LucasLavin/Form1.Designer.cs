﻿namespace Lab7_LucasLavin
{
    partial class CalculadoraLucasLavin
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
            this.BtnsYdisplay = new System.Windows.Forms.TableLayoutPanel();
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.tableBotones = new System.Windows.Forms.TableLayoutPanel();
            this.Igual = new System.Windows.Forms.Button();
            this.Ans = new System.Windows.Forms.Button();
            this.Historial = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.BtnsYdisplay.SuspendLayout();
            this.tableBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnsYdisplay
            // 
            this.BtnsYdisplay.ColumnCount = 1;
            this.BtnsYdisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BtnsYdisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BtnsYdisplay.Controls.Add(this.textDisplay, 0, 0);
            this.BtnsYdisplay.Controls.Add(this.tableBotones, 0, 1);
            this.BtnsYdisplay.Location = new System.Drawing.Point(21, 12);
            this.BtnsYdisplay.Name = "BtnsYdisplay";
            this.BtnsYdisplay.RowCount = 2;
            this.BtnsYdisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BtnsYdisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.BtnsYdisplay.Size = new System.Drawing.Size(350, 297);
            this.BtnsYdisplay.TabIndex = 0;
            // 
            // textDisplay
            // 
            this.textDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDisplay.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDisplay.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textDisplay.Location = new System.Drawing.Point(3, 3);
            this.textDisplay.Multiline = true;
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.ReadOnly = true;
            this.textDisplay.Size = new System.Drawing.Size(344, 68);
            this.textDisplay.TabIndex = 0;
            // 
            // tableBotones
            // 
            this.tableBotones.ColumnCount = 5;
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableBotones.Controls.Add(this.Igual, 4, 3);
            this.tableBotones.Controls.Add(this.Ans, 3, 3);
            this.tableBotones.Controls.Add(this.Historial, 2, 3);
            this.tableBotones.Controls.Add(this.cero, 1, 3);
            this.tableBotones.Controls.Add(this.punto, 0, 3);
            this.tableBotones.Controls.Add(this.resta, 4, 2);
            this.tableBotones.Controls.Add(this.suma, 3, 2);
            this.tableBotones.Controls.Add(this.tres, 2, 2);
            this.tableBotones.Controls.Add(this.dos, 1, 2);
            this.tableBotones.Controls.Add(this.uno, 0, 2);
            this.tableBotones.Controls.Add(this.division, 4, 1);
            this.tableBotones.Controls.Add(this.multiplicacion, 3, 1);
            this.tableBotones.Controls.Add(this.seis, 2, 1);
            this.tableBotones.Controls.Add(this.cinco, 1, 1);
            this.tableBotones.Controls.Add(this.cuatro, 0, 1);
            this.tableBotones.Controls.Add(this.Clear, 4, 0);
            this.tableBotones.Controls.Add(this.Delete, 3, 0);
            this.tableBotones.Controls.Add(this.nueve, 2, 0);
            this.tableBotones.Controls.Add(this.ocho, 1, 0);
            this.tableBotones.Controls.Add(this.siete, 0, 0);
            this.tableBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBotones.Location = new System.Drawing.Point(3, 77);
            this.tableBotones.Name = "tableBotones";
            this.tableBotones.RowCount = 4;
            this.tableBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableBotones.Size = new System.Drawing.Size(344, 217);
            this.tableBotones.TabIndex = 1;
            this.tableBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel2_Paint);
            // 
            // Igual
            // 
            this.Igual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Igual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igual.ForeColor = System.Drawing.SystemColors.Window;
            this.Igual.Location = new System.Drawing.Point(275, 165);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(66, 49);
            this.Igual.TabIndex = 19;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = false;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // Ans
            // 
            this.Ans.BackColor = System.Drawing.Color.IndianRed;
            this.Ans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ans.ForeColor = System.Drawing.Color.White;
            this.Ans.Location = new System.Drawing.Point(207, 165);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(62, 49);
            this.Ans.TabIndex = 18;
            this.Ans.Text = "Ans";
            this.Ans.UseVisualStyleBackColor = false;
            this.Ans.Click += new System.EventHandler(this.Ans_Click);
            // 
            // Historial
            // 
            this.Historial.BackColor = System.Drawing.Color.IndianRed;
            this.Historial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Historial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Historial.ForeColor = System.Drawing.Color.White;
            this.Historial.Location = new System.Drawing.Point(139, 165);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(62, 49);
            this.Historial.TabIndex = 17;
            this.Historial.Text = "Hist";
            this.Historial.UseVisualStyleBackColor = false;
            this.Historial.Click += new System.EventHandler(this.Historial_Click);
            // 
            // cero
            // 
            this.cero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cero.Location = new System.Drawing.Point(71, 165);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(62, 49);
            this.cero.TabIndex = 16;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = false;
            this.cero.Click += new System.EventHandler(this.Numeros);
            // 
            // punto
            // 
            this.punto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.punto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.punto.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punto.Location = new System.Drawing.Point(3, 165);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(62, 49);
            this.punto.TabIndex = 15;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = false;
            this.punto.Click += new System.EventHandler(this.Punto_Click);
            // 
            // resta
            // 
            this.resta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.resta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.ForeColor = System.Drawing.SystemColors.Window;
            this.resta.Location = new System.Drawing.Point(275, 111);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(66, 48);
            this.resta.TabIndex = 14;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = false;
            this.resta.Click += new System.EventHandler(this.Operaciones);
            // 
            // suma
            // 
            this.suma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.suma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.ForeColor = System.Drawing.SystemColors.Window;
            this.suma.Location = new System.Drawing.Point(207, 111);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(62, 48);
            this.suma.TabIndex = 13;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = false;
            this.suma.Click += new System.EventHandler(this.Operaciones);
            // 
            // tres
            // 
            this.tres.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tres.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.Location = new System.Drawing.Point(139, 111);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(62, 48);
            this.tres.TabIndex = 12;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = false;
            this.tres.Click += new System.EventHandler(this.Numeros);
            // 
            // dos
            // 
            this.dos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dos.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dos.Location = new System.Drawing.Point(71, 111);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(62, 48);
            this.dos.TabIndex = 11;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = false;
            this.dos.Click += new System.EventHandler(this.Numeros);
            // 
            // uno
            // 
            this.uno.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uno.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uno.Location = new System.Drawing.Point(3, 111);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(62, 48);
            this.uno.TabIndex = 10;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = false;
            this.uno.Click += new System.EventHandler(this.Numeros);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.ForeColor = System.Drawing.SystemColors.Window;
            this.division.Location = new System.Drawing.Point(275, 57);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(66, 48);
            this.division.TabIndex = 9;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.Operaciones);
            // 
            // multiplicacion
            // 
            this.multiplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.multiplicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacion.ForeColor = System.Drawing.SystemColors.Window;
            this.multiplicacion.Location = new System.Drawing.Point(207, 57);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(62, 48);
            this.multiplicacion.TabIndex = 8;
            this.multiplicacion.Text = "x";
            this.multiplicacion.UseVisualStyleBackColor = false;
            this.multiplicacion.Click += new System.EventHandler(this.Operaciones);
            // 
            // seis
            // 
            this.seis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.seis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seis.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.Location = new System.Drawing.Point(139, 57);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(62, 48);
            this.seis.TabIndex = 7;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = false;
            this.seis.Click += new System.EventHandler(this.Numeros);
            // 
            // cinco
            // 
            this.cinco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cinco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cinco.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinco.Location = new System.Drawing.Point(71, 57);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(62, 48);
            this.cinco.TabIndex = 6;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = false;
            this.cinco.Click += new System.EventHandler(this.Numeros);
            // 
            // cuatro
            // 
            this.cuatro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cuatro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuatro.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuatro.Location = new System.Drawing.Point(3, 57);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(62, 48);
            this.cuatro.TabIndex = 5;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = false;
            this.cuatro.Click += new System.EventHandler(this.Numeros);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.IndianRed;
            this.Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(275, 3);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(66, 48);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "AC";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.IndianRed;
            this.Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(207, 3);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(62, 48);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "DEL";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // nueve
            // 
            this.nueve.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nueve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nueve.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nueve.Location = new System.Drawing.Point(139, 3);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(62, 48);
            this.nueve.TabIndex = 2;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = false;
            this.nueve.Click += new System.EventHandler(this.Numeros);
            // 
            // ocho
            // 
            this.ocho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ocho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ocho.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocho.Location = new System.Drawing.Point(71, 3);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(62, 48);
            this.ocho.TabIndex = 1;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = false;
            this.ocho.Click += new System.EventHandler(this.Numeros);
            // 
            // siete
            // 
            this.siete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.siete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siete.Location = new System.Drawing.Point(3, 3);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(62, 48);
            this.siete.TabIndex = 0;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = false;
            this.siete.Click += new System.EventHandler(this.Numeros);
            // 
            // CalculadoraLucasLavin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 321);
            this.Controls.Add(this.BtnsYdisplay);
            this.Name = "CalculadoraLucasLavin";
            this.Text = "Calculadora Lucas Lavin ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BtnsYdisplay.ResumeLayout(false);
            this.BtnsYdisplay.PerformLayout();
            this.tableBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BtnsYdisplay;
        private System.Windows.Forms.TextBox textDisplay;
        private System.Windows.Forms.TableLayoutPanel tableBotones;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Button Ans;
        private System.Windows.Forms.Button Historial;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button nueve;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button siete;
    }
}

