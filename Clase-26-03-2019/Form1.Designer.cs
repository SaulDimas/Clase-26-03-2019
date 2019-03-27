namespace Clase_26_03_2019
{
    partial class frmOperacion
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
            this.grbGrupoA = new System.Windows.Forms.GroupBox();
            this.lblResul = new System.Windows.Forms.Label();
            this.txtValB = new System.Windows.Forms.Label();
            this.txtValA = new System.Windows.Forms.Label();
            this.lblValb = new System.Windows.Forms.TextBox();
            this.lblValA = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grbGrupoA.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGrupoA
            // 
            this.grbGrupoA.Controls.Add(this.lblResul);
            this.grbGrupoA.Controls.Add(this.txtValB);
            this.grbGrupoA.Controls.Add(this.txtValA);
            this.grbGrupoA.Controls.Add(this.lblValb);
            this.grbGrupoA.Controls.Add(this.lblValA);
            this.grbGrupoA.Controls.Add(this.btnCalcular);
            this.grbGrupoA.Location = new System.Drawing.Point(38, 28);
            this.grbGrupoA.Name = "grbGrupoA";
            this.grbGrupoA.Size = new System.Drawing.Size(266, 248);
            this.grbGrupoA.TabIndex = 6;
            this.grbGrupoA.TabStop = false;
            this.grbGrupoA.Text = "groupBox1";
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.Location = new System.Drawing.Point(44, 109);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(94, 24);
            this.lblResul.TabIndex = 11;
            this.lblResul.Text = "Resultado";
            // 
            // txtValB
            // 
            this.txtValB.AutoSize = true;
            this.txtValB.Location = new System.Drawing.Point(44, 60);
            this.txtValB.Name = "txtValB";
            this.txtValB.Size = new System.Drawing.Size(41, 13);
            this.txtValB.TabIndex = 10;
            this.txtValB.Text = "Valor B";
            // 
            // txtValA
            // 
            this.txtValA.AutoSize = true;
            this.txtValA.Location = new System.Drawing.Point(44, 13);
            this.txtValA.Name = "txtValA";
            this.txtValA.Size = new System.Drawing.Size(41, 13);
            this.txtValA.TabIndex = 9;
            this.txtValA.Text = "Valor A";
            // 
            // lblValb
            // 
            this.lblValb.Location = new System.Drawing.Point(119, 53);
            this.lblValb.Name = "lblValb";
            this.lblValb.Size = new System.Drawing.Size(100, 20);
            this.lblValb.TabIndex = 8;
            // 
            // lblValA
            // 
            this.lblValA.Location = new System.Drawing.Point(119, 6);
            this.lblValA.Name = "lblValA";
            this.lblValA.Size = new System.Drawing.Size(100, 20);
            this.lblValA.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(119, 157);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 340);
            this.Controls.Add(this.grbGrupoA);
            this.Name = "frmOperacion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmOperacion_Load);
            this.grbGrupoA.ResumeLayout(false);
            this.grbGrupoA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGrupoA;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.Label txtValB;
        private System.Windows.Forms.Label txtValA;
        private System.Windows.Forms.TextBox lblValb;
        private System.Windows.Forms.TextBox lblValA;
        private System.Windows.Forms.Button btnCalcular;
    }
}

