﻿using Microsoft.EntityFrameworkCore;
using SPRENCIA.Domain.Models;
using SPRENCIA.Infraestructure.Contracts;

namespace SPRENCIA.Infraestructure.Repositories
{
    public class CommentRepository : ICommentRepository
    { 
        private readonly SprenciaDbContext _context;

        public CommentRepository(SprenciaDbContext dbcontext)
        {
            _context = dbcontext;
        }
    

    
        public async Task<List<Comment>> GetAll()
        {
            var comments = await _context.Comments.ToListAsync();

            return comments;
        }
    }
}
