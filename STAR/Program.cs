using System;using System.Windows.Forms;namespace STAR{static class Program{[STAThread]static void Main(){ApplicationConfiguration.Initialize();Application.Run(new Forms.SplashForm());}}}
