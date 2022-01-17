using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsultasLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ProductList = new List<Product>()
            {
                new Product { Id = 1, IdCategory = 3, Name = "Camiseta", Status = true, Value = 90 },
                new Product { Id = 2, IdCategory = 3, Name = "Calça", Status = true, Value = 320 },
                new Product { Id = 3, IdCategory = 1, Name = "Video Game", Status = true, Value = 999 },
                new Product { Id = 4, IdCategory = 1, Name = "TV", Status = true, Value = 1500 },
                new Product { Id = 5, IdCategory = 1, Name = "Maquina de lavar", Status = false, Value = 600 },
                new Product { Id = 6, IdCategory = 1, Name = "Microondas", Status = true, Value = 400 },
                new Product { Id = 7, IdCategory = 2, Name = "Arroz", Status = true, Value = 23 },
                new Product { Id = 8, IdCategory = 2, Name = "Batata", Status = true, Value = 12 },
                new Product { Id = 9, IdCategory = 2, Name = "Cenoura", Status = true, Value = 15 },
                new Product { Id = 10, IdCategory = 1, Name = "Geladeira", Status = true, Value = 1000 },
            };

            var CategoryList = new List<Category>()
            {
                new Category{Id = 1, Status = true, Name = "Eletrônicos"},
                new Category{Id = 2, Status = true, Name = "Alimentos"},
                new Category{Id = 3, Status = true, Name = "Vestuário"},
            };

            //FILTRANDO DADOS
            #region Filtrando por Nome
            //Console.WriteLine("Filtrando por nome: BaTaTa");
            //var consult = from produdct in ProductList
            //              where produdct.Name.ToLower() == "BaTaTa".ToLower()
            //              select produdct;
            #endregion

            #region Filtrando por letra
            //SUBSTRING(0, 1) PRIMEIRO VALOR INDICA POSIÇÃO, SEGUNDO VALOR INDICA QUANTIDADE DE CARACTERES PARA PESQUISAR
            //Console.WriteLine("Filtrando por letra: A");
            //var consult = from produdct in ProductList
            //              where produdct.Name.ToLower().Substring(0, 1) == "A".ToLower()
            //              select produdct;
            #endregion

            #region Filtrando por letra e Status
            //Console.WriteLine("Filtrando por letra: M e Status: False");
            //var consult = from produdct in ProductList
            //              where produdct.Name.ToLower().Substring(0, 1) == "M".ToLower() && produdct.Status == false
            //              select produdct;
            #endregion

            #region Filtrando e Ordenando por ID
            //DESCENDING ORDENA DE FORMA DECRESCENTE
            //Console.WriteLine("Filtrando e Ordenando por ID");
            //var consult = from produdct in ProductList
            //              where produdct.Id >= 5 && produdct.Id <= 8
            //              orderby produdct.Id //descending
            //              select produdct;
            #endregion

            #region EXECUTANDO CONSULTA
            //foreach (var result in consult)
            //{
            //    Console.WriteLine($"{result.Id} | {result.Name} | {result.Value} | {result.IdCategory} | {result.Status}");
            //}
            #endregion


            //PROJETANDO DADOS COM SELECT
            #region Projetando nome dos produtos
            //var consult = from product in ProductList
            //              select product.Name;

            //foreach (var result in consult)
            //{
            //    Console.WriteLine($"{result}");
            //}
            #endregion

            #region Projetando com TIPO ANONIMO
            //var consult = from product in ProductList
            //              select new { product.Name, product.Value };

            //foreach (var result in consult)
            //{
            //    Console.WriteLine($"{result.Name} | {result.Value}");
            //}
            #endregion

            #region Projetando utilizando uma CLASS(ProductDto)
            //var consult = from product in ProductList
            //              select new ProductDto
            //              {
            //                  Name = product.Name,
            //                  Value = product.Value,
            //                  Status = product.Status,
            //              };                          

            //foreach (var result in consult)
            //{
            //    Console.WriteLine($"{result.Name} | {result.Value} | {result.Status} ");
            //}
            #endregion

            //GROUPBY
            #region Agrupando com GROUPBY
            //var consult = from products in ProductList
            //              orderby products.IdCategory ascending
            //              group products by products.IdCategory into groupProducts                    
            //              select groupProducts;

            //foreach (var result in consult)
            //{
            //    Console.WriteLine($"\n{result.Key}\n");
            //    foreach (var products in result)
            //    {
            //        Console.WriteLine($"Produto: {products.Name} | Categoria: {products.IdCategory}");
            //    }
            //}
            #endregion

            //JOIN E GROUPBY
            #region
            //var consult = from products in ProductList
            //              orderby products.IdCategory ascending
            //              join productsCategory in CategoryList
            //              on products.IdCategory equals productsCategory.Id
            //              select new
            //              {
            //                  Product = products,
            //                  Category = productsCategory
            //              };

            //foreach(var result in consult)
            //{
            //    Console.WriteLine($"{result.Product.Name} | {result.Category.Name}");
            //}
            #endregion

        }
    }
}


class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
    public decimal Value { get; set; }
    public int IdCategory { get; set; }
}

class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}

class ProductDto
{
    public string Name { get; set; }
    public decimal Value { get; set; }
    public bool Status { get; set; }
}