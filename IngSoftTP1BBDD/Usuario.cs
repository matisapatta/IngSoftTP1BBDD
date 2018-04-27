using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngSoftTP3BD
{
    class Usuario
    {
        private Rol rol;
        private String nombre;
        private String pass;


        public Usuario(String nombre, String pass)
        {
            this.nombre = nombre;
            this.pass = pass;
            rol = new RolCompuesto();
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public String getNombre()
        {
            return this.nombre;
        }
        public String getPass()
        {
            return this.pass;
        }

        public void addRol(Rol rol)
        {
            this.rol.addRol(rol);

        }
        public Rol getRol()
        {
            return this.rol;
        }
    }
}
