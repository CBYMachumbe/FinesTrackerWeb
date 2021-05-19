using Domain;
using FinesTracker.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinesTracker.Mappers
{
    public class FinesMapper
    {
        public static Fines MapToFines(FinesDTO finesDTO)
        {
            var fines = new Fines();
            fines.FineId = finesDTO.FineId;
            fines.FineTitle = finesDTO.FineTitle;
            fines.FineText = finesDTO.FineText;

            return fines;
        }
    }
}
