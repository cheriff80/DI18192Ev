using AplicacionAvituallamiento.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAvituallamiento.Logica
{
    public class LogicaNegocio
    {
       //instancio las dos listas de mi aplicación
        public ObservableCollection<Producto> listaProductos { get; set; }
        public ObservableCollection<Carrera> listaCarreras { get; set; }
        public ObservableCollection<PersonaContacto> listaPersonasContacto { get; set; }
        public ObservableCollection<Avituallamiento> listaAvituallamientos { get; set; }
        public Boolean sinExistencias;

        //constructor de la lógica de negocio
        public LogicaNegocio()
        {
            //inicio las dos listas
            listaProductos = new ObservableCollection<Producto>();
            listaCarreras = new ObservableCollection<Carrera>();
            listaPersonasContacto = new ObservableCollection<PersonaContacto>();
            listaAvituallamientos = new ObservableCollection<Avituallamiento>();

        }

        //métodos propios de la lista de PRODUCTOS
        //añadir producto
        public void aniadirProducto(Producto producto)
        {
             Boolean existeProducto=false;
            //recorro la lista de productos
            foreach (Producto p in listaProductos)
            {
                //comparo los nombres de los productos
                if (producto.NombreProducto.Equals(p.NombreProducto))
                {
                    //si el producto existe sumo la cantidad nueva añadida
                    p.CantidadProducto += producto.CantidadProducto;
                    //paso el boleano a true
                    existeProducto = true;
                }
            }
            //si no existe añado el producto a la lista
           if(!existeProducto)
               listaProductos.Add(producto);
        }

        //borrar producto
        public void borrarProducto(Producto producto)
        {
            listaProductos.Remove(producto);
        }

        //retirar producto
        public void retirarProducto(Producto producto, Avituallamiento avituallamiento)
        {
            //recorro la lista de productos
            foreach (Producto p in listaProductos)
            {
                if (producto.NombreProducto.Equals(p.NombreProducto))
                {
                    //si la cantidad en almacén es mayor que la demanda
                    if (p.CantidadProducto > producto.CantidadProducto)
                    {
                        p.CantidadProducto -= producto.CantidadProducto;
                        avituallamiento.ListaMateriales.Add(producto);
                        sinExistencias = false;
                    }

                    if(producto.CantidadProducto>p.CantidadProducto)
                    {
                        VentanaRetirarAlmacen va = new VentanaRetirarAlmacen(this,avituallamiento,1);
                        sinExistencias = true;
                        va.Show();
                    }
                    if(producto.CantidadProducto == p.CantidadProducto)
                    {
                        
                        avituallamiento.ListaMateriales.Add(producto);
                        listaProductos.Remove(producto);
                        sinExistencias = false;
                    }
                }
            }
        }

        //modificar producto
        public void modificarProducto(Producto producto, int posicion) 
        {
            listaProductos[posicion] = producto; 
        }

        //Métodos propios de PERSONA CONTACTO
        public void aniadirPersonaContacto(PersonaContacto personaContacto)
        {
            //recorro la lista de personas de contacto y si existe una persona con ese nombre 
            //y número de teléfono no hago nada
            Boolean existeContacto = false;

                foreach(PersonaContacto pc in listaPersonasContacto)
                {
                    if(pc.NombrePersonaContacto.Equals(personaContacto.NombrePersonaContacto) &&
                        pc.TelefonoPersonaContacto.Equals(personaContacto.TelefonoPersonaContacto))
                    {
                        existeContacto = true;
                    }
                }
            if(!existeContacto)
            {
                listaPersonasContacto.Add(personaContacto);

            }
        }

        //modificar PERSONACONTACTO
        public void modificarPersonaContacto (PersonaContacto personaContacto, int posicion)
        {
            listaPersonasContacto [posicion] = personaContacto;
        }

        //borrar PERSONACONTACTO
        public void borrarPersonaContacto(PersonaContacto personaContacto)
        {
            listaPersonasContacto.Remove(personaContacto);
        }
    
    //Métodos propios CARRERA
        public void aniadirCarrera(Carrera carrera)
        {
            //recorro la lista de carreras  y si existe una carrera con ese nombre 
            //y número de teléfono no hago nada
            Boolean existeCarrera = false;

            foreach (Carrera c in listaCarreras)
            {
                if (c.NombreCarrera.Equals(carrera.NombreCarrera))
                {
                    existeCarrera = true;
                }
            }
            if (!existeCarrera)
            {
                listaCarreras.Add(carrera);

            }
        }

        //modificar CARRERA
        public void modificarCarrera(Carrera carrera, int posicion)
        {
            listaCarreras [posicion] = carrera;
        }

        //borrar CARRERA
        public void borrarCarrera(Carrera carrera) 
        {
            listaCarreras.Remove(carrera);
        }

        //Métodos propios AVITUALLAMIENTO
        public void aniadirAvituallamiento(Avituallamiento avituallamiento)
        {
            //recorro la lista de carreras  y si existe una carrera con ese nombre 
            //y número de teléfono no hago nada
            Boolean existeAvituallamiento = false;

            foreach (Avituallamiento a in listaAvituallamientos)
            {
                if (a.PuntoKilometrico.Equals(avituallamiento.PuntoKilometrico) 
                    && a.Carrera.NombreCarrera.Equals(avituallamiento.Carrera.NombreCarrera))
                {

                    existeAvituallamiento = true;
                    listaAvituallamientos.Remove(a);
                    listaAvituallamientos.Add(avituallamiento);
                }
            }
            if (!existeAvituallamiento)
            {
                listaAvituallamientos.Add(avituallamiento);

            }
        }

        //modificar AVITUALLAMIENTO
        public void modificarAvituallamiento(Avituallamiento avituallamiento, int posicion)
        {
            listaAvituallamientos [posicion] = avituallamiento;
        }

        //borrar AVITUALLAMIENTO
        public void borrarAvituallamiento (Avituallamiento avituallamiento)
        {
            listaAvituallamientos.Remove(avituallamiento);
        }
    }

   
}
