using System;
using System.ComponentModel;

namespace WpfApp
{
    internal class MainViewModel
    {
        public BindingList<Registro> Registros { get; set; }

        public MainViewModel()
        {
            Registros = new BindingList<Registro>()
            {
                new Registro() { Nome ="X", Data = DateTime.Now.AddMonths(1).AddMinutes(-10) },
                new Registro() { Nome ="XX", Data = DateTime.Now.AddMinutes(50) },
                new Registro() { Nome ="XXX", Data = DateTime.Now }
            };
        }
    }
    public class Registro
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }
    }
}
