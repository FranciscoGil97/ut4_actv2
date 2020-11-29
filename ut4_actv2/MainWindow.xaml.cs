using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ut4_actv2
{
    public partial class MainWindow : Window
    {
        private int numeroActualSuperHeroe = 1;
        List<Superheroe> superheroes;
        public MainWindow()
        {
            InitializeComponent();

            superheroes = Superheroe.GetSamples();
            ActualizaVista(0);
        }

        private void SiguienteSuperheroe_Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (numeroActualSuperHeroe < superheroes.Count)
                ActualizaVista(1);
        }
        private void AnteriorSuperheroe_Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (1 < numeroActualSuperHeroe)
                ActualizaVista(-1);
        }

        private void ActualizaVista(int tipo)
        {
            numeroActualSuperHeroe += tipo;
            numeroSuperheroes.Text = (numeroActualSuperHeroe) + "/" + superheroes.Count;
            verHeroes.DataContext = superheroes[numeroActualSuperHeroe - 1];
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            bool esHeroe = (bool)heroeRadiobutton.IsChecked;
            bool esVengador = (bool)vengadoreCheckBox.IsChecked;
            bool esXmen = (bool)xmenCheckBox.IsChecked;

            superheroes.Add(new Superheroe(nombreSuperheroeTextBox.Text, urlImagenTextBox.Text, esVengador, esXmen, esHeroe, !esHeroe));

            MessageBox.Show("Se ha insertado el nuevo superhéroe");
            ActualizaVista(0);
            LimpiarButton_Click(null, null);
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            nombreSuperheroeTextBox.Text = "";
            urlImagenTextBox.Text = "";
            heroeRadiobutton.IsChecked = true;
            villanoRadiobutton.IsChecked = false;
            vengadoreCheckBox.IsChecked = false;
            xmenCheckBox.IsChecked = false;
        }

        private void VillanoRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            vengadoreCheckBox.IsEnabled = false;
            vengadoreCheckBox.IsChecked = false;
            xmenCheckBox.IsEnabled = false;
            xmenCheckBox.IsChecked = false;
        }

        private void VillanoRadiobutton_Unchecked(object sender, RoutedEventArgs e)
        {
            vengadoreCheckBox.IsEnabled = true;
            xmenCheckBox.IsEnabled = true;
        }
    }
}
