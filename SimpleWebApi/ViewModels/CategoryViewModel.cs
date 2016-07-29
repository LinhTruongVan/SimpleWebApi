using System.Collections.Generic;

namespace SimpleWebApi.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GadgetViewModel> Gadgets { get; set; }
    }
}