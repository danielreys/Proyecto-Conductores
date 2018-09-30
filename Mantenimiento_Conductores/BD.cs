using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento_Conductores
{
    static class BD
    {
        static private ConductoresEntities1 contexto = new ConductoresEntities1();

        static private string Mensaje(SqlException ex)
        {
            string mensaje;

            switch (ex.Number)
            {
                case -1:
                    mensaje = "No se puede conectar con el servidor, o el servidor es incorrecto";
                    break;
                case 547:
                    mensaje = "No se puede borrar registros relacionados";
                    break;
                case 2627:
                    mensaje = "Ya existe este/a ";
                    break;
                case 4060:
                    mensaje = "Nombre de la base de datos incorrecto";
                    break;
                case 18456:
                    mensaje = "Usuario o contraseña incorrectos";
                    break;
                default:
                    mensaje = ex.Number + " - " + ex.Message;
                    break;
            }

            return mensaje;
        }
        public static bool HaveChanges()
        {
            return contexto.ChangeTracker.HasChanges();
        }

        public static void RejectChanges()
        {
            foreach (DbEntityEntry entry in contexto.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                    default: break;
                }
            }
        }
        static public String AcceptChanges()
        {
            String mensaje = GuardarBd();
            return mensaje;
        }
        static private string GuardarBd()
        {
            string mensaje = "";
            try
            {
                contexto.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                mensaje = Mensaje(sqlEx);
                RejectChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RejectChanges();
            }

            return mensaje;
        }
        static public string InsertConductor(conductor conduc)
        {
            string mensaje = "";

            contexto.conductor.Add(conduc);  // añadimos un conductor 
            mensaje = AcceptChanges(); // acceptChanges para guardar y reflejar los cambios en la BD
            return mensaje;      // retornamos mensaje para saber como ha ido la operación
        }
        static public string InsertMaterial(Material material)
        {
            string mensaje = "";
            contexto.Material.Add(material);
            mensaje = AcceptChanges();
            return mensaje;
        }
       
        static public string BorrarMaterial(Material material)
        {
            string mensaje = "";
            contexto.Material.Remove(material);
            return mensaje;
        }
        static public List<conductor> TodosConductores(String filtro)
        {
            List<conductor> cond =
                (from c in contexto.conductor
                 where c.nombre.Contains(filtro) || c.apellido.Contains(filtro) || c.dni.Contains(filtro)
                 select c
                ).ToList();

            return cond;
        }
    }
}
