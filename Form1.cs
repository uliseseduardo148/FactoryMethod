using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    public partial class Form1 : Form
    {
        private ArrayList lista;

        /*Al cargarse el formulario se agregan a un ListBox las opciones a elegir, de igual
         * forma tenemos una lista a la que se agregan dos objetos de la clases derivadas:
         * TimedFinalEvent y PrelimEvent
         */
        public Form1()
        {
            InitializeComponent();
            listOpciones.Items.Add("100 free");
            listOpciones.Items.Add("500 free");
            lista = new ArrayList();
            lista.Add(new TimedFinalEvent("C:\\Users\\cliente-preferido\\source\\repos\\FactoryMethod\\100.txt", 10));
            lista.Add(new PrelimEvent("C:\\Users\\cliente-preferido\\source\\repos\\FactoryMethod\\500.txt", 10));
        }

        /*En el evento del botón se agregan al ListBox los datos obtenidos de la lectura del archivo para esto se le pasa a 
         * la lista la opción seleccionada y dependiendo de ésta se retorna una instancia del tipo Event, que es la clase base;
         * se accede al array de datos y en base a este array se cargan los datos al ListBox
        */
        private void BtnSeed_Click(object sender, EventArgs e)
        {
            listaDatos.Items.Clear();
            int i = listOpciones.SelectedIndex;
            Event opcion = (Event)lista[i];
            var dataList = opcion.getSeeding();
            var sw = dataList.getSwimmers();
            foreach (Swimmer swimmer in sw)
            {
                listaDatos.Items.Add(swimmer.Data);
            }
        }
    }
}
