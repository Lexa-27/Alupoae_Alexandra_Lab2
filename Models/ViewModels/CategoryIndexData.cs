﻿using Alupoae_Alexandra_Lab2.Models;

namespace Alupoae_Alexandra_Lab2.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
