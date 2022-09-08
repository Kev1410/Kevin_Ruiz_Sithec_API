using System.ComponentModel.DataAnnotations;

namespace KevinRuizAPI.Entidades
{
    public class Humano
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public char Sexo { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
    }
}
