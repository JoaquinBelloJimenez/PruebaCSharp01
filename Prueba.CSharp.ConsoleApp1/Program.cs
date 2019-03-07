using System;

namespace Lab01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Metro metros = new Metro() { Medida = 100 };

            Pulgada pulgadas = Conversor.ToPulgadas(metros);

            Console.WriteLine(pulgadas.Medida.ToString("N2"));     //Pinta 3.937,00

            Console.ReadKey();
        }
    }


    public interface ILongitud
    {
        decimal Medida { get; set; }
    }

    //TODO Crea una clase llamada Kilometro que implemente la interfaz ILongitud
    public class Kilometro : ILongitud
    {
        public decimal Medida { get; set; }
    }

    //TODO Crea una clase llamada Metro que implemente la interfaz ILongitud
    public class Metro : ILongitud
    {
        public decimal Medida { get; set; }
    }

    //TODO Crea una clase llamada Centimetro que implemente la interfaz ILongitud
    public class Centimetro : ILongitud
    {
        public decimal Medida { get; set; }
    }

    //TODO Crea una clase llamada Milimetro que implemente la interfaz ILongitud
    public class Milimetro : ILongitud
    {
        public decimal Medida { get; set; }
    }

    //TODO Crea una clase llamada Milla que implemente la interfaz ILongitud
    public class Milla : ILongitud
    {
        public decimal Medida { get; set; }
    }

    //TODO Crea una clase llamada Pulgada que implemente la interfaz ILongitud
    public class Pulgada : ILongitud
    {
        public decimal Medida { get; set; }
    }

    public static class Conversor
    {
        public static Metro ToMetros<T>(T obj)
        {
            string tipo = obj.GetType().Name;
            Metro longitud = obj as Metro;

            switch (tipo)
            {
                case "Pulgada":
                    longitud.Medida *= 39.37M;
                    break;
                case "Centimetro":
                    longitud.Medida /= 100;
                    break;
                case "Milimetro":
                    longitud.Medida /= 1000;
                    break;
                case "Milla":
                    longitud.Medida *= 1609.344M;
                    break;
                case "Kilometro":
                    longitud.Medida *= 1000;
                    break;
                default:
                    break;
            }

            Metro metro = new Metro { Medida = longitud.Medida };
            return metro;
        }

        public static Kilometro ToKilometros<T>(T obj)
        {
            string tipo = obj.GetType().Name;
            Metro longitud = obj as Metro;

            switch (tipo)
            {
                case "Pulgada":
                    longitud.Medida *= 39.37M;
                    break;
                case "Centimetro":
                    longitud.Medida /= 100;
                    break;
                case "Milimetro":
                    longitud.Medida /= 1000;
                    break;
                case "Milla":
                    longitud.Medida *= 1609.344M;
                    break;
                default:
                    break;
            }
            longitud.Medida *= 1000;

            Kilometro kilometro = new Kilometro { Medida = longitud.Medida };
            return kilometro;
        }

        public static Pulgada ToPulgadas<T>(T obj)
        {
            string tipo = obj.GetType().Name;
            Metro longitud = obj as Metro;

            switch (tipo)
            {
                case "Kilometro":
                    longitud.Medida *= 1000;
                    break;
                case "Centimetro":
                    longitud.Medida /= 100;
                    break;
                case "Milimetro":
                    longitud.Medida /= 1000;
                    break;
                case "Milla":
                    longitud.Medida *= 1609.344M;
                    break;
                default:
                    break;
            }
            longitud.Medida *= 39.37M;

            Pulgada pulgada = new Pulgada { Medida = longitud.Medida };
            return pulgada;
        }
    }

    //TODO Crea una clase estática llamada Conversor
    //TODO Crea un método ToKilometros que devuelve un objeto Kilometro y recibe como parámetro un objeto del tipo genérico
    //TODO Crea un método ToMetros que devuelve un objeto Metro y recibe como parámetro un objeto del tipo genérico
    //TODO Crea un método ToCentimetros que devuelve un objeto Centimetro y recibe como parámetro un objeto del tipo genérico
    //TODO Crea un método ToMilimetros que devuelve un objeto Milimetro y recibe como parámetro un objeto del tipo genérico
    //TODO Crea un método ToMillas que devuelve un objeto Milla y recibe como parámetro un objeto del tipo genérico
    //TODO Crea un método ToPulgadas que devuelve un objeto Pulgada y recibe como parámetro un objeto del tipo genérico
    //
    //TODO Cada método debe transformar el valor de la propiedad Medida y retonar el nuevo valor.
    //
    //DATOS     1 kilometro = 1000 metros       *   1 metro = 1 metro           *   1 centimetro = 1 / 100 metros
    //          1 milimetro = 1 / 1000 metros   *   1 milla = 1609.344 metros   *   1 pulgada = 1 / 39.37 metros
    //
    //EJEMPLO     public static Kilometro ToKilometros<T>(T obj)

}