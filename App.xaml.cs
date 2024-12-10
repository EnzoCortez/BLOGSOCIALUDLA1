using BLOGSOCIALUDLA.Data;
using BLOGSOCIALUDLA.Models;
using BLOGSOCIALUDLA.Views;

namespace BLOGSOCIALUDLA
{
    public partial class App : Application
    {
        static SQLiteData? _bancoDatos;

        public App()
        {
            InitializeComponent();
             
            var navPage = new NavigationPage(new InicioSesion());
            navPage.Background = Colors.DarkRed;
            navPage.BarTextColor = Colors.DarkRed;

            
            MainPage = new AppShell();
           
        }
      public static SQLiteData BancoDatos
        {

            get
            {
                if (_bancoDatos == null)
                {
                    _bancoDatos = new SQLiteData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Datos.db"));
                     
                }
                return _bancoDatos;
            }
        }

        public static User Usuario { get; set; }

    }

}
