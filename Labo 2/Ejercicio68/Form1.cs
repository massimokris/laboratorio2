using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio68
{
  public partial class FrmPersona : Form
  {
    private Persona persona;

    public FrmPersona()
    {
      InitializeComponent();
    }

    public void NotificarCambio(string cambio)
    {
      MessageBox.Show(cambio);
    }

    private void FrmPersona_Load(object sender, EventArgs e)
    {
      
    }

    private void btnCrear_Click(object sender, EventArgs e)
    {
      if(this.persona is null)
      {
        this.persona = new Persona();
        this.persona.EventoString += NotificarCambio;
        this.btnCrear.Text = "Actualizar";
      }
      this.persona.Nombre = txtBoxNombre.Text;
      this.persona.Apellido = txtBoxApellido.Text;
    }
  }
}
