using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTutorial.DBL.Entityes.Base
{
    public abstract class Entity
    {
        public int Id { get; set; }

        //public abstract class NamedEntity : Entity
        //{
        //    public string Name { get; set; }
        //}

        //public abstract class Person : NamedEntity 
        //{
        //     /// <summary>
        //    /// Фамилия
        //    /// </summary>
        //    public string Surname { get; set; }
        //    /// <summary>
        //    /// Отчество
        //    /// </summary>
        //    public string Patronymic { get; set; }
        //}
    }
}
