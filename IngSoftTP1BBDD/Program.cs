using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngSoftTP3BD
{
    class Program
    {
        static void Main(string[] args)
        {
            Rol rol1 = new RolSimple(1);
            Rol rol2 = new RolSimple(2);
            Rol rol3 = new RolSimple(3);
            Rol rol4 = new RolSimple(4);
            Rol rol5 = new RolSimple(5);
            Rol rol6 = new RolSimple(6);
            Rol rol7 = new RolSimple(7);
            Rol rol8 = new RolSimple(8);
            Rol rol9 = new RolSimple(9);
            Rol rol10 = new RolSimple(10);

            List<Rol> aRolComp1 = new List<Rol>();
            aRolComp1.Add(rol1);
            aRolComp1.Add(rol2);
            Rol rolComp1 = new RolCompuesto(aRolComp1);

            List<Rol> aRolComp2 = new List<Rol>();
            aRolComp2.Add(rol4);
            aRolComp2.Add(rol5);
            Rol rolComp2 = new RolCompuesto(aRolComp2);

            List<Rol> aRolComp3 = new List<Rol>();
            aRolComp3.Add(rol7);
            aRolComp3.Add(rol8);
            aRolComp3.Add(rol9);
            Rol rolComp3 = new RolCompuesto(aRolComp3);

            List<Rol> aRolComp4 = new List<Rol>();
            aRolComp4.Add(rolComp1);
            aRolComp4.Add(rolComp2);
            aRolComp4.Add(rolComp3);
            Rol rolComp4 = new RolCompuesto(aRolComp4);

            /*Fin Roles de prueba*/


            Usuario mati = new Usuario("Mati", "pass");
            mati.addRol(rol1);
            mati.addRol(rolComp2);
            mati.addRol(rolComp3);
            mati.addRol(rol2);

            String nombre;
            String pass;

            do
            {
                Console.WriteLine("Ingrese usuario: ");
                nombre = Console.ReadLine();

            } while (!nombre.Equals(mati.getNombre()));

            do
            {
                Console.WriteLine("Ingrese password: ");
                pass = Console.ReadLine();

            } while (!pass.Equals(mati.getPass()));

            Botones botones = new Botones();
            botones.showBotones(mati);
            Console.ReadKey();
        }
    }
}
