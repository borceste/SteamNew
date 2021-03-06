﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Steam.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public Nullable<int> GameId { get; set; }
        public virtual Game Game { get; set; }
       
        public String review { get; set; }
        public float rating { get; set; }
        public DateTime date { get; set; }
        public Review()
        {
            
            
        }
        public Review(string Id, int gameId, String review,float rating)
        {
            this.ApplicationUserId = Id;
            this.GameId = gameId;
            //this.user = user;
            this.review = review;
            this.rating = rating;
            this.date = DateTime.Now;
        }
        /*public void setUser(User user)
        {
            this.user = user;
        }
        public void setReview(String review)
        {
            this.review = review;
        }
        public void setRating(float rating)
        {
            this.rating = rating;
        }
        public User getUser()
        {
            return user;
        }
        public String getReview()
        {
            return review;
        }
        public float getRating()
        {
            return rating;
        }
        public DateTime getDate()
        {
            return this.date;
        }*/
    }
}