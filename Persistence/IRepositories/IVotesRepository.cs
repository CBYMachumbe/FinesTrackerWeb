using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.IRepositories
{
    public interface IVotesRepository
    {
        IEnumerable<Vote> GetVotes(int page, int pageLength);

        Vote FindVoteById(int voteID);

        void InsertVote(Vote vote);

        void UpdateVote(Vote vote);

        void DeleteVote(int voteID);
    }
}
