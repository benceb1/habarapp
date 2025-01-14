﻿using DrinkSessionsApp.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DrinkSessionsApp.Dtos
{
    public class ConsumptionReadDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public int Amount { get; set; }
        public ProductReadDto? Product { get; set; }
    }
}
