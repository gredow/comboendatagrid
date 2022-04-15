using System;
using System.Windows;

namespace comboendatagrid
{
    public class Cliente
    {
        public int Id{get;set;}
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Comuna { get; set; }
        public DateTimeOffset Fecha { get; set; }
    }

}