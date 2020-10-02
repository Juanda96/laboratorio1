using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Empleado> empleados = new LinkedList<Empleado>();
            do
            {
                Console.WriteLine("1 - Ingresar Empleado" + Environment.NewLine + "2 - Imprime los empleados" + Environment.NewLine +
                "3 - Eliminar Empleado" + Environment.NewLine + "4 - Imprimir datos" + Environment.NewLine + Environment.NewLine + "Elija una opción");
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        try
                        {
                            Empleado emp = new Empleado();
                            Console.WriteLine("Ingrese el num de cedula");
                            int cedula = int.Parse(Console.ReadLine());
                            emp.cedula = cedula;
                            Console.WriteLine("Ingrese el nombre");
                            string nombre = Console.ReadLine();
                            emp.nombre = nombre;
                            Console.WriteLine("Ingrese el apellido");
                            string apellido = Console.ReadLine();
                            emp.apellido = apellido;
                            Console.WriteLine("Ingrese el direccion");
                            string direccion = Console.ReadLine();
                            emp.direccion = direccion;
                            Console.WriteLine("Ingrese el puesto (Empleado / Socio / Jefe)");
                            string puesto = Console.ReadLine();
                            emp.puesto = puesto;
                            DateTime fecha_ingreso;
                            do
                            {
                                Console.WriteLine("Ingrese fecha de ingreso");
                                fecha_ingreso = DateTime.Parse(Console.ReadLine());
                                
                            } while (fecha_ingreso == DateTime.Today);
                            emp.fechaIngreso = fecha_ingreso;
                            int telefono;
                            do
                            {
                                Console.WriteLine("Ingrese el num de telefono");
                                telefono = int.Parse(Console.ReadLine());
                                
                            } while (!((telefono > 9999999) && (telefono < 100000000)));
                            emp.telefono = telefono;
                            int salario;
                            do
                            {
                                Console.WriteLine("Ingrese el salario");
                                salario = int.Parse(Console.ReadLine());
                            } while ((salario < 449999));
                            Console.WriteLine(salario);
                            emp.salario = salario;
                            empleados.AddLast(emp);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Datos de empleados"+ Environment.NewLine);
                        foreach (Empleado item in empleados)
                        {
                            Console.WriteLine(item.imprimirEmpleado());
                        }
                        break;


                }
                Console.ReadKey();
            } while (true);
            
        }
    }
}
