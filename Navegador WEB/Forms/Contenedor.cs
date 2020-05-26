using NavegadorWEB.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorWEB.Forms
{
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Busqueda = "";// estas propiedades, son las compartidas por todos los hilos
            CerrarPestanna = false; // estas propiedades, son las compartidas por todos los hilos
            AbrirPestanna = false;// estas propiedades, son las compartidas por todos los hilos
            BusquedaEcha = false;// estas propiedades, son las compartidas por todos los hilos
            FinalizarEsteHilo = false; // estas propiedades, son las compartidas por todos los hilos
            AbrirHistorial = false;// estas propiedades, son las compartidas por todos los hilos
            pestannasHilos = new List<Thread>();// estas propiedades, son las compartidas por todos los hilos
            ListaHistorial = new List<Historial>();// estas propiedades, son las compartidas por todos los hilos
            Descargando = false;
            Cache = new MemoryCache("cache");
            Keys = new List<string>();

            //este hilo lo que hace es revizar constantemente si hay cambios, como ventanas nuevas

            //abiertas, cerradas, habrir historial
            Thread actualizarVentanaConstantemente = new Thread(ActualizarVentanaConstantemente);
            actualizarVentanaConstantemente.SetApartmentState(ApartmentState.STA);
            actualizarVentanaConstantemente.Start();

            CrearNuevaPesanna();

        }
        private List<Thread> pestannasHilos;

        public static string Busqueda
        {
            get;
            set;
        }
        public static List<Historial> ListaHistorial
        {
            get;
            set;
        }
        public static Boolean BusquedaEcha
        {
            get;
            set;
        }
        public static Boolean CerrarPestanna
        {
            get;
            set;
        }
        public static Boolean AbrirPestanna
        {
            get;
            set;
        }
        public static Boolean FinalizarEsteHilo
        {
            get;
            set;
        }
        public static Boolean AbrirHistorial
        {
            get;
            set;
        }
        public static Boolean Descargando
        {
            get;
            set;
        }
        public static List<string> Keys
        {
            get;
            set;
        }
        public static MemoryCache Cache
        {
            get;
            set;
        }

        private void NuevaPestanna()// ahora en el hilo nuevo, se crea un form y se carga al form principal 
        {
            Ventana ventanaNueva = new Ventana();
            ventanaNueva.TopLevel = false;
            ventanaNueva.HiloPestanna = pestannasHilos.Last();

            TabPage tabPage = new TabPage(Busqueda);

            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    tabPage.Controls.Add(ventanaNueva);
                    tabControl1.Controls.Add(tabPage);
                    tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                    ventanaNueva.Show();
                }));
            }
        }

        private void CrearNuevaPesanna() // se crea un hilo donde se va a cargar la nueva pestaña
        {
            Thread hiloNuevaPestanna = new Thread(NuevaPestanna);
            hiloNuevaPestanna.SetApartmentState(ApartmentState.STA);

            Mutex mutex = new Mutex();
            mutex.WaitOne();
            Thread.Sleep(50);
            AbrirPestanna = false;

            pestannasHilos.Add(hiloNuevaPestanna);
            Thread.Sleep(50);
            mutex.ReleaseMutex();
            hiloNuevaPestanna.Start();
        }
        private void ActualizarVentanaConstantemente()
        {
            while (true)
            {
                if (AbrirPestanna)
                {
                    CrearNuevaPesanna();
                }
                if (CerrarPestanna)
                {
                    ElinimarPestanna();
                    if (tabControl1.Controls.Count == 0)
                    {
                        Application.Exit();
                    }
                }
                if (BusquedaEcha)
                {
                    CambiarTituloDeVentana();
                }
                if (AbrirHistorial)
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() =>
                        {
                            Mutex mutex = new Mutex();
                            mutex.WaitOne();
                            Thread.Sleep(50);
                            AbrirHistorial = false;
                            ListaHistorial.Count();
                            Thread.Sleep(50);
                            mutex.ReleaseMutex();
                            HistorialMenu historial = new HistorialMenu();
                            historial.Show();
                        }));
                    }
                }
                if (FinalizarEsteHilo)
                {
                    Thread.CurrentThread.Abort();
                }
                Thread.Sleep(100);
            }
        }
        private void ElinimarPestanna()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => tabControl1.Controls.Remove(tabControl1.SelectedTab)));
            }
            Mutex mutex = new Mutex();
            mutex.WaitOne();
            Thread.Sleep(50);
            CerrarPestanna = false;
            Thread.Sleep(50);
            mutex.ReleaseMutex();
        }
        private void CambiarTituloDeVentana()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => tabControl1.SelectedTab.Text = Busqueda));
            }
            Mutex mutex = new Mutex();
            mutex.WaitOne();
            Thread.Sleep(50);
            BusquedaEcha = false;

            Historial historial = new Historial();
            historial.DirecionWEB = Busqueda;
            historial.Fecha = DateTime.Now;
            ListaHistorial.Add(historial);
            ListaHistorial.Count();
            Busqueda = "";
            Thread.Sleep(50);
            mutex.ReleaseMutex();


        }

        private void Contenedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mutex mutex = new Mutex();
            mutex.WaitOne();
            Thread.Sleep(50);
            FinalizarEsteHilo = true;
            mutex.ReleaseMutex();
            Thread.Sleep(50);
            Application.Exit();
        }
    }

}
