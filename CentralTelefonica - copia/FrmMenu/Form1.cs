using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace FrmMenu
{
  public partial class FrmMenu : Form
  {
    public FrmMenu()
    {
      InitializeComponent();
      Centralita c = new Centralita("Ejercicio 40");
    }

    private void Menu(object sender, EventArgs e)
    {

    }

    

    
  }
}
