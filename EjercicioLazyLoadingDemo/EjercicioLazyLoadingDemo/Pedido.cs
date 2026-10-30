using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLazyLoadingDemo
    {

    public class Pedido
        {

        public int Id { get; set; }
        public decimal Total { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente cliente { get; set; }
        }
    }