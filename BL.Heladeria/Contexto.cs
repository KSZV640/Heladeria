using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Heladeria.SeguridadBL;

namespace BL.Heladeria
{
    public class Contexto: DbContext
    {
        internal object Facturas;
        internal object TblMunicipio;

        public Contexto(): base("Heladeria")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public object Factura { get; internal set; }
        public object Cliente { get; internal set; }
        public object TblCategoria { get; internal set; }
        public object TblPersonas { get; internal set; }
        public object TblClaseCliente { get; internal set; }
        public object TblSectorCol { get; internal set; }
    }
}
