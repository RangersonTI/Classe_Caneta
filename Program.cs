using System;
using System.IO;

namespace C.Caneta
{
    class Program
    {
        public static void Main(string[] args)
        {

            Caneta C = new Caneta();
            Caneta H = new Caneta();
            Caneta f = new Caneta();

            C.Cor = "Verde";
            C.Tamanho = 14;
            C.Peso = 30;
            C.Tampada = true;
            C.PercentCarga = 87;
            C.Marca = "Bic";
            C.Material = "Acrílico";
            C.Ponta = 3.7;
            C.tipoPonta = "Esferica";
            C.caida = false;
            C.estourada = true;

            H.Cor = "Azul";
            H.Tamanho = 13;
            H.Peso = 21;
            H.Tampada = false;
            H.PercentCarga = 6;
            H.Marca = "Bic";
            H.Material = "Fibra de Carbono";
            H.Ponta = 3.7;
            H.tipoPonta = "Esponja";
            H.caida = false;
            H.estourada = false;

            Console.WriteLine("Caneta Esferiografica\n");
            C.Status();
            C.Escrever();
            Console.WriteLine("\nCaneta Hidrografica");
            H.Status();
            H.Escrever();

        }
        public class Caneta
        {
            public string Cor;
            public double Tamanho;
            public double Peso;
            public bool Tampada;
            public int PercentCarga;
            public string Marca;
            public string Material;
            public double Ponta;
            public string tipoPonta;
            public bool caida;
            public bool estourada;

            public void Escrever()
            {
                if (caida == true)
                {
                    Console.WriteLine("\n Pegue a caneta ");
                }
                else
                {
                    if (estourada == true)
                    {
                        Console.WriteLine("\n Troque de caneta");
                    }
                    else
                    {
                        if (Tampada == true)
                        {
                            Console.WriteLine("\n Não é possível escrever, pois a caneta está tampada. Por favor destampe.");
                        }
                        else
                        {
                            Console.WriteLine("\n Comece a escrever");
                        }
                    }
                }
            }

            public void Destampar()
            {
                if (Tampada == true)
                {
                    Console.WriteLine("\n Destampe a caneta");
                }
                else
                {
                    Console.WriteLine("\n A caneta ja está destampada. Não é necessário. ");
                }
            }

            public void Tampar()
            {
                if (Tampada == true)
                {
                    Console.WriteLine("\n A caneta ja está tampada. Não é necessário.");
                }
                else
                {
                    Console.WriteLine("\n Tampe a caneta");
                }
            }

            public void Cair()
            {


            }

            public void Status()
            {

                Console.WriteLine();
                Console.WriteLine("Cor: " + Cor);
                Console.WriteLine("Tamanho: " + Tamanho);
                Console.WriteLine("Peso: " + Peso);
                Console.WriteLine("Tampada: " + Tampada);
                Console.WriteLine("Porc. Carga: " + PercentCarga);
                Console.WriteLine("Marca: " + Marca);
                Console.WriteLine("Materia: " + Material);
                Console.WriteLine("Ponta: " + Ponta);
                Console.WriteLine("Tipo de ponta: " + tipoPonta);
                Console.WriteLine("A caneta está caída? " + caida);
                Console.WriteLine("A caneta está estourada? " + estourada);
            }

        }
    }
}
