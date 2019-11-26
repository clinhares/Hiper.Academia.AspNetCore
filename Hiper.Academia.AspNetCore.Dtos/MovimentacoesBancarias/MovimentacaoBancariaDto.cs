using System;

namespace Hiper.Academia.AspNetCore.Dtos.MovimentacoesBancarias
{
    public class MovimentacaoBancariaDto
    {
        public DateTime Data { get; set; }
        public bool IsDeposito { get; set; }
        public bool IsSaque { get; set; }
        public decimal Valor { get; set; }
    }
}