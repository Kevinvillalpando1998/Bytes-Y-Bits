namespace Practica_Bits_y_Bytes
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
            this.btnbytes = new System.Windows.Forms.Button();
            this.listDatos = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripModificarFecha = new System.Windows.Forms.ToolStripMenuItem();
            this.decodificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listA_o = new System.Windows.Forms.ComboBox();
            this.lisDia = new System.Windows.Forms.ComboBox();
            this.btnCFecha = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnbytes
            // 
            this.btnbytes.Location = new System.Drawing.Point(368, 24);
            this.btnbytes.Name = "btnbytes";
            this.btnbytes.Size = new System.Drawing.Size(83, 37);
            this.btnbytes.TabIndex = 0;
            this.btnbytes.Text = "check";
            this.btnbytes.UseVisualStyleBackColor = true;
            this.btnbytes.Click += new System.EventHandler(this.btnbytes_Click);
            // 
            // listDatos
            // 
            this.listDatos.FormattingEnabled = true;
            this.listDatos.ItemHeight = 24;
            this.listDatos.Location = new System.Drawing.Point(532, 82);
            this.listDatos.Name = "listDatos";
            this.listDatos.Size = new System.Drawing.Size(386, 388);
            this.listDatos.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(28, 30);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(224, 29);
            this.txtNum.TabIndex = 5;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(996, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripModificarFecha,
            this.decodificarToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem1.Text = "Opciones";
            // 
            // toolStripModificarFecha
            // 
            this.toolStripModificarFecha.Name = "toolStripModificarFecha";
            this.toolStripModificarFecha.Size = new System.Drawing.Size(156, 22);
            this.toolStripModificarFecha.Text = "Codificar Fecha";
            this.toolStripModificarFecha.Click += new System.EventHandler(this.ModificarFecha_Click);
            // 
            // decodificarToolStripMenuItem
            // 
            this.decodificarToolStripMenuItem.Name = "decodificarToolStripMenuItem";
            this.decodificarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.decodificarToolStripMenuItem.Text = "Decodificar";
            this.decodificarToolStripMenuItem.Click += new System.EventHandler(this.decodificarToolStripMenuItem_Click);
            // 
            // listMes
            // 
            this.listMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listMes.FormattingEnabled = true;
            this.listMes.Location = new System.Drawing.Point(154, 145);
            this.listMes.Name = "listMes";
            this.listMes.Size = new System.Drawing.Size(78, 32);
            this.listMes.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "de";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "del";
            // 
            // listA_o
            // 
            this.listA_o.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listA_o.FormattingEnabled = true;
            this.listA_o.Location = new System.Drawing.Point(291, 148);
            this.listA_o.Name = "listA_o";
            this.listA_o.Size = new System.Drawing.Size(82, 32);
            this.listA_o.TabIndex = 11;
            // 
            // lisDia
            // 
            this.lisDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lisDia.FormattingEnabled = true;
            this.lisDia.Location = new System.Drawing.Point(32, 147);
            this.lisDia.Name = "lisDia";
            this.lisDia.Size = new System.Drawing.Size(57, 32);
            this.lisDia.TabIndex = 12;
            // 
            // btnCFecha
            // 
            this.btnCFecha.Location = new System.Drawing.Point(133, 221);
            this.btnCFecha.Name = "btnCFecha";
            this.btnCFecha.Size = new System.Drawing.Size(119, 37);
            this.btnCFecha.TabIndex = 13;
            this.btnCFecha.Text = "Codificar";
            this.btnCFecha.UseVisualStyleBackColor = true;
            this.btnCFecha.Click += new System.EventHandler(this.btnCFecha_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Día";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Año";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 482);
            this.Controls.Add(this.listDatos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCFecha);
            this.Controls.Add(this.lisDia);
            this.Controls.Add(this.listA_o);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listMes);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnbytes);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbytes;
        private System.Windows.Forms.ListBox listDatos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripModificarFecha;
        private System.Windows.Forms.ComboBox listMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listA_o;
        private System.Windows.Forms.ComboBox lisDia;
        private System.Windows.Forms.Button btnCFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem decodificarToolStripMenuItem;
    }
}

