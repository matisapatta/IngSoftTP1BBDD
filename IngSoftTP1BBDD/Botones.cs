using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngSoftTP3BD
{
    class Botones
    {
        private List<int> permisos;

        public Botones()
        {
            this.permisos = new List<int>();

        }

        public void showBotones(Usuario user)
        {
            foreach (int j in user.getRol().getPermisos())
                this.permisos.Add(j);

            foreach (int i in permisos)
            {
                for (int id = 1; id < 11; id++)
                {
                    if (i == id)
                    {
                        Console.WriteLine("Botón " + id);
                    }

                }
            }

        }
    }
}
