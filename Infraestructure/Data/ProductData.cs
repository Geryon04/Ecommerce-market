using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data
{
    public class ProductData
    {
        public static void SeedData(EntityTypeBuilder<Product> builder){
            builder.HasData(
                    //Electrodomesticos
                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        CategoryId = 1,
                        Discount = 17},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Aire acondicionado",
                        Description = "Aire acondicionado split frio/calor Carrier XPower 5120W 4400F 53HVG1801E",
                        Price = 1199999,
                        CategoryId = 1,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Smart TV",
                        Description = "Smart TV 32 pulgadas HD Android TV Admiral AD32E3A",
                        Price = 199999,
                        CategoryId = 1,
                        Discount = 30},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Lavaropas Carga Frontal",
                        Description = "Lavaropas carga frontal 6kg 800 RPM Drean Next 6.08 ECO",
                        Price = 669999,
                        CategoryId = 1,
                        Discount = 24},

                    //Tecnologia y electronica
                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Celular Samsung",
                        Description = "Celular Samsung Galaxy A14 128GB Black",
                        Price = 239999,
                        CategoryId = 2,
                        Discount = 33},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Celular Xiaomi",
                        Description = "Celular Xiaomi Redmi Note 11 128GB Negro",
                        Price = 339999,
                        CategoryId = 2,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Notebook Lenovo",
                        Description = "Notebook Lenovo IdeaPad 1 14 pulgadas Intel Celeron 4GB 128GB SSD 82V60027AR",
                        Price = 699999,
                        CategoryId = 2,
                        Discount = 14},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Impresora multifuncion",
                        Description = "Impresora Multifunción HP Deskjet 2775",
                        Price = 189999,
                        CategoryId = 2,
                        Discount = 10},

                    //Moda y accesorios
                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Campera",
                        Description = "Campera canguro ride",
                        Price = 51999,
                        CategoryId = 3,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Buzo",
                        Description = "Buzo Anorak new fit",
                        Price = 43999,
                        CategoryId = 3,
                        Discount = 45},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Bufanda",
                        Description = "Bufanda de lana estampada desflecada",
                        Price = 3500,
                        CategoryId = 3,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Cartera",
                        Description = "Cartera / Bandolera importada rígida matelasse soft cuadrado con doble broche imantado.  Manija corta fija y manija larga desmontable y regulable.",
                        Price = 12500,
                        CategoryId = 3,
                        Discount = 5},

                    //Hogar y decoraccion
                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Sillas de comedor",
                        Description = "Combo 4 Silla de Comedor Eames Home",
                        Price = 163017,
                        CategoryId = 4,
                        Discount = 30},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Sillon individual",
                        Description = "Sillón Individual escandinavo CH25 Hansen",
                        Price = 971285,
                        CategoryId = 4,
                        Discount = 25},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Mesa",
                        Description = "Mesa de Comedor Thora",
                        Price = 970697,
                        CategoryId = 4,
                        Discount = 30},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Juego de living",
                        Description = "Juego de Living de 3 Sillones + Mesa Salerno",
                        Price = 2881015,
                        CategoryId = 4,
                        Discount = 25},

                    //Salud y belleza
                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Kit de limpieza",
                        Description = "Kit doble de limpieza para pieles grasas libra niacinamida",
                        Price = 18697,
                        CategoryId = 5,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Kit para piel cabelluda",
                        Description = "Kit Regulacion Piel Cabelluda Mixta/grasa( Incluye Neceser + Instructivo de uso)",
                        Price = 36600,
                        CategoryId = 5,
                        Discount = 13},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Serum bifasico",
                        Description = "Serum bifasico revitalizante con niacinamida y agua de rosas",
                        Price = 5000,
                        CategoryId = 5,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Suero hialuronico",
                        Description = "Suero hialuronico + niacinamida marca Libra Cosmetica",
                        Price = 6752,
                        CategoryId = 5,
                        Discount = 0},

                    //Deportes y ocio
                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Zapatillas Deportivas",
                        Description = "Zapatillas deportivas de entrenamiento Topper Squat",
                        Price = 50000,
                        CategoryId = 6,
                        Discount = 12},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Shorts deportivos",
                        Description = "Shorts Alfest - futbol, running, basquet, gimnasio",
                        Price = 4440,
                        CategoryId = 6,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Bote inflable",
                        Description = "Bestway 61052 bote inflable viaje/ocio",
                        Price = 21880,
                        CategoryId = 6,
                        Discount = 10},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Tabla de surf",
                        Description = "Tabla de surf 5.10 A 6.4 Stickwave",
                        Price = 863000,
                        CategoryId = 6,
                        Discount = 20},

                    //Juguetes y juegos
                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Jenga",
                        Description = "Jenga de mesa 54 piezas Wiss Toy",
                        Price = 9900,
                        CategoryId = 7,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Set de policia",
                        Description = "Set policia super realista, 6 piezas  con helicoptero - 10909",
                        Price = 5520,
                        CategoryId = 7,
                        Discount = 10},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Juego de encastre",
                        Description = "Momodisk - Juego de encastre gigante de 25 piezas",
                        Price = 48500,
                        CategoryId = 7,
                        Discount = 15},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Camion de juguete",
                        Description = "Camion militar desarmable de juguete con herramientas",
                        Price = 2400,
                        CategoryId = 7,
                        Discount = 0},

                    //Alimentos y bebidas
                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Leche entera",
                        Description = "Leche entera larga vida Veronica Tetra x 1Lt",
                        Price = 478,
                        CategoryId = 8,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Coca-Cola",
                        Description = "Coca-Cola original, gaseosa sabor cola",
                        Price = 2900,
                        CategoryId = 8,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Pure de tomate",
                        Description = "Pure de tomate Noel Brick x 520 Gr",
                        Price = 970,
                        CategoryId = 8,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Jugo en polvo",
                        Description = "Jugo en polvo Arcor Naranja dulce 18 Gr",
                        Price = 250,
                        CategoryId = 8,
                        Discount = 0},

                    //Libros y material educativo
                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Redes de computadoras",
                        Description = "Libro 'Redes de computadoras' de Andrew S. Tanenbaum Nva Edicion",
                        Price = 58000,
                        CategoryId = 9,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Flashcards de anatomia",
                        Description = "Libro 'Netter flashcards de anatomia: miembros' de John Hansen ",
                        Price = 40153,
                        CategoryId = 9,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "El señor de los anillos",
                        Description = "coleccion El señor de los anillos - Tolkien - Set x 3 libros",
                        Price = 39900,
                        CategoryId = 9,
                        Discount = 10},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Dune",
                        Description = "Saga de libros Dune 1-6 - Frank Herbert",
                        Price = 109000,
                        CategoryId = 9,
                        Discount = 14},

                    //Jardineria y bricolaje
                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Kit de jardineria",
                        Description = "Kit de herramientas de jardineria Acero inoxidable C/bolsa",
                        Price = 398689,
                        CategoryId = 10,
                        Discount = 30},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Fumigador",
                        Description = "Pulverizador fumigador para jardineria 2l Harden",
                        Price = 2388,
                        CategoryId = 10,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Kit de bricolaje",
                        Description = "Kit de herramientas de bricolaje para el hogar 25 piezas",
                        Price = 138460,
                        CategoryId = 10,
                        Discount = 15},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        ProductName = "Kit de silicona",
                        Description = "Kit de fabricacion de mldes de silicona AB 1:1 para bricolaje",
                        Price = 13886,
                        CategoryId = 10,
                        Discount = 0}
                );
        }
    }
}