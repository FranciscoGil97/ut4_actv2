using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            
            verHeroes.DataContext = superheroes[numeroActualSuperHeroe-1];
            numeroSuperheroes.Text = numeroActualSuperHeroe + "/" + superheroes.Count;

            

        }

        private void SiguienteSuperheroe_Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (numeroActualSuperHeroe < superheroes.Count)
            {
                numeroSuperheroes.Text = ++numeroActualSuperHeroe + "/" + superheroes.Count;
                verHeroes.DataContext = superheroes[numeroActualSuperHeroe - 1];
            }
            

        }
        private void AnteriorSuperheroe_Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (1<numeroActualSuperHeroe)
            {
                numeroSuperheroes.Text = --numeroActualSuperHeroe + "/" + superheroes.Count;
                verHeroes.DataContext = superheroes[numeroActualSuperHeroe - 1];
            }
        }
    }
}
