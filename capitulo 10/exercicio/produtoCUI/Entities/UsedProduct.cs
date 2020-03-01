using System;
using produtoCUI.Entities;

namespace produtoCUI.Entities {
  class UsedProduct : Product {
    public DateTime ManufactureDate { get; set; }

    public UsedProduct () { }
    public UsedProduct (string name, double price, DateTime manufactureDate) : base (name, price) {
      ManufactureDate = ManufactureDate;
    }
    public override string PriceTag () {
      return ($"{Name} $ {Price.ToString("F2")} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyy")})");
    }
  }
}