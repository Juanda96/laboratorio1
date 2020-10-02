using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using logGenerator;

namespace laboratorio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Empleado> empleados = new LinkedList<Empleado>();
            log logs = new log();
            do
            {
                Console.WriteLine("1 - Ingresar Empleado" + Environment.NewLine + "2 - Imprime los empleados" + Environment.NewLine +
                "3 - Aumentar el salario a todos los empleados" + Environment.NewLine + Environment.NewLine + "Elija una opción");
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
                            emp.salario = salario;
                            empleados.AddLast(emp);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                            logs.agregarLog(ex.Message+ " - "+ ex.StackTrace);

                        }
                        break;
                    case 2:
                        Console.WriteLine("Datos de empleados"+ Environment.NewLine);
                        foreach (Empleado item in empleados)
                        {
                            Console.WriteLine(item.imprimirEmpleado());
                        }
                        break;

                    case 3:
                        foreach (Empleado item in empleados)
                        {
                            item.aumentarSueldo();
                        }
                        Console.WriteLine("Salarios aumentados satisfactoriamente");
                        break;


                }
                Console.ReadKey();
            } while (true);
            
        }
    }
}
