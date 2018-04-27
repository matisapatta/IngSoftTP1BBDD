using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngSoftTP3BD
{
    class RolSimple:Rol
    {
        private int idRol;

        public RolSimple(int ID)
        {
            idRol = ID;
        }

        override public List<int> getPermisos()
        {
            List<int> permisos = new List<int>();
            permisos.Add(idRol);
            return permisos;
        }

        override public int getIdRol()
        {
            return this.idRol;
        }
        public override void addRol(Rol rol)
        {
            throw new NotImplementedException();
        }
    }
}
