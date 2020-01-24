using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Steam.Models
{
    public class Game
    {
        public Game()
        {
            this.Reviews = new HashSet<Review>();
            this.Genres = new HashSet<Genre>();
            this.ApplicationUsersOwned = new HashSet<ApplicationUser>();
            this.ApplicationUsersWish = new HashSet<ApplicationUser>();
            this.GameImages = new HashSet<GameImage>();
            discount = 0;
            price = 0;
            sold = 0;
            dateAdded = DateTime.Now;
        }
        [Key]
        public int GameId { get; set; }
        public String name { get; set; }
        public float price { get; set; }
        public string coverImage { get; set; }
        public String description { get; set; }
        public String developer { get; set; }
        public float rating { get; set; }

        
        public virtual ICollection<GameImage> GameImages { get; set; }
        
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsersOwned { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsersWish { get; set; }

        





        public int sold { get; set; }
        public float discount { get; set; }
        public DateTime dateAdded { get; set; }
        public float DiscountedPrice { get { return price - (price * discount / 100); } }
        public Game(int Id, String name, float price, string coverImage,
            string description, String developer, float rating, HashSet<Review> reviews,
            float discount, HashSet<Genre> genres, int sold, DateTime dateAdded)
        {
        this.GameId = Id;
        this.name = name;
        this.price = price;
        this.coverImage = coverImage;
        this.description = description;
        this.developer = developer;
        this.rating = rating;
        this.Reviews = reviews;
        this.discount = discount;
        this.Genres = genres;
        this.sold = sold;
        this.dateAdded = dateAdded;
        }
        
        /*
        public int getID()
        {
            return Id;
        }
        public void setID(int ID)
        {
            this.Id = ID;
        }
        
        public DateTime  getdateAdded()
        {
            return dateAdded;
        }
        public void setdateAdded(DateTime newDate)
        {
            this.dateAdded = newDate;
        } 
        public void setSold(int sold)
        {
            this.sold = sold;
        }
        public int getSold()
        {
            return sold;
        }
        public String getName()
        {
            return name;
        }
        public float getPrice()
        {
            if(discount!=0)
                return price/discount;
            return price;
        }
        public List<Image> getImages()
        {
            return images;
        }
        public Image getCoverImage()
        {
            return coverImage;
        }

        public String getDescription()
        {
            return description;
        }
        public String getDeveloper()
        {
            return developer;
        }
        public float getRating()
        {
            return rating;
        }
        public List<Review> GetReviews()
        {
            return reviews;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setPrice(float price)
        {
            this.price = price;
        }
        public void setImages(List<Image> images)
        {
            this.images = images;
        }
        public void setDescription(String description)
        {
            this.description = description;
        }
        public void setDeveloper(String developer)
        {
            this.developer = developer;
        }
        public void setRating(float rating)
        {
            this.rating = rating;
        }
        public void setReviews(List<Review> reviews)
        {
            if(reviews.Count==0)
                this.reviews = reviews;
            else
            {
                foreach(Review review in reviews)
                {
                    this.reviews.Add(review);
                }
            }
        }
        public void addReview(Review review)
        {
            reviews.Add(review);
        }

        public void calculateRating()
        {
            float sum = 0;
            foreach(Review r in this.reviews)
            {
                sum += r.getRating();
            }
            rating = sum / this.reviews.Count;
        }
        public void addImage(Image image)
        {
            this.images.Add(image);
        }
        public void setGenre(Genre genre)
        {
            this.genre = genre;
        }
        public Genre getGenre()
        {
            return this.genre;
        }*/
    }
}