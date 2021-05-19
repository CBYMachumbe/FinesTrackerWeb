using Domain;
using Persistence.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistence.Repositories
{
    public class FineRepository : GenericRepository<Fines>, IFinesRepository
    {
        public FineRepository()
        {
        }

        public FineRepository(FinesTrackerContext finesTrackerContext) : base(finesTrackerContext)
        {
        }

        public void DeleteFine(int FineID)
        {
             Delete(FineID);
        }

        public Fines FindFineById(int FineID)
        {
            return GetById(FineID);
        }

        public IEnumerable<Fines> GetFines(int page, int pageLength)
        {
            return GetAll(page, pageLength);
        }

        public void InsertFine(Fines fines)
        {
            Insert(fines);
        }

        public void UpdateFine(Fines fines)
        {
            Update(fines);
        }
    }
}
