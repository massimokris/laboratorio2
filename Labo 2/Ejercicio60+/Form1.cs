using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBDD;
using System.Data.SqlClient;

namespace Ejercicio60_
{
  public partial class FrmBase : Form
  {
    public BaseD baseDatos;
    public FrmBase()
    {
      InitializeComponent();
    }

    private void btnQuery_Click(object sender, EventArgs e)
    {
      string consulta = txtBoxQuery.Text;
      StringBuilder st = new StringBuilder();
      if (consulta.Length > 0)
      {
        SqlDataReader oDr = this.baseDatos.consulta(consulta);
        while (oDr.Read())
        {
          st.AppendLine($"{oDr["name"].ToString()}");
        }
      }
      else
      {
        MessageBox.Show("Ingrese texto");
      }
    }

    private void btnCambio_Click(object sender, EventArgs e)
    {
      string consulta = txtBoxCambio.Text;
      StringBuilder st = new StringBuilder();
      if (consulta.Length > 0)
      {
        this.baseDatos.noConsulta(consulta);
      }
      else
      {
        MessageBox.Show("Ingrese texto");
      }
    }

    private void FrmBase_Load(object sender, EventArgs e)
    {
      string source = @"LAB3PC03\SQLSERVER";
      string baseexacta = "AdventureWorks2012";
      this.baseDatos = new BaseD(source, baseexacta);
    }
  }
}
