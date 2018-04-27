using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngSoftTP3BD
{
    abstract class Rol
    {
        public abstract List<int> getPermisos();
        public abstract int getIdRol();
        abstract public void addRol(Rol rol);
       
    }
}
