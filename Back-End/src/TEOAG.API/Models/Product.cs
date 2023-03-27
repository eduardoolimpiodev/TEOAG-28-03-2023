using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace TEOAG.API.Models
{
    public class Product
    {
        [JsonPropertyName("Product Code")]
        public int Id {get; set;}

        [JsonPropertyName("Product Name")]
        public string ProductName { get; set; }

        [JsonPropertyName("Product Description")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ProductDescription { get; set; }

        [JsonPropertyName("Product Status")]
        public Status Status { get; set; }

        [JsonPropertyName("Manufacturing Date")]
        public DateTime ManufacturingDate { get; set; }

        [JsonPropertyName("Expiration Date")]
        public DateTime ExpirationDate { get; set; }

        [JsonPropertyName("Supplier Code")]
        public int SupplierId { get; set; }

        [JsonPropertyName("Supplier Description")]
        public string SupplierDescription { get; set; }

        [JsonPropertyName("CNPJ Supplier")]
        public string CNPJSupplier { get; set; }

        public Product() { }

        public Product(int id)
        {
            Id =id;
        }

    }
}