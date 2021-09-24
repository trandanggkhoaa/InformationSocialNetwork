using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiService.Models;

namespace API_Answer.Models
{
    public class AnswerDbContext : DbContext    
    {
        public AnswerDbContext(DbContextOptions<AnswerDbContext> options) : base(options)
        {

        }
        public DbSet<AnswerManagement> AnswerManagement { get; set; }
    }
}
