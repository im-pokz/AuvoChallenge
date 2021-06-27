using AuvoChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using AuvoChallenge.Models.Enums;

namespace AuvoChallenge.Data
{
    public class SeedingService
    {
        private readonly AuvoChallengeContext _context;

        public SeedingService(AuvoChallengeContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Transfer.Any())
            {
                return; //DB has been seeded
            }

            Transfer t1 = new Transfer(1, "Mantis", 2000.0, new DateTime(2021, 5, 10), "Teste", TransferType.DOC);
            Transfer t2 = new Transfer(2, "Pokz", 1000.0, new DateTime(2021, 5, 26), "New", TransferType.PIX);
            Transfer t3 = new Transfer(3, "Stone", 3000.0, new DateTime(2021, 3, 12), "Obs", TransferType.TED);
            Transfer t4 = new Transfer(4, "Husky", 800.0, new DateTime(2021, 1, 29), "Teste2", TransferType.DOC);
            Transfer t5 = new Transfer(5, "Digolas", 1200.0, DateTime.Now, "Alo", TransferType.PIX);
            Transfer t6 = new Transfer(6, "Caiao", 1400.0, new DateTime(2021, 6, 26), "Novo", TransferType.DOC);

            _context.Transfer.AddRange(t1, t2, t3, t4, t5, t6);

            _context.SaveChanges();
        }
    }
}