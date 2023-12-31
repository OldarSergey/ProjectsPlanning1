﻿using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;

namespace ProjectsPlanning.Chernetsov.Entities.DTO
{

    public class InputProject
    {
        [Required]
        [StringLength(100, ErrorMessage = "Максимальная длина {1}")]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Максимальная длина {1}")]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Категория")]
        public int SelectedValueCategory { get; set; }

        [Required]
        [Display(Name = "Приоритет")]
        public int SelectedValuePriority { get; set; }

        [Required]
        [Display(Name = "Команды")]
        public int SelectedValueTeam { get; set; }

        [Required]
        [Display(Name = "Дата окончания")]
        [DataType(DataType.Date, ErrorMessage = "Не правильная дата окончания")]
        public DateTime DueDate { get; set; }
    }
}
