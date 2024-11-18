using System;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace C__Sprint1_Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        Random code = new Random();
        public MainWindow()
        {
            InitializeComponent();
            GenerateCode();
            AddColor();
            toggledebug();
            startcountdown();
            timer.Tick += Button_Click; //Event koppelen
            timer.Interval = new TimeSpan(0, 0, 1); //Elke seconde
            timer.Start();
        }


        /// <summary>
        /// <para> De methode GenerateCode wordt gebruikt 
        /// om een random code van 4 kleuren te genereren </para>
        /// <para> Om het spel makkelijker te testen wordt deze code 
        /// in de titel van het window getoond </para>
        /// </summary>
        private void GenerateCode()

        {

            const int numberOfColorsCode = 4;
            const int minNumber = 1;
            const int maxNumber = 7;
            int colorRed = 1;
            int colorYellow = 2;
            int colorOrange = 3;
            int colorWhite = 4;
            int colorGreen = 5;

            for (int i = 1; i <= numberOfColorsCode; i++)
            {
                int colorCode = code.Next(minNumber, maxNumber);
                if (colorCode == colorRed)
                {
                    this.Title += " Red";
                }
                else if (colorCode == colorYellow)
                {
                    this.Title += " Yellow";
                }
                else if (colorCode == colorOrange)
                {
                    this.Title += " Orange";
                }
                else if (colorCode == colorWhite)
                {
                    this.Title += " White";
                }
                else if (colorCode == colorGreen)
                {
                    this.Title += " Green";
                }
                else
                {
                    this.Title += " Blue";
                }
            }
        }

        /// <summary>
        /// De 4 comboboxen worden gevuld met de 6 beschikbare kleuren.
        /// </summary>
        private void AddColor()
        {
            comboBox1.Items.Add(new SolidColorBrush(Colors.Red));
            comboBox1.Items.Add(new SolidColorBrush(Colors.Yellow));
            comboBox1.Items.Add(new SolidColorBrush(Colors.Orange));
            comboBox1.Items.Add(new SolidColorBrush(Colors.White));
            comboBox1.Items.Add(new SolidColorBrush(Colors.Green));
            comboBox1.Items.Add(new SolidColorBrush(Colors.Blue));

            comboBox2.Items.Add(new SolidColorBrush(Colors.Red));
            comboBox2.Items.Add(new SolidColorBrush(Colors.Yellow));
            comboBox2.Items.Add(new SolidColorBrush(Colors.Orange));
            comboBox2.Items.Add(new SolidColorBrush(Colors.White));
            comboBox2.Items.Add(new SolidColorBrush(Colors.Green));
            comboBox2.Items.Add(new SolidColorBrush(Colors.Blue));

            comboBox3.Items.Add(new SolidColorBrush(Colors.Red));
            comboBox3.Items.Add(new SolidColorBrush(Colors.Yellow));
            comboBox3.Items.Add(new SolidColorBrush(Colors.Orange));
            comboBox3.Items.Add(new SolidColorBrush(Colors.White));
            comboBox3.Items.Add(new SolidColorBrush(Colors.Green));
            comboBox3.Items.Add(new SolidColorBrush(Colors.Blue));

            comboBox4.Items.Add(new SolidColorBrush(Colors.Red));
            comboBox4.Items.Add(new SolidColorBrush(Colors.Yellow));
            comboBox4.Items.Add(new SolidColorBrush(Colors.Orange));
            comboBox4.Items.Add(new SolidColorBrush(Colors.White));
            comboBox4.Items.Add(new SolidColorBrush(Colors.Green));
            comboBox4.Items.Add(new SolidColorBrush(Colors.Blue));
        }

        /// <summary>
        /// Wanneer er een kleur gekozen wordt uit een combobox 
        /// wordt deze getoond in een label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Deze parameter bevat informatie over de selectie van de gebruiker, 
        /// zoals het nieuwe geselecteerde item en de vorige selectie.</param>
        private void ComboboxSelection(object sender, SelectionChangedEventArgs e)
        {


            if (sender == comboBox1)
            {
                showColor.Content = ((SolidColorBrush)comboBox1.SelectedItem).Color.ToString();
                showColor.Background = ((SolidColorBrush)comboBox1.SelectedItem);
            }
            else if (sender == comboBox2)
            {
                showColor.Content = ((SolidColorBrush)comboBox2.SelectedItem).Color.ToString();
                showColor.Background = ((SolidColorBrush)comboBox2.SelectedItem);
            }
            else if (sender == comboBox3)
            {
                showColor.Content = ((SolidColorBrush)comboBox3.SelectedItem).Color.ToString();
                showColor.Background = ((SolidColorBrush)comboBox3.SelectedItem);
            }
            else if (sender == comboBox4)
            {
                showColor.Content = ((SolidColorBrush)comboBox4.SelectedItem).Color.ToString();
                showColor.Background = ((SolidColorBrush)comboBox4.SelectedItem);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var attempts = 0;
            for (int i = 1; i < 100; i++)
            {
                attempts++;
                this.Title += $"{attempts}";
            }
            /// <summary>
            /// Deze TextBox is enkel zichtbaar in debug-mode.
            /// </summary>
            /// <param name="code">Hier is een random code van 4 kleuren gegenereerd.</param>
            /// 
            private void toggledebug()
            {
                toggleTextBox.Text = $"{code}";
            }
            /// <summary>
            /// de timer telkens opnieuw vanaf 1 wanneer de speler een poging heeft.
            /// </summary>
            private void startcountdown()
            {

            }
            /// <summary>
            /// Wanneer de speler niet binnen de tijd op de knop "Check code" 
            /// klikt verliest hij zijn beurt.
            /// </summary>
            private void stopcountdown()
            {

            }
        }
    }
}
