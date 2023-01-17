namespace ProductReviewMangement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management");
            List<ProductReview> productReviews = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, userId = 1, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 2, userId = 2, Rating = 2, Review = "Bad", IsLike = true },
                new ProductReview() { ProductId = 3, userId = 3, Rating = 3, Review = "Average", IsLike = false },
                new ProductReview() { ProductId = 4, userId = 4, Rating = 5, Review = "Excelent", IsLike = true },
                new ProductReview() { ProductId = 5, userId = 5, Rating = 3, Review = "Average", IsLike = true },
                new ProductReview() { ProductId = 6, userId = 6, Rating = 4, Review = "Good", IsLike = false },
                new ProductReview() { ProductId = 7, userId = 7, Rating = 1, Review = "Worst", IsLike = true },
                new ProductReview() { ProductId = 8, userId = 8, Rating = 5, Review = "Excelent", IsLike = false },
                new ProductReview() { ProductId = 9, userId = 9, Rating = 5, Review = "Excelent", IsLike = true },
                new ProductReview() { ProductId = 10, userId = 10, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 11, userId = 11, Rating = 2, Review = "Bad", IsLike = false },
                new ProductReview() { ProductId = 12, userId = 12, Rating = 1, Review = "Worst", IsLike = true },
                new ProductReview() { ProductId = 13, userId = 13, Rating = 3, Review = "Average", IsLike = true },
                new ProductReview() { ProductId = 14, userId = 14, Rating = 4, Review = "Good", IsLike = false },
                new ProductReview() { ProductId = 15, userId = 15, Rating = 3, Review = "Average", IsLike = true },
             };
            ProductReviewMain productReviewMain = new ProductReviewMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select \n1.AddProductList\n2.RetriveTopRecords\n3.RetriveAllRecords\n4.RetriveAllRecordsGroupBy\n5.Exit");
                int sel = Convert.ToInt32(Console.ReadLine());
                switch (sel)
                {
                    case 1:
                        productReviewMain.AddProductList(productReviews);
                        break;
                    case 2:
                        productReviewMain.RetriveTopRecords();
                        break;
                    case 3:
                        productReviewMain.RetriveAllRecords();
                        break;
                    case 4:
                        productReviewMain.RetriveAllRecordsGroupBy();
                        break; 
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}


            
            
           
