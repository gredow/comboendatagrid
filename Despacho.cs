using System;
using System.Windows;

namespace comboendatagrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Despacho
    {
        public int Id{get;set;}
        public int IdVenta { get; set; }
        public Venta Venta { get; set; }
        
        public bool FueEntregado { get; set; }
        public MediosPagos MedioPago { get; set; }
    }

public enum MediosPagos { Efectivo, Cheque, Tarjeta, Otro};
}