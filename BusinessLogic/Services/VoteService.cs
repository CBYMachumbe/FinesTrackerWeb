using BusinessLogic.IService;
using Domain;
using Persistence.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Services
{
    public class VoteService : IVotesService
    {
        private IVotesRepository _voteRepository;
        public VoteService(IVotesRepository _voteRepository)
        {
            this._voteRepository = _voteRepository;
        }
        public void DeleteVote(int VoteID)
        {
            _voteRepository.DeleteVote(VoteID);
        }

        public Vote FindFineById(int VoteID)
        {
            return _voteRepository.FindVoteById(VoteID);
        }

        public IEnumerable<Vote> GetVotes(int page, int pageLength)
        {
            return _voteRepository.GetVotes(page, pageLength);
        }

        public void InsertVote(Vote Vote)
        {
            _voteRepository.InsertVote(Vote);
        }

        public void UpdateVote(Vote Vote)
        {
            _voteRepository.UpdateVote(Vote);
        }
    }
}
