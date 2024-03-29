﻿using SilkPlaster.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilkPlaster.Entities
{
    [Table("Products")]
    public class Product : EntityBase, IEntity
    {
        [Required,
        DisplayName("Ürün Adı"),
        StringLength(250, ErrorMessage = "{0} alanı max. {1} karakter olmalıdır.")]
        public string Name { get; set; }

        [Required,
        DisplayName("Kısa Açıklama"),
        StringLength(250, ErrorMessage = "{0} alanı max. {1} karakter olmalıdır.")]
        public string ShortDescription { get; set; }

        [Required,
        DisplayName("Uzun Açıklama")]
        public string LongDescription { get; set; }

        [Required,
        DisplayName("Eski Fiyat")]
        public decimal LastPrice { get; set; }

        [Required,
        DisplayName("Yeni Fiyat")]
        public decimal NewPrice { get; set; }

        public bool IsContinued { get; set; }
        public bool InStock { get; set; }


        public List<Comment> Comments { get; set; }
        public List<Basket> Baskets { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
