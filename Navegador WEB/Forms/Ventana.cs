using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using NavegadorWEB.Forms;
using NavegadorWEB.Clases;
using System.IO;
using Microsoft.VisualBasic;
using System.Net;

namespace NavegadorWEB.Forms
{
    public partial class Ventana : Form
    {
        private string URL; // Variable para asignar una referencia en cache al url que escriba el usuario, sea absoluto o no.
        public Ventana()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ProgressBarDescarga.Visible = false;
            Thread actualizarVentanaConstantemente = new Thread(EsperaQueSeTermineDeCargarLaVentana);
            actualizarVentanaConstantemente.SetApartmentState(ApartmentState.STA);
            actualizarVentanaConstantemente.Start();
        }
        public Thread HiloPestanna
        {
            get;
            set;
        }

        private void ToolStripButtonAtras_Click(object sender, EventArgs e)
        {
            WebBrowserPrincipal.GoBack();
        }

        private void ToolStripButtonAdelante_Click(object sender, EventArgs e)
        {
            WebBrowserPrincipal.GoForward();
        }

        private void ToolStripButtonRecargar_Click(object sender, EventArgs e)
        {
            WebBrowserPrincipal.Refresh();
        }

        private void ToolStripButtonBuscar_Click(object sender, EventArgs e)
        {
            HacerBuesqueda();
        }

        private void WebBrowserPrincipal_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            try
            {
                string link = e.Url.AbsoluteUri;
                if (link.ToLower().Contains("download") || link.ToLower().Contains("resource"))
                {
                    e.Cancel = true;

                    if (!Contenedor.Descargando)
                    {
                        object ventana = Interaction.InputBox("Digite el nombre del archivo más el tipo(Ej: .pdf, .exe, ...)", "Guardar", "");
                        if ((string)ventana == "")
                        {
                            MessageBox.Show("Debe escribir el nombre del archivo.");
                        }
                        else
                        {
                            try
                            {
                                string nombre = (string)ventana;
                                string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\downloads\\";

                                Contenedor.Descargando = true;
                                ProgressBarDescarga.Value = 0;
                                ProgressBarDescarga.Visible = true;
                                WebClient wc = new WebClient();
                                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
                                wc.DownloadFileAsync(e.Url, downloadsPath + nombre);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una descarga en proceso");
                    }

                }
            }
            catch (NotSupportedException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            ProgressBarDescarga.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            ProgressBarDescarga.Visible = false;
            Contenedor.Descargando = false;
        }

        private void WebBrowserPrincipal_DocumentCompleted1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webbrowser = (WebBrowser)sender;
            Mutex mutex = new Mutex();
            if (webbrowser.ReadyState == WebBrowserReadyState.Complete)
            {
                mutex.WaitOne();
                Contenedor.Cache.Set(ToolStripTextBoxURL.Text, webbrowser.DocumentStream, DateTimeOffset.Parse("11:59 PM"));
                mutex.ReleaseMutex();
            }
            else
            {
                ((TabPage)((WebBrowser)sender).Parent.Parent).Text = "Cargando...";
            }
        }

        private void WebBrowserPrincipal_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webbrowser = (WebBrowser)sender;
            ((TabPage)(webbrowser.Parent.Parent)).Text = webbrowser.DocumentTitle;

            if (webbrowser.ReadyState == WebBrowserReadyState.Complete)
            {
                if (!webbrowser.Url.AbsoluteUri.Equals("about:blank"))
                {
                    try
                    {
                        ToolStripTextBoxURL.Text = webbrowser.Url.AbsoluteUri;
                    }
                    catch (Exception) { }

                }
                ToolStripTextBoxURL.BackColor = Color.White;
                Mutex mutex = new Mutex();
                mutex.WaitOne();
                Contenedor.Cache.Set(ToolStripTextBoxURL.Text, webbrowser.DocumentStream, DateTimeOffset.Parse("11:59 PM"));
                if (!URL.Equals(ToolStripTextBoxURL.Text))
                {
                    Contenedor.Cache.Set(URL, webbrowser.DocumentStream, DateTimeOffset.Parse("11:59 PM"));
                    Contenedor.Keys.Add(URL);
                }
                Contenedor.Keys.Add(ToolStripTextBoxURL.Text);
                URL = "";
                mutex.ReleaseMutex();
            }
            else
            {
                ((TabPage)(((WebBrowser)sender).Parent.Parent)).Text = "Cargando...";
            }
        }

        private void ToolStripButtonNuevaPestanna_Click(object sender, EventArgs e)
        {
            Mutex mutex = new Mutex();
            mutex.WaitOne();
            Thread.Sleep(50);
            Contenedor.AbrirPestanna = true;
            Thread.Sleep(50);
            mutex.ReleaseMutex();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            //Esta linea permite ejecutar varios hilos diferentes al hilo principal
            CheckForIllegalCrossThreadCalls = false;
        }
        private void ToolStripButtonCerrar_Click(object sender, EventArgs e)
        {
            Mutex mutex = new Mutex();
            mutex.WaitOne();
            Thread.Sleep(50);
            Contenedor.CerrarPestanna = true;
            HiloPestanna.Abort();
            Thread.Sleep(50);
            mutex.ReleaseMutex();
        }

        private void ToolStripMenuItemHistorial_Click(object sender, EventArgs e)
        {
            Mutex mutex = new Mutex();
            mutex.WaitOne();
            Thread.Sleep(50);
            Contenedor.AbrirHistorial = true;
            Thread.Sleep(50);
            mutex.ReleaseMutex();
        }

        private void ToolStripMenuItemCache_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea borrar el cache de la aplicación?", "Confirmacion", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                for (int i = 0; i < Contenedor.Keys.Count; i++)
                {
                    Contenedor.Cache.Remove(Contenedor.Keys[i]);
                }
                Contenedor.Keys.Clear();
            }
        }

        private void HacerBuesqueda()
        {
            if (ToolStripTextBoxURL.TextLength > 2)
            {
                try
                {
                    Mutex mutex = new Mutex();
                    WebBrowserPrincipal.Navigating += WebBrowserPrincipal_Navigating;
                    if (Contenedor.Cache.Get(ToolStripTextBoxURL.Text) == null)
                    {
                        WebBrowserPrincipal.Navigate(ToolStripTextBoxURL.Text);
                        WebBrowserPrincipal.DocumentCompleted += WebBrowserPrincipal_DocumentCompleted;
                        URL = ToolStripTextBoxURL.Text;
                    }
                    else
                    {
                        mutex.WaitOne();
                        WebBrowserPrincipal.DocumentStream = (Stream)Contenedor.Cache.Get(ToolStripTextBoxURL.Text);
                        WebBrowserPrincipal.DocumentCompleted += WebBrowserPrincipal_DocumentCompleted1; ;
                        mutex.ReleaseMutex();
                    }


                    mutex.WaitOne();
                    Thread.Sleep(50);
                    Contenedor.Busqueda = ToolStripTextBoxURL.Text;
                    Contenedor.BusquedaEcha = true;
                    Thread.Sleep(50);
                    mutex.ReleaseMutex();
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void EsperaQueSeTermineDeCargarLaVentana()
        {
            Thread.Sleep(4000);
            ToolStripTextBoxURL.Text = Contenedor.Busqueda;
            HacerBuesqueda();
            Thread.CurrentThread.Abort();
        }
    }
}
