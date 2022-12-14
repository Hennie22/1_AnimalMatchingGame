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

namespace _1_AnimalMatchingGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();



            // ❤✡🦢🦜🦚🐧🚗🚲😂😀😑😮🐵🐶🦁🐴🦓🐒🦏🐪🐘🐕🐍🐇🐟🐠🦜🦀🦋🐄🦛🦏 mbv raampje punt van Windows
            // 🐻🦁🐘🐈🐟🐕‍🦺🐒🐧🦜🦢🦚❤💛💙✝🔴🟡🔷🔶 uit WhatsApp gekopieerd, kleuren edm verdwijnt
            // 
        }

        private void SetUpGame()
        {
            //throw new NotImplementedException();

            List<string> animalEmoji = new List<string>()
            {
                "🦏","🦏",
                "🐪","🐪",
                "🐘","🐘",
                "🐕","🐕",
                "🐍","🐍",
                "🐇","🐇",
                "🐟","🐟",
                "🦋","🦋",
            };
            Random random = new Random();
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }
        }


        TextBlock lastTextBlockClicked;
        private bool findingMatch = false; //was:  bool findingMatch = false; 

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible; findingMatch = false;
            }
        }

    }
}
