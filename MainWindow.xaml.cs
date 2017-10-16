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

namespace PrincipalProjetoFinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Classificar> ranking = new List<Classificar>();
        List<Usuario> usuarios = new List<Usuario>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cadastro janelaCadastro = new Cadastro(ranking, usuarios);
            janelaCadastro.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ranking janelaRanking = new Ranking(ranking, usuarios);
            janelaRanking.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
