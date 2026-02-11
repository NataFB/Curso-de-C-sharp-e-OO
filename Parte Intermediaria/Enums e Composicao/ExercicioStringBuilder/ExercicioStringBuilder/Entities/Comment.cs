namespace ExercicioStringBuilder.Entities
{
    class Comment
    {
        //Auto-implemented property for comment text + constructors
        public String Text { get; set; }

        public Comment()
        {
        }

        public Comment(String text)
        {
            Text = text;
        }
    }
}
