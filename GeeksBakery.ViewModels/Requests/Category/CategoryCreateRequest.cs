﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ViewModels.Requests.Category
{
    public class CategoryCreateRequest
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Category Parent ID")]
        public int? ParentId { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}