using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone_Inventory
{
    class CellPhone
    {
        // 欄位
        private string _brand;   // 手機品牌
        private string _model;   // 手機型號
        private decimal _price;  // 建議售價

        // 建構子
        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = 0m;
        }

        // Brand 屬性
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        // Model 屬性
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        // Price 屬性
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
