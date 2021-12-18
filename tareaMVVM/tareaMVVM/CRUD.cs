using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using tareaMVVM.Models;
namespace tareaMVVM
{
    public class CRUD : IDisposable
    {
        private SQLiteConnection con;

        public CRUD()
        {
            string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string dbPath = Path.Combine(folderPath, "empleado.db3");
            con = new SQLiteConnection(dbPath, true);
            con.CreateTable<Empleados>();

        }

        public void Dispose()
        {
            con.Dispose();
        }

        public void Insertar(Empleados modelo)
        {
            con.Insert(modelo);
            if (con.IsInTransaction)
            {
                Console.WriteLine("ok");
            }
        }
        public int Actualizar(Empleados modelo)
        {
            return con.Update(modelo);
        }
        public int Eliminar(Empleados modelo)
        {
            return con.Delete(modelo);

        }
        public Empleados Consultar(int id)
        {
            return con.Table<Empleados>().FirstOrDefault(p => p.Id_empleado == id);
        }

        public List<Empleados> Consultar()
        {
            return con.Table<Empleados>().OrderByDescending(xx => xx.Id_empleado).ToList();
        }
    }
}
