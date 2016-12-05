using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportsStore.Models.Domain;

namespace SportsStore.Models.ViewModels.ProductViewModels
{
    public class EditViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool InStock { get; set; }
        public Availability Availability { get; set; }
        public DateTime? AvailableTill { get; set; }
        public int CategoryId { get; set; }

        public EditViewModel()
        {
            
        }

        public EditViewModel(Product p)
        {
            ProductId = p.ProductId;
            Name = p.Name;
            Description = p.Description;
            Price = p.Price;
            InStock = p.InStock;
            Availability = p.Availability;
            AvailableTill = p.AvailableTill;
            if (p.Category!=null)
            CategoryId = p.Category.CategoryId;
        }
    }
}