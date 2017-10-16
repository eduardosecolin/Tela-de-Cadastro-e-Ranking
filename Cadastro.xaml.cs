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
    /// Interaction logic for Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        //LISTAS
        List<Usuario> listaUsuario;
        List<Classificar> listaClas;

        public Cadastro(List<Classificar> listaClas, List<Usuario> listaUsuario)
        {
            this.listaClas = listaClas;
            this.listaUsuario = listaUsuario;
            InitializeComponent();
        }
        public void atualizarUsuario()
        {
            lsUsuario.ItemsSource = null;
            lsUsuario.ItemsSource = listaUsuario;
            lsUsuario.DisplayMemberPath = "Nome";
            cbUsuario.ItemsSource = null;
            cbUsuario.ItemsSource = listaUsuario;
            cbUsuario.DisplayMemberPath = "Nome";
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Usuario u = new Usuario();
            u.Id = int.Parse(txtId.Text);
            u.Nome = txtNome.Text;
            u.Sexo = cbSexo.Text;
            u.Dia = byte.Parse(txtDia.Text);
            u.Mes = byte.Parse(txtMes.Text);
            u.Ano = int.Parse(txtAno.Text);

            listaUsuario.Add(u);
            atualizarUsuario();
        }

        private void btnClassificar_Click(object sender, RoutedEventArgs e)
        {
            Classificar c = new Classificar();
            c.ClassificarUsuario = (Usuario)cbUsuario.SelectedItem;
            c.ClassificarUsuario.Classificacao = byte.Parse(txtClassificacao.Text);
            c.ClassificarUsuario.Comentar = txtComentar.Text;

            listaClas.Add(c);
            atualizarUsuario();
        }

        private void btnVisualizar_Click(object sender, RoutedEventArgs e)
        {
            string y = null;
            string x = null;
            foreach (Usuario item in listaUsuario)
            {
                x = item.imprimir();
                MessageBox.Show(x);
            }            
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            Usuario u = (Usuario)lsUsuario.SelectedItem;
            listaUsuario.Remove(u);
            atualizarUsuario();
        }

       
    }
}
