using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Text;
using Sistema.Entidades.Personas;

namespace Sistema.Datos.Mapping.Personas
{
    public class PersonaMap : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Personas")
                .HasKey(p => p.IdPersona);
            builder.Property(p => p.Apellidos)
                .HasMaxLength(50);
            builder.Property(P => P.Nombre)
                .HasMaxLength(50);
        }
    }
}
