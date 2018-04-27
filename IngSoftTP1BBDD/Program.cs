using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IngSoftTP3BD
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Rol rol1 = new RolSimple(1);
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
            Rol rolComp1 = new RolCompuesto(aRolComp1, 101);

            List<Rol> aRolComp2 = new List<Rol>();
            aRolComp2.Add(rol4);
            aRolComp2.Add(rol5);
            Rol rolComp2 = new RolCompuesto(aRolComp2, 102);

            List<Rol> aRolComp3 = new List<Rol>();
            aRolComp3.Add(rol7);
            aRolComp3.Add(rol8);
            aRolComp3.Add(rol9);
            Rol rolComp3 = new RolCompuesto(aRolComp3, 103);

            List<Rol> aRolComp4 = new List<Rol>();
            aRolComp4.Add(rolComp1);
            aRolComp4.Add(rolComp2);
            aRolComp4.Add(rolComp3);
            Rol rolComp4 = new RolCompuesto(aRolComp4, 104);
*/
            /*Fin Roles de prueba*/


            Usuario mati = new Usuario("Mati", "pass");
            //mati.addRol(rol1);
            //mati.addRol(rolComp2);
            //mati.addRol(rolComp3);
            //mati.addRol(rol2);

            String nombre;
            String pass;
            int idrol;
            List<int> rolelist = new List<int>();

            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "ingsoft";
            if (dbCon.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
                /*string query = "SELECT * FROM permiso";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string someStringFromColumnZero = reader.GetString(0);
                    string someStringFromColumnOne = reader.GetString(1);
                    Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
                }
                dbCon.Close();
                Console.ReadKey();*/
            }

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

            string query = "SELECT * FROM usuario";
            var cmd = new MySqlCommand(query, dbCon.Connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int.TryParse(reader.GetString(1),out idrol) ;
                rolelist.Add(idrol);
               
            }
            reader.Close();

            foreach (int i in rolelist){
                if (i > 0 && i <= 10)
                {
                    Rol rol = new RolSimple(i);
                    mati.addRol(rol);
                }
                else
                {
                    string query1 = "SELECT * FROM pp WHERE id1 = '" + i + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, dbCon.Connection);

                    var reader1 = cmd1.ExecuteReader();
                    while (reader1.Read())
                    {
                        int.TryParse(reader1.GetString(1), out idrol);
                        Rol rol = new RolSimple(idrol);
                        mati.addRol(rol);
                    }
                }

            }

            dbCon.Close();

            Botones botones = new Botones();
            botones.showBotones(mati);
            Console.ReadKey();
        }
    }
}
