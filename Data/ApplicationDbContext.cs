using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace Data
{
    public class ApplicationDbContext:DbContext
    {
        

        public DbSet<UserEntity> Users{get;set;}
        public DbSet<CommentEntity> Comments{get;set;}
        public DbSet<PostEntity> Posts{get;set;}

        public DbSet<ReplyEntity> Replies{get;set;}
        
    }


}