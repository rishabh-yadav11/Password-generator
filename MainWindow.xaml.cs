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
using System.Security.Cryptography;



namespace Password_generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    
    public partial class MainWindow : Window
    {

                                        //num  lChars   Uchars  Symbols
        
        private readonly string Num = "0123456789";
        private readonly string LChar = "abcdefghijklmnopqrstuvwxyz";
        private readonly string uChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string Symbols = "!\"#$%&\\[]^_`'()*+,-./:;<=>?@{|}~";
        private string TempString="";
        Random Random=new Random();


        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void BttnGen_Click(object sender, RoutedEventArgs e)
        {
            CheckSelctions();
            display.Text =  pwdgen();
           
            
            
            
        }
        private string pwdgen()
        {
            string pwd ="";
            int length = Convert.ToInt32(slValue.Value);
            int Tempstringlen;
            if (TempString.Length == 0)
            {
                pwd = "Enter Something";

            }
            else {



                Tempstringlen = TempString.Length - 1;
                for (int i = 0; i < length;i++)
                {
                    pwd += TempString[Random.Next(0, Tempstringlen)];

                }

            }



            return pwd;

        }



        

        private void CheckSelctions()
        {
#pragma warning disable CS8629 // Nullable value type may be null.
            if ((bool)CheckNumbers.IsChecked)
            {
                TempString = TempString + Num;
            }


            if ((bool)ChecklowerChar.IsChecked)
            {
                TempString = TempString + LChar;
            }

            if ((bool)CheckupperChar.IsChecked)
            {
                TempString = TempString + uChar;
            }

            if ((bool)CheckSymbol.IsChecked)
            {
                TempString = TempString + Symbols;
            }
        }
#pragma warning restore CS8629 // Nullable value type may be null.
    }
}
