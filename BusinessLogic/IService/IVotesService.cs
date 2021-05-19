using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.IService
{
    public interface IVotesService
    {
        IEnumerable<Vote> GetVotes(int page, int pageLength);

        Vote FindFineById(int VoteID);

        void InsertVote(Vote Vote);

        void UpdateVote(Vote Vote);

        void DeleteVote(int VoteID);
    }
}
