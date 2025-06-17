using Avalonia.Controls;
using Avalonia.Interactivity;
using EduAccesoApp.View;

namespace EduAccesoApp.View;

public partial class PanelAdministrador : Window
{
    public PanelAdministrador()
    {
        InitializeComponent();
    }

    private void AbrirUsuarios_Click(object? sender, RoutedEventArgs e)
    {
        // Aquí se abre la ventana del CRUD de usuarios
        var ventanaUsuarios = new UsuariosWindow(); // (deberás crearla)
        ventanaUsuarios.ShowDialog(this);
    }

    private void AbrirVisitantes_Click(object? sender, RoutedEventArgs e)
    {
        //var ventanaVisitantes = new VisitantesWindow(); // (deberás crearla)
        //ventanaVisitantes.ShowDialog(this);
    }

    private void AbrirVisitas_Click(object? sender, RoutedEventArgs e)
    {
        //var ventanaVisitas = new VisitasWindow(); // (deberás crearla)
        //ventanaVisitas.ShowDialog(this);
    }

    private void CerrarSesion_Click(object? sender, RoutedEventArgs e)
    {
        var login = new MainWindow();
        login.Show();
        this.Close();
    }
}
