using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using EduAccesoApp.Controller;
using EduAccesoApp.Model;
using MessageBox.Avalonia;

namespace EduAccesoApp.View;


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
}


    private async void btnLogin_Click(object? sender, RoutedEventArgs e)
    {
        var correo = txtCorreo.Text;
        var clave = txtClave.Text;

        UsuarioController controller = new UsuarioController();
        Usuario? usuario = controller.Login(correo, clave);

        if (usuario != null)
        {
            await MessageBoxManager
                .GetMessageBoxStandardWindow("Bienvenido", $"Hola, {usuario.nombre}")
                .ShowDialog(this);

            var panel = new PanelAdministrador();
            panel.Show();
            this.Close();
        }
        else
        {
            await MessageBoxManager
                .GetMessageBoxStandardWindow("Error", "Correo o contraseña incorrectos.")
                .ShowDialog(this);
        }
    }
}
