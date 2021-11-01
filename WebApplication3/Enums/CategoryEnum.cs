using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Enums
{
    public enum CategoryEnum
    {
        [Display(Name = "Fruits")]
        Fruits = 1,
        [Display(Name = "Vegetables")]
        Vegetables = 2,
        [Display(Name = "Ice Cream")]
        IceCream = 3,
        [Display(Name = "Indian Groceries")]
        IndianGroceries = 4,
        [Display(Name = "Pacific Groceries")]
        PacificGroceries =  5
    }
}

