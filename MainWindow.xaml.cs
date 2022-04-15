using System;
using System.Collections.ObjectModel;
using System.Windows;


namespace comboendatagrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Despacho> despachos = new();
        public MainWindow()
        {
            InitializeComponent();
            

            var cliente1 = new Cliente
            {
                Id = 1,
                Nombre = "Manuel Pérez",
                Direccion = "Las Palmas 522",
                Comuna = "Cerro Navia"
            };
            var venta1 = new Venta
            {
                Id = 1,
                IdCliente = cliente1.Id,
                Cliente = cliente1,
                Fecha = DateTimeOffset.Now
            };

            var cliente2 = new Cliente
            {
                Id = 2,
                Nombre = "Clara González",
                Direccion = "Franco Suizo 709",
                Comuna = "Pudahuel"
            };
            var venta2 = new Venta
            {
                Id = 2,
                IdCliente = cliente2.Id,
                Cliente = cliente2,
                Fecha = DateTimeOffset.Now
            };

            despachos.Add(new Despacho
            {
                IdVenta = venta1.Id, Venta = venta1, 
                MedioPago = MediosPagos.Cheque
            });
            despachos.Add(new Despacho
            {
                IdVenta = venta2.Id, Venta = venta2,
                MedioPago = MediosPagos.Efectivo, FueEntregado = true
            });

            DataGridDespachos.DataContext = despachos;
        }

        private void Click_ButtonConfirmar(object sender, RoutedEventArgs e)
        {
            var texto = "";
            foreach(var despacho in despachos)
            {
                texto += $"VentaId: {despacho.IdVenta}, Medio:{despacho.MedioPago}, Entregado:{despacho.FueEntregado}\n";
            }
            MessageBox.Show(texto);
        }
    }
}
