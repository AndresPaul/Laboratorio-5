using Patrones.Strategy.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Patrones.Strategy.UI
{
    public partial class Form1 : Form
    {

        List<Refresco> _estrategiasDispensar;
        Dispensador dispensador;
        public Form1()
        {
            InitializeComponent();

            _estrategiasDispensar = new List<Refresco>();

            _estrategiasDispensar.Add(new CocaCola());
            _estrategiasDispensar.Add(new Fanta());
            _estrategiasDispensar.Add(new Sprite());
            _estrategiasDispensar.Add(new Simba());
            _estrategiasDispensar.Add(new Vital());


            this.cboEstrategias.DataSource = _estrategiasDispensar;


            dispensador = new Dispensador();
            dispensador.Nombre = "Dispensador CBBA";
            this.lblDispensador.Text = dispensador.Nombre;

        }

        private void cmdDispensar_Click(object sender, EventArgs e)
        {
          
                MessageBox.Show(dispensador.Dispensar());
           
         
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            Refresco refresco = (Refresco)this.cboEstrategias.SelectedItem;
            dispensador.CambiarEstrategia(refresco);
        }
    }
}
