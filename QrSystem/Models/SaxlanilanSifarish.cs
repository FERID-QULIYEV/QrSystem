﻿using QrSystem.Models.BaseId;
using QrSystem.ViewModel;

namespace QrSystem.Models
{
    public class SaxlanilanSifarish:Base
    {
        public int? SifarislerSayi { get; set; }
        public double? ToplamGelir { get; set; }
        public string Name { get; set; }
        public DateTime? Timer { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }
        public string TableName { get; set; }
        public int QrCodeId { get; set; }
        public int ProductId { get; set; }

        public bool IsDeleted { get; set; }
        public string ImagePath { get; set; }
        public int ProductCount { get; set; }
        public Restorant Restorant { get; set; }
        public int? RestorantId { get; set; }
        public List<BasketİtemVM> OrderedProducts { get; set; }
    }
}
