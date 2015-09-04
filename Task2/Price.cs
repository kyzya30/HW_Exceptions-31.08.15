namespace Task2
{
    struct Price
    {
        public Price(string productName, string shopName, int productPrice)
        {
            ProductName = productName;
            ShopName = shopName;
            ProductPrice = productPrice;
        }
        public string ProductName { get; set; }
        public string ShopName { get; set; }
        public int ProductPrice { get; set; }

    }
}
