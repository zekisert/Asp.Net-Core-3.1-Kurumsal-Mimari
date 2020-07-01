using System.Collections.Generic;
using Entities.Concrete;

namespace MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; internal set; }
    }
}