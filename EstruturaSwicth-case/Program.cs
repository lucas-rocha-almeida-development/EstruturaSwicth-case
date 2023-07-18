using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaSwicth_case {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um dia da semana: " );
            Console.WriteLine("\n");
            Console.WriteLine("Dias serão representados : 1= Domingo até 7 = Sabado ");
           int x = int.Parse(Console.ReadLine());

            string Dia;
            
            switch (x) {
                case 1:
                    Dia = "Domingo";
                    break;
                    case 2:
                    Dia = "Segunda-Feira";
                    break;
                case 3: 
                    Dia = "Terça-Feira";
                    break;

                    case 4:
                    Dia = "Quarta-Feira";
                                        break;

                case 5:
                    Dia = "Quinta-Feira";
                                        break;
                case 6:
                    Dia = "Sexta-Feira";
                                        break;
                    case 7:
                    Dia = "Sabado";
                    break;
                default:
                    Dia = "Valor incorreto!!";
                    break;

            }
            Console.WriteLine("Dia: " + Dia);
            Console.ReadKey();
        }
    }
}
