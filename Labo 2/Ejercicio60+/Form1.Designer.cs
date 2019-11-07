namespace Ejercicio60_
{
  partial class FrmBase
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
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtBoxQuery = new System.Windows.Forms.TextBox();
            this.txtBoxCambio = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnCambio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbResultado
            // 
            this.rtbResultado.Location = new System.Drawing.Point(37, 75);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(569, 182);
            this.rtbResultado.TabIndex = 0;
            this.rtbResultado.Text = "";
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(37, 13);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(48, 13);
            this.lblConsulta.TabIndex = 1;
            this.lblConsulta.Text = "Consulta";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(37, 42);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(42, 13);
            this.lblCambio.TabIndex = 2;
            this.lblCambio.Text = "Cambio";
            // 
            // txtBoxQuery
            // 
            this.txtBoxQuery.Location = new System.Drawing.Point(92, 13);
            this.txtBoxQuery.Name = "txtBoxQuery";
            this.txtBoxQuery.Size = new System.Drawing.Size(391, 20);
            this.txtBoxQuery.TabIndex = 3;
            // 
            // txtBoxCambio
            // 
            this.txtBoxCambio.Location = new System.Drawing.Point(92, 42);
            this.txtBoxCambio.Name = "txtBoxCambio";
            this.txtBoxCambio.Size = new System.Drawing.Size(391, 20);
            this.txtBoxCambio.TabIndex = 4;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(505, 9);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "ejecutar";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnCambio
            // 
            this.btnCambio.Location = new System.Drawing.Point(505, 42);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(75, 23);
            this.btnCambio.TabIndex = 6;
            this.btnCambio.Text = "modificar";
            this.btnCambio.UseVisualStyleBackColor = true;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 269);
            this.Controls.Add(this.btnCambio);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtBoxCambio);
            this.Controls.Add(this.txtBoxQuery);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.rtbResultado);
            this.Name = "FrmBase";
            this.Text = "AdventureWorks";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox rtbResultado;
    private System.Windows.Forms.Label lblConsulta;
    private System.Windows.Forms.Label lblCambio;
    private System.Windows.Forms.TextBox txtBoxQuery;
    private System.Windows.Forms.TextBox txtBoxCambio;
    private System.Windows.Forms.Button btnQuery;
    private System.Windows.Forms.Button btnCambio;
  }
}

