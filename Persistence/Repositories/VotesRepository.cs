using Domain;
using Persistence.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Repositories
{
    public class VotesRepository : GenericRepository<Vote>, IVotesRepository
    {
        public VotesRepository()
        {
        }

        public VotesRepository(FinesTrackerContext finesTrackerContext) : base(finesTrackerContext)
        {
        }
        public void DeleteVote(int voteID)
        {
            Delete(voteID);
        }

        public Vote FindVoteById(int voteID)
        {
            return GetById(voteID);
        }

        public IEnumerable<Vote> GetVotes(int page, int pageLength)
        {
            return GetAll(page, pageLength);
        }

        public void InsertVote(Vote vote)
        {
            Insert(vote);
        }

        public void UpdateVote(Vote vote)
        {
            Update(vote);
        }
    }
}
