internal class Program
{
    static List<string> listaProductos = new List<string>();
    static double sumaPrecio = 0;
    static double precioProducto = 0;
    static double precioTotal = 0;
    static double precioFinal = 0;
    static double descuento = 0;
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("____MENU____");
            Console.WriteLine("1. Ingresar productos");
            Console.WriteLine("2. Calcular total de la compra");
            Console.WriteLine("3. Aplicar descuento");
            Console.Write("Escriba una opcion: ");
            try
            {
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        IngresarProductos();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        CalcularPrecio();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        AplicarDescuento();
                        Console.ReadKey();
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error de formato: Debe ingresar solo numeros");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: El numero es demasiado grande");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
        static void CalcularPrecio()
        {
            precioTotal = sumaPrecio;
            Console.WriteLine("El precio total es " + precioTotal);
        }
        static void AplicarDescuento()
        {
            descuento = sumaPrecio * 0.25;
            precioFinal = precioProducto- descuento;
            Console.WriteLine("El precio final es: " + precioFinal);
        }
    }

}