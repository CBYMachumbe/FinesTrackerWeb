using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.IService
{
    public interface IFinesService
    {
        IEnumerable<Fines> GetFines(int page, int pageLength);

        Fines FindFineById(int FineID);

        void InsertFine(Fines fines);

        void UpdateFine(Fines fines);

        void DeleteFine(int FineID);
    }
}
