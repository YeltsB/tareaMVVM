using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace tareaMVVM.Models
{
    public class Empleados
    {
        public int id_empleado;
        public string nombre;
        public string apellido;
        public int edad;
        public string direccion;
        public string puesto;

        // public Byte[] photo_recibo;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        [PrimaryKey, AutoIncrement]
        public int Id_empleado
        {
            get
            {
                return id_empleado;
            }

            set
            {
                if (id_empleado != value)
                {
                    id_empleado = value;
                    OnPropertyChanged("id_empleado");
                }

            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    OnPropertyChanged("nombre");
                }
            }
        }


        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                if (apellido != value)
                {
                    apellido = value;
                    OnPropertyChanged("apellido");
                }
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                if (edad != value)
                {
                    edad = value;
                    OnPropertyChanged("edad");
                }
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                if (direccion != value)
                {
                    direccion = value;
                    OnPropertyChanged("direccion");
                }
            }
        }

        public string Puesto
        {
            get
            {
                return puesto;
            }

            set
            {
                if (puesto != value)
                {
                    puesto = value;
                    OnPropertyChanged("puesto");
                }
            }
        }

    }
}
