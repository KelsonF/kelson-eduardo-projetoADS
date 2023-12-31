﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto_Otilio.Models;

#nullable disable

namespace dotnet_library.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Projeto_Otilio.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.FormaDePagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InformacoesAdicionais")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeDoCobrado")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TiposDePagamento");

                    b.HasDiscriminator<string>("Discriminator").HasValue("FormaDePagamento");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.Property<int>("Percentual")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.HasIndex("ProductId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.NotaDeVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("PaymentTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("SellerId")
                        .HasColumnType("int");

                    b.Property<int?>("TipoDePagamentoId")
                        .HasColumnType("int");

                    b.Property<int?>("TransportadoraId")
                        .HasColumnType("int");

                    b.Property<bool>("Type")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PaymentTypeId");

                    b.HasIndex("SellerId");

                    b.HasIndex("TransportadoraId");

                    b.ToTable("NotasDeVendas");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.Property<bool>("Pago")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.Transportadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Transportadoras");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.PagamentoComCartao", b =>
                {
                    b.HasBaseType("Projeto_Otilio.Models.FormaDePagamento");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext");

                    b.Property<string>("Number")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCartao");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.PagamentoComCheque", b =>
                {
                    b.HasBaseType("Projeto_Otilio.Models.FormaDePagamento");

                    b.Property<int>("Bank")
                        .HasColumnType("int");

                    b.Property<string>("BankName")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCheque");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.Item", b =>
                {
                    b.HasOne("Projeto_Otilio.Models.NotaDeVenda", null)
                        .WithMany("Itens")
                        .HasForeignKey("NotaDeVendaId");

                    b.HasOne("Projeto_Otilio.Models.Produto", "Product")
                        .WithMany("Items")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.NotaDeVenda", b =>
                {
                    b.HasOne("Projeto_Otilio.Models.Cliente", "Client")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Projeto_Otilio.Models.FormaDePagamento", "PaymentType")
                        .WithMany()
                        .HasForeignKey("PaymentTypeId");

                    b.HasOne("Projeto_Otilio.Models.Vendedor", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId");

                    b.HasOne("Projeto_Otilio.Models.Transportadora", "Transportadora")
                        .WithMany()
                        .HasForeignKey("TransportadoraId");

                    b.Navigation("Client");

                    b.Navigation("PaymentType");

                    b.Navigation("Seller");

                    b.Navigation("Transportadora");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.Pagamento", b =>
                {
                    b.HasOne("Projeto_Otilio.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("Payments")
                        .HasForeignKey("NotaDeVendaId");

                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.Produto", b =>
                {
                    b.HasOne("Projeto_Otilio.Models.Marca", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.Marca", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.NotaDeVenda", b =>
                {
                    b.Navigation("Itens");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Projeto_Otilio.Models.Produto", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
