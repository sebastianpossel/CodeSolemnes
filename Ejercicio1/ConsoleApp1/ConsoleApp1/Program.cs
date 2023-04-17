using System;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcionMenu = 0;
        string strOpc;
        int edad = 0;
        string strEdad;
        int cantidadEquip = 0;
        int notebook = 350000, impresoraLaser = 150000, microfonoAudifonos = 50000;
        int totalPagar = 0;
        int opcionMenuEquipo = 0;
        bool continuarComprando = true;
        int cantidadNotebook = 0;
        int cantidadImpresoraLaser = 0;
        int cantidadMicrofonoAudifonos = 0;
        bool pagoConTransferencia = false;

        string menuEquipos = "Opciones de equipo \n1.- Notebook: $350.000\n2.- Impresora Laser: $150.000\n3.- Juego de Audifonos-Microfono $50.000\n";
        string menu = "\n1.- Venta de productos\n2.- Total a Pagar\n3.- Estadística\n4.- Salir\n";
        Console.WriteLine("SARTEKCOMP");
        Console.WriteLine("Ingrese una opcion");
        Console.WriteLine(menu);

        strOpc = Console.ReadLine();
        Console.WriteLine(" Porfavor ingrese su edad");
        strEdad = Console.ReadLine();
        int.TryParse(strEdad, out edad);
        int.TryParse(strOpc, out opcionMenu);
        string seguirComprando;

        while (continuarComprando)
        {
            switch (opcionMenu)
            {
                case 1:
                    string strOpProducto;
                    int opcProducto = 0;

                    Console.WriteLine("Muchas gracias, ahora porfavor Seleccione su producto: \n" + menuEquipos);
                    strOpProducto = Console.ReadLine();
                    int.TryParse(strOpProducto, out opcProducto);

                    int montoPorPagar = 0;
                    switch (opcProducto)
                    {
                        case 1:
                            montoPorPagar = notebook;
                            Console.WriteLine("$" + notebook);
                            cantidadNotebook++;
                            break;
                        case 2:
                            montoPorPagar = impresoraLaser;
                            Console.WriteLine("$" + impresoraLaser);
                            cantidadImpresoraLaser++;
                            break;
                        case 3:
                            montoPorPagar = microfonoAudifonos;
                            Console.WriteLine("$" + microfonoAudifonos);
                            cantidadMicrofonoAudifonos++;
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                    totalPagar += montoPorPagar;
                    break;
                case 2:
                    Console.WriteLine("Total a pagar = $" + totalPagar);
                    Console.WriteLine("Veamos si tienes descuentos");
                    string strPagoTarjeta;
                    int pagoTarjeta = 0;
                    Console.WriteLine(" Paga con transferencia o tarjeta? eliga una opcion\n + 1.-Pago tarjeta\n + 2.- Pago Transferencia\n");
                    strPagoTarjeta = Console.ReadLine();
                    int.TryParse(strPagoTarjeta, out pagoTarjeta);
                    if (cantidadMicrofonoAudifonos + cantidadImpresoraLaser + cantidadMicrofonoAudifonos > 4)
                        Console.WriteLine("tienes un descuento de 10% por comprar mas de 4 productos, el precio seria:" + totalPagar * 0.1);


                    switch (pagoTarjeta)
                    {
                        case 1: Console.WriteLine("Lo sentimos no tienes descuento por tu metodo de pago");
                            break;
                        case 2: Console.WriteLine("tienes un descuento de 5% por pagar con transferencia");
                            Console.WriteLine("tu total a pagar seria: " + totalPagar * 0.05);
                            break;
                    }
                    if (edad < 40)
                    {
                        Console.WriteLine(" Lo siento no tienes descuento por tu edad");
                    }
                    else if (edad > 40)
                    { 
                        Console.WriteLine("tienes un descuento de 20%... tu precio bajo a:"+ totalPagar * 0.2);
                    }
                    break;
                                                                              
                case 3:
                    Console.WriteLine("Cantidad acumulada de productos comprados:");
                    Console.WriteLine("Notebook: " + cantidadNotebook);
                    Console.WriteLine("Impresora Laser: " + cantidadImpresoraLaser);
                    Console.WriteLine("Juego de Audifonos-Microfono: " + cantidadMicrofonoAudifonos);
                    break;
                case 4:
                    continuarComprando = false;
                    Console.WriteLine("Saliendo del Menu.........");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
            Console.WriteLine("\nIngrese una opcion");
            Console.WriteLine(menu);
            strOpc = Console.ReadLine();
            int.TryParse(strOpc, out opcionMenu);
        }
        // Por Sebastian Possel
    }
}