namespace Patrones.Strategy.UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstrategias = new System.Windows.Forms.ComboBox();
            this.cmdSeleccionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDispensador = new System.Windows.Forms.Label();
            this.cmdDispensar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecionar el tipo de refresco que desea";
            // 
            // cboEstrategias
            // 
            this.cboEstrategias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstrategias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstrategias.FormattingEnabled = true;
            this.cboEstrategias.Location = new System.Drawing.Point(131, 90);
            this.cboEstrategias.Margin = new System.Windows.Forms.Padding(2);
            this.cboEstrategias.Name = "cboEstrategias";
            this.cboEstrategias.Size = new System.Drawing.Size(346, 32);
            this.cboEstrategias.TabIndex = 1;
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSeleccionar.Location = new System.Drawing.Point(221, 126);
            this.cmdSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.Size = new System.Drawing.Size(161, 64);
            this.cmdSeleccionar.TabIndex = 2;
            this.cmdSeleccionar.Text = "Seleccionar Refresco";
            this.cmdSeleccionar.UseVisualStyleBackColor = true;
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dispensador de Refrescos";
            // 
            // lblDispensador
            // 
            this.lblDispensador.AutoSize = true;
            this.lblDispensador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispensador.Location = new System.Drawing.Point(217, 218);
            this.lblDispensador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDispensador.Name = "lblDispensador";
            this.lblDispensador.Size = new System.Drawing.Size(60, 24);
            this.lblDispensador.TabIndex = 4;
            this.lblDispensador.Text = "label3";
            // 
            // cmdDispensar
            // 
            this.cmdDispensar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDispensar.Location = new System.Drawing.Point(221, 269);
            this.cmdDispensar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDispensar.Name = "cmdDispensar";
            this.cmdDispensar.Size = new System.Drawing.Size(161, 71);
            this.cmdDispensar.TabIndex = 5;
            this.cmdDispensar.Text = "Dispensar Refresco";
            this.cmdDispensar.UseVisualStyleBackColor = true;
            this.cmdDispensar.Click += new System.EventHandler(this.cmdDispensar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cmdDispensar);
            this.Controls.Add(this.lblDispensador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdSeleccionar);
            this.Controls.Add(this.cboEstrategias);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstrategias;
        private System.Windows.Forms.Button cmdSeleccionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDispensador;
        private System.Windows.Forms.Button cmdDispensar;
    }
}

