using Microsoft.EntityFrameworkCore;
using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Data
{
    public interface  IApplicationDbContext
    {
        DbSet<Student> Students { get; set; }
        Task<int> SaveChanges();
    }
}
