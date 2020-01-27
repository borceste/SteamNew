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
    

        

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }



        public string ApplicationUserId2 { get; set; }

        public String comment { get; set; }
        public DateTime date { get; set; }


        public Comment()
        {
            
        }
        public Comment(string id1, string id2, String comment)
        {
            this.ApplicationUserId = id1;
            this.ApplicationUserId2 = id2;
            this.comment = comment;
            this.date = DateTime.Now;
        }
        /*public void setUser(User user)
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
        }
        public String getComment()
        {
            return comment;
        }
        public DateTime getDate()
        {
            return this.date;
        }*/
    }
}