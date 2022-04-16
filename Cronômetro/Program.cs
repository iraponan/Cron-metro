using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cronômetro {
    internal class Program {
        static void Main(string[] args) {

            menu();
        }

        static void menu() {
            Console.Clear();
            Console.Write("###--- CRONÔMETRO ---###\n" +
                "Os parâmetros tempo disponíveis são:\n" +
                "   S - Segundos\n" +
                "   M - Minutos\n" +
                "   H - Horas\n" +
                "   0 - Para Sair do Sistema\n" +
                "Para escolher o tempo que deseja executar o cronômetro, basta informar o tempo em número\ne o parâmetro logo em seguida,como nos exemplos abaixo:\n" +
                "Para 10 segundos informe => 10s\n" +
                "Para 30 minutos informe => 30m\n" +
                "Para 1 hora informe => 1h\n" +
                "Quanto tempo deseja rodar o cronômetro? ");
            string valorInformado = Console.ReadLine().ToLower();
            if (valorInformado == "0" || valorInformado.Equals("0")) {
                for (int i = 5; i > 0; i--) {
                    Console.WriteLine("Saindo do sistema em: " + i);
                    Thread.Sleep(1000);
                }
                System.Environment.Exit(0);
            }
            if (valorInformado.Length == 1) {
                Console.WriteLine("Daos informados incorretos!!!\nPor favor tente novamente...");
                Thread.Sleep(3000);
                menu();
            }
            else {
                char parametroTempoInformado = char.Parse(valorInformado.Substring(valorInformado.Length - 1, 1));
                int tempoInformado = int.Parse(valorInformado.Substring(0, valorInformado.Length - 1));
                preparar(calculandoTempo(parametroTempoInformado, tempoInformado));
            }
        }

        static int calculandoTempo(char parametroTempoInformado, int tempoInformado) {
            int tempo = 0;
            switch (parametroTempoInformado) {
                case 's':
                    tempo = tempoInformado;
                    break;
                case 'm':
                    tempo = tempoInformado * 60;
                    break;
                case 'h':
                    tempo = tempoInformado * 60 * 60;
                    break;
            }
            return tempo;
        }

        static void preparar(int tempo) {
            Console.Clear();
            Console.WriteLine("Iniciando o Cronônometro....");
            Thread.Sleep(1000);
            Console.WriteLine("Preparar!");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar!!");
            Thread.Sleep(1000);
            Console.WriteLine("VAI!!!");
            Thread.Sleep(1000);

            iniciar(tempo);
        }

        static void iniciar(int tempo) {
            int tempoAtual = 0;

            while (tempoAtual != tempo) { 
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronômetro Finalizado\nRetornando para o menu...");
            Thread.Sleep(2000);
            menu();
        }
    }
}
