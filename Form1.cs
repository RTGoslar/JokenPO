using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokenPo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame(0);
            lblVoce.Visible = false;
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartGame(2);
            lblVoce.Visible = false;
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartGame(1);
            lblVoce.Visible = false;
        }

        private void StartGame(int opcao)
        {
            lblResultado.Visible = false;
            lblPc.Visible = false;
            Game jogo = new Game();

            switch (jogo.Jogar(opcao))
            {
                case Game.Resultado.Ganhar:
                    picResultado.BackgroundImage = Image.FromFile("Imagens/Ganhar.png");
                    goto default;
                case Game.Resultado.Perder:
                    picResultado.BackgroundImage = Image.FromFile("Imagens/Perder.png");
                    goto default;
                case Game.Resultado.Empatar:
                    picResultado.BackgroundImage = Image.FromFile("Imagens/Empatar.png");
                    goto default;
                default:
                    picVoce.Image = jogo.ImgJogador;
                    picPc.Image = jogo.ImgPC;
                    break;
            }
        }
    }
}
