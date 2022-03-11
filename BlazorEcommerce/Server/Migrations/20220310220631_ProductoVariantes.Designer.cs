﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220310220631_ProductoVariantes")]
    partial class ProductoVariantes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcommerce.Shared.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Libros",
                            Url = "libros"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Peliculas",
                            Url = "peliculas"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Video xogos",
                            Url = "video-xogos"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImaxeUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            Descripcion = "A Guía do Autoestopista Galáctico (título orixinal The Hitchhiker's Guide to the Galaxy) é unha serie de novelas humorísticas de ciencia ficción do escritor inglés Douglas Adams. Orixinalmente unha comedia radiofónica que comezou a emitirse na BBC en 1978, foi seguida dunha novela, The Hitchhiker's Guide to the Galaxy, publicada en 1979, unha serie de televisión en 1981, un xogo de ordenador en 1984 e unha película en 2005.",
                            ImaxeUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                            Titulo = "The Hitchhiker's Guide to the Galaxy"
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 1,
                            Descripcion = "Ready Player One é unha novela distópica de ciencia ficción de Ernest Cline publicada no ano 2011, a súa primeira obra deste tipo. No 2012 o libro recibiu un Premio Alex por parte da división Young Adult Library Services Association da American Library Association e gañou o Premio Prometheus de 2012.",
                            ImaxeUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                            Titulo = "Ready Player One"
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 1,
                            Descripcion = "1984 (en inglés Nineteen Eighty-Four) é o título dunha novela de política ficción distópica escrita por George Orwell en 1948 e editada en 1949. Na novela o estado omnipresente obriga a cumprir as leis e normas aos membros do partido totalitario mediante o adoutrinamento, a propaganda, o medo e o castigo desapiadado. A novela introduciu os conceptos do sempre presente e vixiante Grande Irmán, do notorio cuarto 101, da ubicua policía do pensamento e da neolingua, adaptación do inglés na que se reduce e se transforma o léxico —o que non está na lingua, non pode ser pensado.",
                            ImaxeUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                            Titulo = "Nineteen Eighty-Four"
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 2,
                            Descripcion = "Matrix (en inglés: The Matrix) é un filme de ciencia ficción escrito e dirixido por Lana e Lilly Wachowski e protagonizado por Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss e Hugo Weaving. Foi estreado nos Estados Unidos o 31 de marzo de 1999 e foi o primeiro da triloxía de Matrix e dunha serie de videoxogos, curtas animadas e bandas deseñadas. O filme gañou 4 Premios Oscar incluíndo a mellor montaxe, mellor son, mellor edición de son e mellores efectos visuais.",
                            ImaxeUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                            Titulo = "The Matrix"
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 2,
                            Descripcion = "Back to the Future é un filme estadounidense dirixido por Robert Zemeckis que foi estreado en 1985. Escrito por Zemeckis e Bob Gale, producido por Steven Spielberg, e protagonizado por Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover e Thomas F. Wilson.",
                            ImaxeUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                            Titulo = "Back to the Future"
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 2,
                            Descripcion = "Toy Story (en galego, Historia de xoguetes) é unha película de animación xerada por computadora de Pixar e Walt Disney Pictures. Estreouse nos Estados Unidos o 22 de novembro de 1995. Foi a primeira longametraxe totalmente animada por computadora e o primeiro proxecto importante de Pixar no cine.",
                            ImaxeUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                            Titulo = "Toy Story"
                        },
                        new
                        {
                            Id = 7,
                            CategoriaId = 3,
                            Descripcion = "Half-Life 2 (HL2) é a secuela do videoxogo Half-Life, unha aventura de videoxogos en primeira persoa. Anteriormente, o videoxogo vendíase xunto con Counter-Strike: Source, a secuela de Counter-Strike co novo motor gráfico e o motor físico (Havok) implementados e os niveis totalmente redeseñados. Actualmente pódese adquirir a través do paquete The Orange Box, que inclúe o xogo e as súas respectivas secuelas (Episode One e Episode Two) e tamén inclúe Team Fortress 2 e Portal, tamén feitos por Valve. Foi publicado o 16 de novembro de 2004, aínda que xa se podía descargar semanas antes a través de Steam. Foi galardoado como o xogo da década no décimo aniversario dos premios VGA.",
                            ImaxeUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                            Titulo = "Half-Life 2"
                        },
                        new
                        {
                            Id = 8,
                            CategoriaId = 3,
                            Descripcion = "Diablo II é un xogo de role-playing Hack-And-Slash Publicado por Blizzard Entertainment en 2000 para Microsoft Windows, Classic Mac OS e MacOS.",
                            ImaxeUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                            Titulo = "Diablo II"
                        },
                        new
                        {
                            Id = 9,
                            CategoriaId = 3,
                            Descripcion = "Día do tentáculo, tamén coñecido como Maniac Mansion II: Day of the Tentacle, [2] [3] é un xogo de aventura gráfica de 1993 desenvolvido e publicado por LucasArts. É a secuela do xogo Maniac Game Mansion de 1987. A trama segue a Bernard Bernoulli e os seus amigos de Hoagie e Laverne, xa que intentan deter o malvado tentáculo púrpura, un tentáculo sentente, desembarkado, de asumir o mundo. O xogador controla o trío e resolve crebacabezas mentres usa o tempo de viaxe para explorar diferentes períodos de historia..",
                            ImaxeUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                            Titulo = "Day of the Tentacle"
                        },
                        new
                        {
                            Id = 10,
                            CategoriaId = 3,
                            Descripcion = "A Xbox é unha consola de videojuegos domésticos e a primeira entrega da serie Xbox de consolas de videojuegos fabricados por Microsoft.",
                            ImaxeUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                            Titulo = "Xbox"
                        },
                        new
                        {
                            Id = 11,
                            CategoriaId = 3,
                            Descripcion = "O Super Nintendo Entertainment System (SNES), tamén coñecido como Super Nes ou Super Nintendo, é unha consola de videojuegos domésticos de 16 bits desenvolvida por Nintendo que foi lanzada en 1990 en Xapón e Corea do Sur.",
                            ImaxeUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                            Titulo = "Super Nintendo Entertainment System"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.ProductoType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductoTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Papel"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "E-Book"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Audiobook"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Stream"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Blu-ray"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "VHS"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "PC"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "PlayStation"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Xbox"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.ProductoVariante", b =>
                {
                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("OrixinalPrecio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductoId", "ProductoTypeId");

                    b.HasIndex("ProductoTypeId");

                    b.ToTable("ProductoVariantes");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            ProductoTypeId = 2,
                            OrixinalPrecio = 19.99m,
                            Precio = 9.99m
                        },
                        new
                        {
                            ProductoId = 1,
                            ProductoTypeId = 3,
                            OrixinalPrecio = 0m,
                            Precio = 7.99m
                        },
                        new
                        {
                            ProductoId = 1,
                            ProductoTypeId = 4,
                            OrixinalPrecio = 29.99m,
                            Precio = 19.99m
                        },
                        new
                        {
                            ProductoId = 2,
                            ProductoTypeId = 2,
                            OrixinalPrecio = 14.99m,
                            Precio = 7.99m
                        },
                        new
                        {
                            ProductoId = 3,
                            ProductoTypeId = 2,
                            OrixinalPrecio = 0m,
                            Precio = 6.99m
                        },
                        new
                        {
                            ProductoId = 4,
                            ProductoTypeId = 5,
                            OrixinalPrecio = 0m,
                            Precio = 3.99m
                        },
                        new
                        {
                            ProductoId = 4,
                            ProductoTypeId = 6,
                            OrixinalPrecio = 0m,
                            Precio = 9.99m
                        },
                        new
                        {
                            ProductoId = 4,
                            ProductoTypeId = 7,
                            OrixinalPrecio = 0m,
                            Precio = 19.99m
                        },
                        new
                        {
                            ProductoId = 5,
                            ProductoTypeId = 5,
                            OrixinalPrecio = 0m,
                            Precio = 3.99m
                        },
                        new
                        {
                            ProductoId = 6,
                            ProductoTypeId = 5,
                            OrixinalPrecio = 0m,
                            Precio = 2.99m
                        },
                        new
                        {
                            ProductoId = 7,
                            ProductoTypeId = 8,
                            OrixinalPrecio = 29.99m,
                            Precio = 19.99m
                        },
                        new
                        {
                            ProductoId = 7,
                            ProductoTypeId = 9,
                            OrixinalPrecio = 0m,
                            Precio = 69.99m
                        },
                        new
                        {
                            ProductoId = 7,
                            ProductoTypeId = 10,
                            OrixinalPrecio = 59.99m,
                            Precio = 49.99m
                        },
                        new
                        {
                            ProductoId = 8,
                            ProductoTypeId = 8,
                            OrixinalPrecio = 24.99m,
                            Precio = 9.99m
                        },
                        new
                        {
                            ProductoId = 9,
                            ProductoTypeId = 8,
                            OrixinalPrecio = 0m,
                            Precio = 14.99m
                        },
                        new
                        {
                            ProductoId = 10,
                            ProductoTypeId = 1,
                            OrixinalPrecio = 299m,
                            Precio = 159.99m
                        },
                        new
                        {
                            ProductoId = 11,
                            ProductoTypeId = 1,
                            OrixinalPrecio = 399m,
                            Precio = 79.99m
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Producto", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.ProductoVariante", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.Producto", "Producto")
                        .WithMany("Variantes")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorEcommerce.Shared.ProductoType", "ProductoType")
                        .WithMany()
                        .HasForeignKey("ProductoTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("ProductoType");
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Producto", b =>
                {
                    b.Navigation("Variantes");
                });
#pragma warning restore 612, 618
        }
    }
}