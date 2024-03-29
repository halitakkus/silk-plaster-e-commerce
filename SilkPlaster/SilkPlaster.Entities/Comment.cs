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
    [Table("Comments")]
    public class Comment : EntityBase, IEntity
    {
        [Required,
        DisplayName("İçerik"),
        StringLength(50, ErrorMessage = "{0} alanı max. {1} karakter olmalıdır.")]
        public string Text { get; set; }

        [Required]
        public byte StarCount { get; set; }
        public int ParentId { get; set; }


        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
