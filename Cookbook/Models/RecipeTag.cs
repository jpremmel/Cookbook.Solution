namespace Cookbook.Models
{
    public class RecipeTag
    {
        public int RecipeTagId { get; set; }
        public int TagId { get; set; }
        public int RecipeId { get; set; }
        public Tag Tag { get; set; }
        public Recipe Recipe { get; set; }
    }
}