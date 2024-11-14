using System;

namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        int jogadas = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            jogadas++;

            if (jogadas >= 5 && VerificaVencedor())
            {
                DisplayAlert("Parabéns", $"{btn.Text} ganhou!", "OK");
                Zerar();
            }
            else if (jogadas == 9)
            {
                DisplayAlert("Empate", "O jogo terminou em empate!", "OK");
                Zerar();
            }    
        } //Fecha método

        bool VerificaVencedor()
        {
            if (btn10.Text == btn11.Text && btn11.Text == btn12.Text && btn10.Text != "")
                return true;
            if (btn20.Text == btn21.Text && btn21.Text == btn22.Text && btn20.Text != "")
                return true;
            if (btn30.Text == btn31.Text && btn31.Text == btn32.Text && btn30.Text != "")
                return true;

            if (btn10.Text == btn20.Text && btn20.Text == btn30.Text && btn10.Text != "")
                return true;
            if (btn11.Text == btn21.Text && btn21.Text == btn31.Text && btn11.Text != "")
                return true;
            if (btn12.Text == btn22.Text && btn22.Text == btn32.Text && btn12.Text != "")
                return true;

            if (btn10.Text == btn21.Text && btn21.Text == btn32.Text && btn10.Text != "")
                return true;
            if (btn12.Text == btn21.Text && btn21.Text == btn30.Text && btn12.Text != "")
                return true;

            return false;
        }
        void Zerar() 
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = ""; 
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true; 
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            jogadas = 0;
        }
    }// Fecha Classe
}//Fecha Namespace
