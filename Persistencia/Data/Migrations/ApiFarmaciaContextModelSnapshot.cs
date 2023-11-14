﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia.Data;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(ApiFarmaciaContext))]
    partial class ApiFarmaciaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdDepartamentoFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdDepartamentoFk");

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.ContactoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IdPersona")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("IdTipoContacto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPersona");

                    b.HasIndex("IdTipoContacto");

                    b.ToTable("contactopersona", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdPaisFk");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.DetalleMovInventario", b =>
                {
                    b.Property<string>("IdMovInv")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("IdInventario")
                        .HasColumnType("varchar(10)");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.HasKey("IdMovInv");

                    b.HasIndex("IdInventario");

                    b.ToTable("detallemovinventario", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FacturaActual")
                        .HasColumnType("int");

                    b.Property<int>("FacturaFinal")
                        .HasColumnType("int");

                    b.Property<int>("FacturaInicial")
                        .HasColumnType("int");

                    b.Property<string>("IdDetalleMovimiento")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("IdPersona")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NroResolucion")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("IdDetalleMovimiento");

                    b.HasIndex("IdPersona");

                    b.ToTable("factura", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.FormaPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("formapago", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Inventario", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CodProducto")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("IdPresentacion")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("StockMax")
                        .HasColumnType("int");

                    b.Property<int>("StockMin")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CodProducto");

                    b.HasIndex("IdPresentacion");

                    b.ToTable("inventario", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("marca", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.MovimientoInventario", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("FechaMovimiento")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime");

                    b.Property<int>("IdFormaPago")
                        .HasColumnType("int");

                    b.Property<string>("IdReceptor")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("IdResponsable")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("IdTipoMovInv")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdFormaPago");

                    b.HasIndex("IdReceptor");

                    b.HasIndex("IdTipoMovInv");

                    b.ToTable("movimientoinventario", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Persona", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime");

                    b.Property<int>("IdRolPersona")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoDocumento")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersona")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdRolPersona");

                    b.HasIndex("IdTipoDocumento");

                    b.HasIndex("IdTipoPersona");

                    b.ToTable("persona", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Presentacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("presentacion", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Producto", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("IdMarca")
                        .HasColumnType("int");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdMarca");

                    b.ToTable("producto", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("refreshtoken", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.RolPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("rolpersona", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.TipoContacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tipocontacto", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tipodocumento", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.TipoMovInventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tipomovinventario", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tipopersona", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.UbicacionPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bis")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CardinalPri")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CardinalSec")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdCiudad")
                        .HasColumnType("int");

                    b.Property<int>("IdDireccion")
                        .HasColumnType("int");

                    b.Property<string>("IdPersona")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("LetraPri")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("LetraSec")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("LetraTer")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<int>("NumeroPri")
                        .HasColumnType("int");

                    b.Property<int>("NumeroSec")
                        .HasColumnType("int");

                    b.Property<int>("NumeroTer")
                        .HasColumnType("int");

                    b.Property<string>("TipoDeVia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdCiudad");

                    b.HasIndex("IdPersona");

                    b.ToTable("ubicacionpersona", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.UserRol", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RolId");

                    b.HasIndex("RolId");

                    b.ToTable("userRol", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Ciudad", b =>
                {
                    b.HasOne("Dominio.Entities.Departamento", "Departamentos")
                        .WithMany("Ciudades")
                        .HasForeignKey("IdDepartamentoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Dominio.Entities.ContactoPersona", b =>
                {
                    b.HasOne("Dominio.Entities.Persona", "Personas")
                        .WithMany("ContactosPersonas")
                        .HasForeignKey("IdPersona");

                    b.HasOne("Dominio.Entities.TipoContacto", "TiposContactos")
                        .WithMany("ContactosPersonas")
                        .HasForeignKey("IdTipoContacto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personas");

                    b.Navigation("TiposContactos");
                });

            modelBuilder.Entity("Dominio.Entities.Departamento", b =>
                {
                    b.HasOne("Dominio.Entities.Pais", "Paises")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paises");
                });

            modelBuilder.Entity("Dominio.Entities.DetalleMovInventario", b =>
                {
                    b.HasOne("Dominio.Entities.Inventario", "Inventarios")
                        .WithMany("DetallesMovInventarios")
                        .HasForeignKey("IdInventario");

                    b.HasOne("Dominio.Entities.MovimientoInventario", "MovimientosInventarios")
                        .WithMany("DetallesMovInventarios")
                        .HasForeignKey("IdMovInv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventarios");

                    b.Navigation("MovimientosInventarios");
                });

            modelBuilder.Entity("Dominio.Entities.Factura", b =>
                {
                    b.HasOne("Dominio.Entities.DetalleMovInventario", "DetallesMovInventarios")
                        .WithMany("Facturas")
                        .HasForeignKey("IdDetalleMovimiento");

                    b.HasOne("Dominio.Entities.Persona", "Personas")
                        .WithMany("Facturas")
                        .HasForeignKey("IdPersona");

                    b.Navigation("DetallesMovInventarios");

                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Entities.Inventario", b =>
                {
                    b.HasOne("Dominio.Entities.Producto", "Productos")
                        .WithMany("Inventarios")
                        .HasForeignKey("CodProducto");

                    b.HasOne("Dominio.Entities.Presentacion", "Presentaciones")
                        .WithMany("Inventarios")
                        .HasForeignKey("IdPresentacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Presentaciones");

                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Dominio.Entities.MovimientoInventario", b =>
                {
                    b.HasOne("Dominio.Entities.FormaPago", "FormasPagos")
                        .WithMany("MovimientosInventarios")
                        .HasForeignKey("IdFormaPago")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Persona", "Personas")
                        .WithMany("MovimientosInventarios")
                        .HasForeignKey("IdReceptor");

                    b.HasOne("Dominio.Entities.TipoMovInventario", "TiposMovInventarios")
                        .WithMany("MovimientosInventarios")
                        .HasForeignKey("IdTipoMovInv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormasPagos");

                    b.Navigation("Personas");

                    b.Navigation("TiposMovInventarios");
                });

            modelBuilder.Entity("Dominio.Entities.Persona", b =>
                {
                    b.HasOne("Dominio.Entities.RolPersona", "RolesPersonas")
                        .WithMany("Personas")
                        .HasForeignKey("IdRolPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.TipoDocumento", "TiposDocumentos")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoDocumento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.TipoPersona", "TiposPersonas")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RolesPersonas");

                    b.Navigation("TiposDocumentos");

                    b.Navigation("TiposPersonas");
                });

            modelBuilder.Entity("Dominio.Entities.Producto", b =>
                {
                    b.HasOne("Dominio.Entities.Marca", "Marcas")
                        .WithMany("Productos")
                        .HasForeignKey("IdMarca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marcas");
                });

            modelBuilder.Entity("Dominio.Entities.RefreshToken", b =>
                {
                    b.HasOne("Dominio.Entities.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Dominio.Entities.UbicacionPersona", b =>
                {
                    b.HasOne("Dominio.Entities.Ciudad", "Ciudades")
                        .WithMany("UbicacionesPersonas")
                        .HasForeignKey("IdCiudad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Persona", "Personas")
                        .WithMany("UbicacionesPersonas")
                        .HasForeignKey("IdPersona");

                    b.Navigation("Ciudades");

                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Entities.UserRol", b =>
                {
                    b.HasOne("Dominio.Entities.Rol", "Rol")
                        .WithMany("UsersRols")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.User", "User")
                        .WithMany("UsersRols")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Dominio.Entities.Ciudad", b =>
                {
                    b.Navigation("UbicacionesPersonas");
                });

            modelBuilder.Entity("Dominio.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Dominio.Entities.DetalleMovInventario", b =>
                {
                    b.Navigation("Facturas");
                });

            modelBuilder.Entity("Dominio.Entities.FormaPago", b =>
                {
                    b.Navigation("MovimientosInventarios");
                });

            modelBuilder.Entity("Dominio.Entities.Inventario", b =>
                {
                    b.Navigation("DetallesMovInventarios");
                });

            modelBuilder.Entity("Dominio.Entities.Marca", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Dominio.Entities.MovimientoInventario", b =>
                {
                    b.Navigation("DetallesMovInventarios");
                });

            modelBuilder.Entity("Dominio.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Dominio.Entities.Persona", b =>
                {
                    b.Navigation("ContactosPersonas");

                    b.Navigation("Facturas");

                    b.Navigation("MovimientosInventarios");

                    b.Navigation("UbicacionesPersonas");
                });

            modelBuilder.Entity("Dominio.Entities.Presentacion", b =>
                {
                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("Dominio.Entities.Producto", b =>
                {
                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("Dominio.Entities.Rol", b =>
                {
                    b.Navigation("UsersRols");
                });

            modelBuilder.Entity("Dominio.Entities.RolPersona", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Entities.TipoContacto", b =>
                {
                    b.Navigation("ContactosPersonas");
                });

            modelBuilder.Entity("Dominio.Entities.TipoDocumento", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Entities.TipoMovInventario", b =>
                {
                    b.Navigation("MovimientosInventarios");
                });

            modelBuilder.Entity("Dominio.Entities.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Entities.User", b =>
                {
                    b.Navigation("RefreshTokens");

                    b.Navigation("UsersRols");
                });
#pragma warning restore 612, 618
        }
    }
}
