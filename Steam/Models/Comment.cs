using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Steam.Models
{
    public class Comment
    {
        //private User user;
        [Key]
        public int CommentId { get; set; }
        private String comment;
        private DateTime date;
        public virtual User User { get; set; }

        public Nullable<int> UserId { get; set; }

        public Comment()
        {
            date = DateTime.Now;
        }
        public Comment(User user, String comment)
        {
            //this.user = user;
            this.comment = comment;
            this.date = DateTime.Now;
        }
        public void setUser(User user)
        {
            //this.user = user;
        }
        public void setComment(String comment)
        {
            this.comment = comment;
        }
        /*public User getUser()
        {
            //return user;
        }*/
        public String getComment()
        {
            return comment;
        }
        public DateTime getDate()
        {
            return this.date;
        }
    }
}