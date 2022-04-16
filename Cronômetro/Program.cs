using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cronômetro {
    internal class Program {
        static void Main(string[] args) {
            iniciar();
            //Console.ReadLine();
        }

        static void iniciar() {
            int tempo = 10;
            int tempoAtual = 0;

            while (tempoAtual != tempo) { 
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }
        }
    }
}
