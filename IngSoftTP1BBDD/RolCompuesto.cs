using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngSoftTP3BD
{
    class RolCompuesto : Rol
    {
        private List<Rol> hijos;
        private int idRol;
        private List<int> permisos;

        public RolCompuesto()
        {
            hijos = new List<Rol>();
            this.permisos = new List<int>();
        }

        public RolCompuesto(List<Rol> rol)
        {
            this.hijos = rol;
            this.idRol = 0;
            this.permisos = new List<int>();
        }

        override public void addRol(Rol rol)
        {
            this.hijos.Add(rol);
        }

        override public int getIdRol()
        {
            return this.idRol;
        }


        override public List<int> getPermisos()
        {

            foreach (Rol hijo in hijos)
            {
                Rol aux = hijo;
                List<int> auxArray;
                if (aux.getIdRol() != 0)
                {
                    this.permisos.Add(aux.getIdRol());
                }
                else
                {
                    foreach(int i in aux.getPermisos())
                    {
                        permisos.Add(i);
                    }
                    //auxArray = aux.getPermisos().Clone();

                    //permisos.AddAll(auxArray);

                }
            }

            return this.permisos;

        }
    }
}
