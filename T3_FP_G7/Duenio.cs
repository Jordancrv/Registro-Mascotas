using G7_nm_Mascota;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace G7_nm_Duenio
{


    internal class Duenio
    {
        //CREAMOS LOS ATRIBUTOS DE LA CLASE 'Duenio'
        private string G7_Nombre { get; set; }
        private string G7_Direccion { get; set; }
        private int G7_Telefono { get; set; }

 

        //CREAMOS UN CONSTRUCTOR VACIO
        public Duenio() { }

        //CREAMOS UN CONSTRUCTOR CON PARAMETROS
        public Duenio(string G7_nom, string G7_direc, int G7_telf)
        
        {
            //LOS VALORES QUE SE PASEN COMO PARAMETROS, SE LES ASIGNARA A LOS ATRIBUTOS DEL OBJETO RESPECTIVAMENTE.
            G7_Nombre = G7_nom;
            G7_Direccion = G7_direc;
            G7_Telefono = G7_telf;
       
        }


        //ESTE METODO SIRVE PARA MOSTRAR TODOS LOS DATOS DEL Duenio
        //POR LO QUE RETORNARÁ UN STRING
        public string mostrar_Duenios()

        {
            return "Nombre: " + this.G7_Nombre + " Direccion:" + this.G7_Direccion + " Telefono:" + this.G7_Telefono;

        }



        //REALIZAMOS LOS GETTERS Y SETTERS DE CADA ATRIBUTO DE LA CLASE
        public string getNombre()
        {
            return G7_Nombre;
        }
        public void setNombre(string g7_nombre)
        {
            G7_Nombre = g7_nombre;
        }
        public string getDireccion()
        {
            return G7_Direccion;
        }
        public void setDireccion(string g7_direccion)
        {
            G7_Direccion = g7_direccion;
        }
        public int getTelefono()
        {
            return G7_Telefono;
        }
        public void setTelefono(int g7_telefono)
        {
            G7_Telefono = g7_telefono;
        }

    }
    internal class Mascotas 
    {
        private string G7_Mascota { get; set; }
        private string G7_Raza { get; set; }
        private int G7_Edad { get; set; }

        public Mascotas() { }
        public Mascotas(string G7_mascota, string G7_raza, int G7_edad)
        {
            G7_Mascota = G7_mascota;
            G7_Raza = G7_raza;
            G7_Edad = G7_edad;

        }
        public string getMascota()
        {
            return G7_Mascota;
        }
        public void setMascota(string G7_mascota)
        {
            G7_Mascota = G7_mascota;
        }

        public string getRaza()
        {
            return G7_Raza;
        }
        public void setRaza (string G7_raza)
        {
            G7_Raza = G7_raza;
        }
        public int getEdad()
        {
            return G7_Edad;
        }
        public void setEdad(int G7_edad)
        {
            G7_Edad = G7_edad;
        }
    }
}
