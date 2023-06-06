using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TimeProject.Entities;

namespace Data
{
    public class ApplicationDbContext:DbContext
    {
        

        public DbSet<UserEntity> Users{get;set;}
        
    }


}