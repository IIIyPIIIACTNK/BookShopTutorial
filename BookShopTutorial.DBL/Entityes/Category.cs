using BookShopTutorial.DBL.Entityes.Base;

namespace BookShopTutorial.DBL.Entityes
{
    public class Category : NamedEntity 
    {
        public virtual ICollection<Book> Books { get; set;}
    }
}
