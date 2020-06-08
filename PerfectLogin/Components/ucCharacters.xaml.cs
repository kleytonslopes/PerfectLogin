using PerfectLogin.Model;
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

namespace PerfectLogin.Components
{
    /// <summary>
    /// Interaction logic for ucCharacters.xaml
    /// </summary>
    public partial class ucCharacters : UserControl
    {
        List<Character> Characters;

        public ucCharacters()
        {
            InitializeComponent();

            Characters = new List<Character>();
            Characters.Add(new Character { Name = "Test 1", AccountId = 1 });
            Characters.Add(new Character { Name = "Test 2", AccountId = 1 });
            Characters.Add(new Character { Name = "Test 3", AccountId = 1 });

            lbCharacters.ItemsSource = Characters;
        }
    }
}
