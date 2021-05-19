using BusinessLogic.IService;
using Domain;
using Persistence.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Services
{
   public class FinesService : IFinesService
    {
        private readonly IFinesRepository _finesRepository;

        public FinesService(IFinesRepository finesRepository)
        {
            _finesRepository = finesRepository;
        }

        public void DeleteFine(int FineID)
        {
            _finesRepository.DeleteFine(FineID);
        }

        public Fines FindFineById(int FineID)
        {
            return _finesRepository.FindFineById(FineID);
        }

        public IEnumerable<Fines> GetFines(int page, int pageLength)
        {
            return _finesRepository.GetFines(page, pageLength);
        }

        public void InsertFine(Fines fines)
        {
            _finesRepository.InsertFine(fines);
        }

        public void UpdateFine(Fines fines)
        {
            _finesRepository.UpdateFine(fines);
        }
    }
}
