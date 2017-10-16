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
using System.Windows.Shapes;

namespace PrincipalProjetoFinal
{
    /// <summary>
    /// Interaction logic for Ranking.xaml
    /// </summary>
    public partial class Ranking : Window
    {
        public Ranking(List<Classificar> ranking, List<Usuario> usuarios)
        {
            InitializeComponent();
            //dgRanking.ItemsSource = ranking.OrderByDescending(user => user.ClassificarUsuario);
            dgRanking.ItemsSource = usuarios.OrderByDescending(user => user.Classificacao);
            //dgRanking.ItemsSource = ranking;
            //dgRanking.ItemsSource = usuarios;
        }        
    }
}
