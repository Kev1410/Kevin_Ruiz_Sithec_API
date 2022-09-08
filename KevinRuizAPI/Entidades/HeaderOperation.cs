using Microsoft.AspNetCore.Mvc;

namespace KevinRuizAPI.Entidades
{
    public class HeaderOperation
    {
        [FromHeader]
        public int Numero1 { get; set; }
        [FromHeader]
        public int Numero2 { get; set; }
        [FromHeader]
        public char Operacion { get; set; }
    }
}
