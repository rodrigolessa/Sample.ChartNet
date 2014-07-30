using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Sample.ChartNet.Dominio.Entities;

namespace Sample.ChartNet.Infraestrutura.Persistencia.UnitOfWork.Mapping
{
    public class TitularAnoMap : EntityTypeConfiguration<TitularAno>
    {
        public TitularAnoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Titular)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("TitularAno");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Titular).HasColumnName("Titular");
            this.Property(t => t.C2003).HasColumnName("2003");
            this.Property(t => t.C2004).HasColumnName("2004");
            this.Property(t => t.C2005).HasColumnName("2005");
            this.Property(t => t.C2006).HasColumnName("2006");
            this.Property(t => t.C2007).HasColumnName("2007");
            this.Property(t => t.C2008).HasColumnName("2008");
            this.Property(t => t.C2009).HasColumnName("2009");
            this.Property(t => t.C2010).HasColumnName("2010");
            this.Property(t => t.C2011).HasColumnName("2011");
            this.Property(t => t.C2012).HasColumnName("2012");
            this.Property(t => t.C2013).HasColumnName("2013");
        }
    }
}
