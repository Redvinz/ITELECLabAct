using ITELECLabAct.Data;
using ITELECLabAct.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ITELECLabAct.Services
{
    public class ConditionDataServices : IConditionDataService 
    {
        private AppDbContext _appDbContext;
        public ConditionDataServices(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task<List<ConditionModel>> GetConditionAsync()
        {
            var condition = await _appDbContext.Condition.ToListAsync();
            return condition;
        }
    }
}
