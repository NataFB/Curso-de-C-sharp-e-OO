using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioStringBuilder.Entities
{
    class Post
    {
        // Properties of the Post class + a list to hold comments
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        // Constructors Without comments
        public Post()
        {
        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        // Methods to add and remove comments
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        // Overriding ToString method to display post details
        public override string ToString()
        {
            // (First time using StringBuilder)
            // StringBuilder is a class that allows you to efficiently construct strings, especially when you need to concatenate multiple parts.
            StringBuilder sb = new StringBuilder(); // Create a new StringBuilder instance
            sb.AppendLine(Title); // Add the title followed by a newline
            sb.Append(Likes); // Add the number of likes
            sb.Append(" Likes - "); // Add the string " Likes - " in the same line
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss")); // Add the formatted date and time followed by a newline
            sb.AppendLine(Content); // Add the content followed by a newline
            sb.AppendLine("Comments:"); // Add the string "Comments:" followed by a newline
            foreach (Comment c in Comments) // Iterate through each comment in the Comments list 
            {
                sb.AppendLine(c.Text); // Add the text of each comment followed by a newline
            }
            return sb.ToString(); // Convert the StringBuilder to a string and return it
        }
    }
}
