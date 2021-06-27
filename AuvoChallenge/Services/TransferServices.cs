using AuvoChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AuvoChallenge.Services
{
    public class TransferServices
    {
        private readonly AuvoChallengeContext _context;

        public TransferServices(AuvoChallengeContext context)
        {
            _context = context;
        }

        public async Task<List<Transfer>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Transfer select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Name)
                .Include(x => x.Value)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}