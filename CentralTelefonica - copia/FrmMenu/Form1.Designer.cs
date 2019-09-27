namespace FrmMenu
{
  partial class FrmMenu
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
            this.btn_Llamada = new System.Windows.Forms.Button();
            this.btn_Local = new System.Windows.Forms.Button();
            this.btn_Provincial = new System.Windows.Forms.Button();
            this.btn_Total = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Llamada
            // 
            this.btn_Llamada.Location = new System.Drawing.Point(21, 12);
            this.btn_Llamada.Name = "btn_Llamada";
            this.btn_Llamada.Size = new System.Drawing.Size(217, 54);
            this.btn_Llamada.TabIndex = 0;
            this.btn_Llamada.Text = "Generar Llamada";
            this.btn_Llamada.UseVisualStyleBackColor = true;
            // 
            // btn_Local
            // 
            this.btn_Local.Location = new System.Drawing.Point(22, 135);
            this.btn_Local.Name = "btn_Local";
            this.btn_Local.Size = new System.Drawing.Size(217, 54);
            this.btn_Local.TabIndex = 1;
            this.btn_Local.Text = "Facturacion Local";
            this.btn_Local.UseVisualStyleBackColor = true;
            // 
            // btn_Provincial
            // 
            this.btn_Provincial.Location = new System.Drawing.Point(21, 195);
            this.btn_Provincial.Name = "btn_Provincial";
            this.btn_Provincial.Size = new System.Drawing.Size(217, 54);
            this.btn_Provincial.TabIndex = 2;
            this.btn_Provincial.Text = "Facturacion Provincial";
            this.btn_Provincial.UseVisualStyleBackColor = true;
            // 
            // btn_Total
            // 
            this.btn_Total.Location = new System.Drawing.Point(22, 75);
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.Size = new System.Drawing.Size(217, 54);
            this.btn_Total.TabIndex = 3;
            this.btn_Total.Text = "Facturacion Total";
            this.btn_Total.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(22, 258);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(217, 54);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 324);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Total);
            this.Controls.Add(this.btn_Provincial);
            this.Controls.Add(this.btn_Local);
            this.Controls.Add(this.btn_Llamada);
            this.Name = "FrmMenu";
            this.Text = "Central Telefonica";
            this.Load += new System.EventHandler(this.Menu);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btn_Llamada;
    private System.Windows.Forms.Button btn_Local;
    private System.Windows.Forms.Button btn_Provincial;
    private System.Windows.Forms.Button btn_Total;
    private System.Windows.Forms.Button btn_Salir;
  }
}

