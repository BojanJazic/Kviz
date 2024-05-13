using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
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
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;

namespace Kviz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] pitanjaKojaSuBila = new int[11];
        Random rnd = new Random();
        public  int tmp = 0;
        public  int brojac = 0;
        public  int redniBrojPitanja = 1;
        public static int brojTacnihOdgovora = 0;
        List<Model> podaci = PristupPodacima.getDataFromDB();
        public static List<String> wrongAnswers = new List<String>();
        public static int BROJ_PITANJA_U_BAZI = 20;
        

        public MainWindow()
        {
            tmp = rnd.Next(BROJ_PITANJA_U_BAZI) + 1; 
            pitanjaKojaSuBila[brojac++] = tmp;
            InitializeComponent();
            getQuestion(tmp);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        public void getQuestion(int serialNumber)
        {
            foreach(Model model in podaci)
            {
                if(model.RedniBroj == serialNumber)
                {
                    tbQuestion.Text = (redniBrojPitanja++) + ". " +  model.Pitanje;
                    btnAnswer1.Content = model.Odgovor1;
                    btnAnswer2.Content = model.Odgovor2;
                    btnAnswer3.Content = model.Odgovor3;
                    btnAnswer4.Content = model.Odgovor4;
                }
            }
        }

        private void chooseAnswer(object sender, EventArgs e)
        {                 
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            string choosenAnswer = senderObject.Content.ToString();

            if(!checkAnswer(pitanjaKojaSuBila[brojac - 1], choosenAnswer))
            { 
                 wrongAnswers.Add(tbQuestion.Text.ToString() + "\nIzabran odgovor: " + choosenAnswer + "\nTačan odgovor: " + PristupPodacima.getCorrectAnswer(pitanjaKojaSuBila[brojac-1]) + '\n');
                 
            }
            else
            {
                brojTacnihOdgovora++;
            }

            int pitanje = 0;
           
            do
            {
                pitanje = novoPitanje(rnd.Next(BROJ_PITANJA_U_BAZI) + 1);
            } while (pitanje == -1);

            if (brojac < 11)
            {
                getQuestion(pitanje);
                percentage.Value += 1;    
            }
            if (brojac > 10)
            {     
                //new WrongAnswers().ShowDialog();
                WrongAnswers wa = new WrongAnswers();
                wa.Owner= this;
                this.Hide();
                wa.ShowDialog();
            }
        }

        private int novoPitanje(int tmp)
        {
            Boolean check = true;   
   
            foreach(int i in pitanjaKojaSuBila) {
               if (i == tmp)
                    check = false;    
            }
            if (check)
            {
                pitanjaKojaSuBila[brojac++] = tmp;
                return tmp;
            }


            return -1;
        }

        private bool checkAnswer(int redniBroj, String choosenAnswer)
        {
           
            if (choosenAnswer.Equals(PristupPodacima.getCorrectAnswer(redniBroj)))
            {
                return true;
            }

            return false;
        }

    }
}
