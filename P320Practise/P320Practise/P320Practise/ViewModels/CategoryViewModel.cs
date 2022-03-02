using P320Practise.Models;
using System.Collections.Generic;

namespace P320Practise.ViewModels
{
    public class CategoryViewModel
    {
        public Category SelectedCategory { get; set; }

        public List<Category> Categories { get; set; }
    }
}
