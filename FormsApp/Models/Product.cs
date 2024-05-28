using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name = "Ürün Id")]
        public int ProductId { get; set; }

        [Display(Name = "Ürün Adı")]
        [Required(ErrorMessage = "Ürün Adı girilmesi zorunludur !")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Ürün Fiyatı")]
        [Required(ErrorMessage = "Ürün Fiyatı girilmesi zorunludur !")]
        [Range(0, 100000, ErrorMessage = "Ürün Fiyatı 0-100000 arasında olmak zorundadır !")]
        public decimal? Price { get; set; }

        [Display(Name = "Ürün Resmi")]
        public string? Image { get; set; } = string.Empty;

        [Display(Name = "Durum")]
        public bool IsActive { get; set; }

        [Display(Name = "Kategori")]
        [Required(ErrorMessage = "Kategori seçilmesi zorunludur !")]
        public int? CategoryId { get; set; }
    }
}