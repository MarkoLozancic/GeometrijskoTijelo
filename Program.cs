
using System;
/*Definirajte klasu GeometrijskoTijelo sa sljedećim varijablama članicama:
• varijable tipa double Volumen i Oplosje
• statička varijabla tipa int BrojacTijela
Definirajte klase Kugla i Kvadar izvedene iz klase GeometrijskoTijelo.
Definirajte klasu Kocka izvedenu iz klase Kvadar.
Definirajte objekte x, y i z tipova Kugla, Kvadar i Kocka i povećajte vrijednost varijable
BrojacTijela za 1 sa svakom definicijom objekta.*/
namespace NasljedivanjeSamostalniRad
{
    class GeometrijskoTijelo
    {
        double Volumen;
        double Oplosje;
        public static int brojacTijela;

        public double Volumen1 { get => Volumen; set => Volumen = value; }
        public double Oplosje1 { get => Oplosje; set => Oplosje = value; }
    
        public GeometrijskoTijelo(double volumen, double oplosje)
        {
            Volumen = volumen;
            Oplosje = oplosje;
        }
        public GeoTijelo()
        {
            brojacTijela++;
        }

    }
    class Kugla:GeometrijskoTijelo
    {

    }
    class Kvadar : GeometrijskoTijelo
    { 

    }
    class Kocka : Kvadar
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GeoTijelo.brojacTijela);
            Kugla x = new Kugla();

            Console.WriteLine(GeoTijelo.brojacTijela);
            Kvadar y = new Kvadar();

            Console.WriteLine(GeoTijelo.brojacTijela);
            Kocka z = new Kocka();
           

            Console.ReadKey();

        }
    }
}
