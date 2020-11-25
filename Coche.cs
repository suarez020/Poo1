using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo1
{//creamos una buenas propiedades 
    //atributos -metodos y constructor 
    /// <summary>
    /// una clase es un metodo encapsulado 
    /// esta clase nos va a representar un coche ese es mi molde
    /// 
    /// </summary>
    class Coche
    {

        //atributos hola 
        private int id;
        private  string marca ;
        private string modelo ;
        private int km;
        private double precio;//propiedades 

        public Coche(int id, string marca, string modelo, int km, double precio)
        {
            this.Id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.km = km;
            this.precio = precio;
        }//lo hice dando clic e inicie mi constructor co acciones rapidas asi cree mi constructor 



        ///ahora un constructor 
        ///por que debemos inicializar nuestras variables
        ///metodo especial para inicializar
        ///

        ///el paradigma dice que no puedo acceder a los vlores ya que son de tipo private 
        ///entonces get and set 
        ///es una barera del usuario y propiedades 
        //aca lo que hice fue hacer unas acciones rapidas encapsule id y use las propiedades 
         
        public int Id { get => id; set => id = value; }



    }
}
