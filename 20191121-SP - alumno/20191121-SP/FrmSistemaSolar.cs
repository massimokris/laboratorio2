using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Archivos;
using System.Threading;

namespace _20191121_SP
{
    public partial class FrmSistemaSolar : Form
    {
        private System.Windows.Forms.PictureBox picPlaneta1;
        private System.Windows.Forms.PictureBox picPlaneta2;

        private const string archivoPlanetas = "planetas.xml";
        private List<Planeta> planetas;
        private List<Thread> animaciones;
        Xml<List<Planeta>> xml;

        public FrmSistemaSolar()
        {
            InitializeComponent();
            this.planetas = new List<Planeta>();
            this.animaciones = new List<Thread>();
            this.xml = new Xml<List<Planeta>>();
        }

        private void FrmSistemaSolar_Load(object sender, EventArgs e)
        {
            if(this.xml.FileExists(archivoPlanetas))
            {
                // Leo mis planetas del archivo binario
                this.xml.Leer(FrmSistemaSolar.archivoPlanetas, out this.planetas);
            }
            this.InitializePlanets();

            foreach (Planeta p in this.planetas)
            {
                // Asociar Evento
                p.InformarAvance += this.DibujarAvancePlaneta;

                PictureBox pic = (PictureBox)p.ObjetoAsociado;
                pic.Location = this.CalcularUbicacion(pic.Location, p.PosicionActual, p.RadioRespectoSol);
                this.Controls.Add(pic);
            }
        }

        private void InitializePlanets()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSistemaSolar));

            this.picPlaneta1 = new System.Windows.Forms.PictureBox();
            this.picPlaneta2 = new System.Windows.Forms.PictureBox();
            // 
            // picPlaneta1
            // 
            this.picPlaneta1.Image = ((System.Drawing.Image)(resources.GetObject("picPlaneta1.Image")));
            this.picPlaneta1.Location = new System.Drawing.Point(144, 177);
            this.picPlaneta1.Name = "picPlaneta1";
            this.picPlaneta1.Size = new System.Drawing.Size(64, 64);
            this.picPlaneta1.TabIndex = 1;
            this.picPlaneta1.TabStop = false;
            // 
            // picPlaneta2
            // 
            this.picPlaneta2.Image = ((System.Drawing.Image)(resources.GetObject("picPlaneta2.Image")));
            this.picPlaneta2.Location = new System.Drawing.Point(406, 194);
            this.picPlaneta2.Name = "picPlaneta2";
            this.picPlaneta2.Size = new System.Drawing.Size(64, 64);
            this.picPlaneta2.TabIndex = 3;
            this.picPlaneta2.TabStop = false;


            // Creo mis planetas
            if (this.planetas.Count == 0)
            {
                Planeta planeta1 = new Planeta(12, 0, 150, this.picPlaneta1);
                Planeta planeta2 = new Planeta(8, 0, 250, this.picPlaneta2);

                this.planetas.Add(planeta1);
                this.planetas.Add(planeta2);
            }
            else
            {
                this.planetas[0].ObjetoAsociado = this.picPlaneta1;
                this.planetas[1].ObjetoAsociado = this.picPlaneta2;
            }
        }

        /// <summary>
        /// necesario para pasar de grados a radianes, para poder operar con las funciones de seno y coseno
        /// </summary>
        /// <param name="grados"></param>
        /// <returns></returns>
        public static double Grados_a_Radianes(short grados)
        {
            return grados * (Math.PI / 180);
        }

        /// <summary>
        /// Calcula el punto en el cual se ubicará el planeta según su avance.
        /// </summary>
        /// <param name="posicion"></param>
        /// <param name="avance"></param>
        /// <param name="radioRespectoSol"></param>
        /// <returns></returns>
        private Point CalcularUbicacion(Point posicion, short avance, short radioRespectoSol)
        {
            int x = 0;
            int y = avance;

            x = picSol.Location.X + (int)Math.Round(Math.Cos(Grados_a_Radianes(avance)) * radioRespectoSol);
            y = picSol.Location.Y + (int)Math.Round(Math.Sin(Grados_a_Radianes(avance)) * radioRespectoSol);

            return new Point(x, y);
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if(this.animaciones.Count == 0)
            {
                // Iniciar hilos
                foreach (Planeta item in this.planetas)
                {
                  Thread tr = new Thread(item.AnimarSistemaSolar);
                  this.animaciones.Add(tr);
                  
                }
                foreach (var item in this.animaciones)
                {
                  item.Start();
                }
                this.Text = $"Massimo Di Berardino {MetodoEstatico.EstadoSimulacion("nada", true)}";
                this.btnSimular.Text = "Detener";
            }
            else
            {
                this.Text = $"Massimo Di Berardino {MetodoEstatico.EstadoSimulacion("nada", false)}";
                this.LimpiarAnimaciones();
                this.btnSimular.Text = "Simular";
            }
        }

        private void FrmSistemaSolar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.LimpiarAnimaciones();

            xml.Guardar(FrmSistemaSolar.archivoPlanetas, this.planetas);
        }

        private void LimpiarAnimaciones()
        {
            // Cancelar hilos
            foreach (var item in this.animaciones)
            {
              if (item.IsAlive)
              {
                item.Abort();
              }
            }
            this.animaciones.Clear();
        }

        /// <summary>
        /// Dibujar planeta según su nueva ubicación
        /// </summary>
        /// <param name="sender">Planeta</param>
        /// <param name="e">Argumentos asociados</param>
        private void DibujarAvancePlaneta(object sender, PlanetaEventArgs e)
        {
            PictureBox pic = (PictureBox)((Planeta)sender).ObjetoAsociado;
            // Invocación del hilo principal
            if (pic.InvokeRequired)
            {
              pic.Location = this.CalcularUbicacion(pic.Location, e.Avance, e.RadioRespectoSol);
            }
            else
            {
                pic.Location = this.CalcularUbicacion(pic.Location, e.Avance, e.RadioRespectoSol);
            }
        }
    }
}
