using BusinessLogic.IService;
using Domain;
using Persistence.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Services
{
    public class FinePostService : IFinePostService
    {
        private readonly IFinePostsRepository _finePostsRepository;

        public FinePostService(IFinePostsRepository finePotsRepository)
        {
            _finePostsRepository = finePotsRepository;
        }

        public void DeleteFinePost(int FinePostID)
        {
            _finePostsRepository.DeleteFinePost(FinePostID);
        }

        public FinePost FindFineById(int FinePostID)
        {
            return _finePostsRepository.FindFinePostById(FinePostID);
        }

        public IEnumerable<FinePost> GetFinePosts(int page, int pageLength)
        {
            return _finePostsRepository.GetFinePosts(page, pageLength);
        }

        public IEnumerable<TallyObject> GetTallyObjects()
        {
           return _finePostsRepository.GetTallyObjects();
        }

        public void InsertFinePost(FinePost FinePost)
        {
            _finePostsRepository.InsertFinePost(FinePost);
        }

        public void UpdateFinePost(FinePost FinePost)
        {
            _finePostsRepository.UpdateFinePost(FinePost);
        }
    }
}
