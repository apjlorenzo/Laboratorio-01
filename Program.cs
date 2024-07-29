internal class Program
{

    static void Main(string[] args)
    {
        static List<string> listaProductos = new List<string>();
        static double sumaPrecio = 0;
        static double precioProducto = 0;
        while (true)
        {
            Console.WriteLine("____MENU____");
            Console.WriteLine("1. Ingresar productos");
            Console.WriteLine("2. Calcular total de la compra");
            Console.WriteLine("3. Aplicar descuento");
        }
        static void IngresarProductos()
        {
            Console.WriteLine("Ingrese la cantidad de productos a ingresar");
            int Cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < Cantidad; i++)
            {
                Console.WriteLine("Ingrese el nombre del producto");
                listaProductos.Add(Console.ReadLine());
                Console.WriteLine("Ingrese el precio del producgto");
                precioProducto = double.Parse(Console.ReadLine());
                sumaPrecio += precioProducto;


            }
        }
        static double CalcularPrecio()
        {
            return sumaPrecio;
        }
        static double AplicarDescuento()
        {
            return sumaPrecio * 0.25;
        }
    }

}