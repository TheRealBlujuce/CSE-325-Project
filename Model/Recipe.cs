
namespace Team07
{
    // Represents a pre-configured template for a recipe
    public class Recipe
    {
        public string? id { get; set; }

        public string name { get; set; }
    
        public string description { get; set; }

        public List<string> ingredients { get; set; }

        public string instructions { get; set; }

        public string author { get; set; }
        
        public DateTime date { get; set; }

        public string imageUrl { get; set; }

        public string GetRecipeURL()
        {
            if(id != null){
                return "recipe/" + this.id;
            } else {
                return "recipe";
            }
        }

        // Usage example
        // public Recipe(int _id, string _name, string _description, List<string> _ingredients, string _author, DateTime _date, string _url)
        // {
        //     id = _id;
        //     name = _name;
        //     ingredients = _ingredients;
        //     author = _author;
        //     date = _date;
        //     imageUrl = _url;
        // }
    }
}
