
using System.Windows;
using System.Windows.Input;

namespace LEDisplay
{
    /// <summary>
    /// Logique d'interaction pour WindowChoixDuPort.xaml
    /// </summary>
    public partial class WindowChoixDuPort : Window
    {
        public WindowChoixDuPort()
        {
            InitializeComponent();
        }
        void Close_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        public class LePort
        {
            public string Nom
            {

                get
                {
                    return null;
                }

                set
                {
                }

            }

            public string NomComplet
            {

                get
                {
                    return null;
                }

                set
                {
                }

            }

            public string Detail
            {

                get
                {
                    return null;
                }

                set
                {
                }

            }

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
