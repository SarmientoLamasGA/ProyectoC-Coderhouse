using ProyectoC_Coderhouse;

// Instancia de Producto
Producto pruebaProducto1 = new Producto(1, "Prueba de producto", 150.50f, 200.30f , 500, 1);
Console.WriteLine("Producto");
pruebaProducto1.mostrarTodo();

//Instancia de Usuario
Usuario nuevoUsuario1 = new Usuario(1, "Juan", "Doe", "Pepe33", "Argentina123", "Juan_doe@gmail.com");
Console.WriteLine("Usuario");
nuevoUsuario1.mostrarTodo();

//Instancia de Producto Vendido
ProductoVendido ventaDeProducto1 = new ProductoVendido(1, 1, 499, 1);
Console.WriteLine("Venta de producto");
ventaDeProducto1.mostrarTodo();

//Instancia de Venta
Venta venta1 = new Venta(1, "Buen producto", 1);
Console.WriteLine("Venta");
venta1.mostrarTodo();