using EjercicioLazyLoadingDemo;

// Lazy loading y eager loading son estrategias para traer datos relacionados cuando trabajas con base de datos y oun orm.

using (var context = new AppDbContext())
    {

    var cliente = new Cliente
        {

        Nombre = "Mika",
        pedidos = new List<Pedido>
        {
            new Pedido { Total = 1500 },
            new Pedido { Total = 2500 }
        }
        };

    context.Clientes.Add(cliente);
    context.SaveChanges();
    }

using (var context = new AppDbContext())
    {
    var cliente = context.Clientes.First();

    Console.WriteLine($"Cliente: {cliente.Nombre}");

    Console.WriteLine("Pedidos:");

    foreach (var pedido in cliente.pedidos)
        {
        Console.WriteLine($"Total: {pedido.Total}");
        }
    }