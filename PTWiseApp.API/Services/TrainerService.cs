﻿using Microsoft.EntityFrameworkCore;
using PTWiseApp.API.Data;
using PTWiseApp.API.Entities;

namespace PTWiseApp.API.Services
{
    public class TrainerService
    {

        private readonly PTWiseDbContext pTWiseDbContext;

        public TrainerService(PTWiseDbContext pTWiseDbContext)
        {
            this.pTWiseDbContext = pTWiseDbContext;
        }

        public async Task<List<Trainer>> GetTrainersAsync()
        {
            var result = await pTWiseDbContext.Trainers.ToListAsync();
            return result;
        }
    }
}
