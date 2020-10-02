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

        public string MyProperty
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
            set { _fechaIngreso = value; }
        }

        private int _telefono;

        public int telefono
        {
            get { return _telefono; }
            set
            {
                if (_telefono > 9999999 && _telefono < 100000000)
                {
                    _telefono = value;
                }
                else
                {
                    throw new Exception("Valor invalido");
                }
            }
        }

        private int _salario;

        public int salario
        {
            get { return _salario; }
            set
            {
                if (_salario >= 450000)
                {
                    _salario = value;
                }
                else
                {
                    throw new Exception("Valor invalido");
                }
            }
        }
    }
}
