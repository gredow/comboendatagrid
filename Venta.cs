using System;
using System.Windows;

namespace comboendatagrid
{
    public class Venta
    {
        public int Id{get;set;}
        public DateTimeOffset Fecha { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        /// Otras propiedades
        
    }
}