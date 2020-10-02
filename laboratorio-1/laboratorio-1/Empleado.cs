using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_1
{
    class Empleado
    {
        private int _cedula;

        public int cedula
        {
            get { return _cedula; }
            set { _cedula = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _direccion;

        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private string _puesto;

        public string puesto
        {
            get { return _puesto; }
            set { _puesto = value; }
        }

        private DateTime _fechaIngreso;

        public DateTime fechaIngreso
        {
            get { return _fechaIngreso; }
            set
            {
                if (_fechaIngreso != DateTime.Today)
                {
                    _fechaIngreso = value;
                }
                else 
                {
                    throw new Exception("La fecha ingresada no es valida");
                }
            }
        }

        private int _telefono;

        public int telefono
        {
            get { return _telefono; }
            set
            {
                if (_telefono > 9999999 || _telefono < 100000000)
                {
                    _telefono = value;
                }
                else
                {
                    throw new Exception("Valor invalido");
                }
            }
        }

        private double _salario;

        public double salario
        {
            get { return _salario; }
            set
            {
                if (value > 449999)
                {
                    _salario = value;
                }else
                {
                    throw new Exception("Valor invalido" + " "+ _salario);
                }
            }
        }
        public Empleado()
        {
        }

        public Empleado(int cedula, string nombre, string apellido, string direccion, string puesto, DateTime fechaIngreso, int telefono, int salario)
        {
            _cedula = cedula;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _puesto = puesto;
            _fechaIngreso = fechaIngreso;
            _telefono = telefono;
            _salario = salario;
        }

        public void aumentarSueldo() 
        {
            if ((_puesto.Equals("Jefe")) || (_puesto.Equals("jefe")))
            {
            }
            else if (_salario < 600000)
            {
                _salario += _salario * 0.05;
            }
            else {
                _salario += _salario * 0.02;
            }
        }

        private string obtenerTiempoTotal() {
            return " Años: " + (DateTime.Now.Year - _fechaIngreso.Year) + " Meses: " + (DateTime.Now.Month - _fechaIngreso.Month);


        }

        public string imprimirEmpleado() {
            return _cedula+ " - " + _nombre+ " "+ _apellido + " - "+ direccion+" - "+ puesto+ " - " + fechaIngreso +" - "+ obtenerTiempoTotal() +" - "+ _telefono +" - " +_salario;
        }
    }
}
