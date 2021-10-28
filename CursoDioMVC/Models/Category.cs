﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoDioMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required( ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }

   
    }
}
