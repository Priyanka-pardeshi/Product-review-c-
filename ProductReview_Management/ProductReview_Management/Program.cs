using System;
using System.Collections.Generic;

namespace ProductReview_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management system");

            List<Review_product> review = new List<Review_product>()
            {
                new Review_product() {ProductId = 1, UserId = 1, Rating = 5, Review = "Good", Like = false},
                new Review_product() {ProductId = 2, UserId = 2, Rating = 5, Review= "Good", Like = false},
                new Review_product() {ProductId = 3, UserId = 3, Rating = 4, Review = "Good", Like = true},
                new Review_product() {ProductId = 4, UserId = 4, Rating = 3, Review = "Bad", Like = true},
                new Review_product() {ProductId = 5, UserId = 5, Rating = 2, Review = "Bad", Like = true},
                new Review_product() {ProductId = 6, UserId = 6, Rating = 4, Review = "Good", Like = false},
                new Review_product() {ProductId = 7, UserId = 7, Rating = 3.5, Review = "Good", Like = false},
                new Review_product() {ProductId = 8, UserId = 8, Rating = 2.5, Review = "Bad", Like = true},
                new Review_product() {ProductId = 9, UserId = 9, Rating = 5, Review = "Good", Like = true},
                new Review_product() {ProductId = 10, UserId = 10, Rating = 3.6, Review = "Good", Like = true},
                new Review_product() {ProductId = 11, UserId = 11, Rating = 4.5, Review = "Good", Like = true},
                new Review_product() {ProductId = 12, UserId = 12, Rating = 2.8 , Review = "Good", Like = true},
                new Review_product() {ProductId = 13, UserId = 1, Rating = 1.8, Review = "Bad", Like = false},
                new Review_product() {ProductId = 14, UserId = 5, Rating = 1, Review = "Bad", Like = false},
                
            };

            foreach (var reviewList in review)
            {
                Console.WriteLine("Product ID : " + reviewList.ProductId);
                Console.WriteLine("User ID    : " + reviewList.UserId);
                Console.WriteLine("Rating     : " + reviewList.Rating);
                Console.WriteLine("Review     : " + reviewList.Review);
                Console.WriteLine("Is Like    : " + reviewList.Like + "\n");
            }
            Console.ReadKey();
        }

    }
}
