using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Ejercicio23
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      string euro = textBox1.Text;
      string dolar = textBox2.Text;
      string peso = textBox3.Text;
      int valorEuro, valorDolar, ValorPeso;

      int.TryParse(euro, out valorEuro);
      int.TryParse(dolar, out valorDolar);
      int.TryParse(peso, out ValorPeso);

      Moneda.Euro monedaEuro = new Euro(0, valorEuro);
      Moneda.Dolar monedaDolar = new Dolar(0, valorDolar);
      Moneda.Peso monedaPeso = new Peso(0, ValorPeso);
      
      button1.Visible = false;
      button2.Enabled = true;
      button3.Enabled = true;
      button4.Enabled = true;
      button5.Visible = true;
      textBox1.Enabled = false;
      textBox2.Enabled = false;
      textBox3.Enabled = false;
      textBox13.Enabled = true;
      textBox14.Enabled = true;
      textBox15.Enabled = true;
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

      
    }

    private void button5_Click(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox13_TextChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      string euro = textBox1.Text;
      string cantidadEuro = textBox13.Text;
     
      int valorEuro, cantidad;

      int.TryParse(euro, out valorEuro);
      int.TryParse(cantidadEuro, out cantidad);

      Moneda.Euro monedaEuro = new Euro(cantidad, valorEuro);

      Moneda.Peso pesito = (Peso)monedaEuro;
      Moneda.Dolar dolarsito = (Dolar)monedaEuro;

      textBox4.Text = cantidadEuro;
      textBox5.Text = dolarsito.GetCantidad().ToString();
      textBox6.Text = pesito.GetCantidad().ToString();
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox6_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox14_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox15_TextChanged(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {

      string dolar = textBox2.Text;
      string cantidadDolar = textBox14.Text;

      int valorDolar, cantidad;

      int.TryParse(dolar, out valorDolar);
      int.TryParse(cantidadDolar, out cantidad);

      Moneda.Dolar monedaDolar = new Dolar(cantidad, valorDolar);

      Moneda.Peso pesito = (Peso)monedaDolar;
      Moneda.Euro eurito = (Euro)monedaDolar;

      textBox9.Text = cantidadDolar;
      textBox7.Text = eurito.GetCantidad().ToString();
      textBox10.Text = pesito.GetCantidad().ToString();
    }

    private void textBox7_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox9_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox10_TextChanged(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {

      string peso = textBox3.Text;
      string cantidadPeso = textBox15.Text;

      int valorPeso, cantidad;

      int.TryParse(peso, out valorPeso);
      int.TryParse(cantidadPeso, out cantidad);

      Moneda.Peso monedaDolar = new Peso(cantidad, valorPeso);

      Moneda.Dolar dolarsito = (Dolar)monedaDolar;
      Moneda.Euro eurito = (Euro)monedaDolar;

      textBox12.Text = cantidadPeso;
      textBox8.Text = eurito.GetCantidad().ToString();
      textBox11.Text = dolarsito.GetCantidad().ToString();
    }

    private void textBox12_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox11_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox8_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
