using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G7_nm_Duenio;

namespace G7_nm_Mascota
{
    
    internal class Mascota
    {
        //CREAMOS LOS ATRIBUTOS DE LA CLASE 'Mascota'
        private string G7_Nombre_pet { get; set; }
        private int G7_Edad_pet { get; set; }
        private string G7_Raza_pet { get; set; }

        private string G7_nombre_duenio { get; set; }


        //CREAMOS UN CONSTRUCTOR VACIO
        public Mascota() { }

        //CREAMOS UN CONSTRUCTOR CON PARAMETROS
        public Mascota(string G7_nom_pet, int G7_edad_pet, string G7_raza_pet, string G7_nom_duenio) 
        {
            //LOS VALORES QUE SE PASEN COMO PARAMETROS, SE LES ASIGNARA A LOS ATRIBUTOS DEL OBJETO RESPECTIVAMENTE.
            G7_Nombre_pet = G7_nom_pet;
            G7_Edad_pet = G7_edad_pet;
            G7_Raza_pet = G7_raza_pet;
            G7_nombre_duenio = G7_nom_duenio;
        }


        //METODO PARA MOSTRAR EL NOMBRE DE LA MASCOTA Y EL DUEÑO
        public string MostrarMascotaYDuenio()
        {
            return G7_Nombre_pet + " " + G7_nombre_duenio;
        }

        //METODOS GETTERS Y SETTERS
        public string getNomMascota()
        {
            return G7_Nombre_pet;
        }

        public void setNomMascota(string G7_nombre_pet)
        {
            G7_Nombre_pet = G7_nombre_pet;
        }

        public int getEdadMascota()
        {
            return G7_Edad_pet;
        }

        public void setEdadMascota(int G7_edad_pet)
        {
            G7_Edad_pet = G7_edad_pet;
        }
        public string getRazaMascota()
        {
            return G7_Raza_pet;
        }

        public void setRazaMascota(string G7_raza_pet)
        {
            G7_Raza_pet = G7_raza_pet;
        }


    }
}
