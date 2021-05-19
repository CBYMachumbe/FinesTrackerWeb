using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.IRepositories
{
    public interface IFinePostsRepository
    {
        IEnumerable<FinePost> GetFinePosts(int page, int pageLength);

        FinePost FindFinePostById(int finePostID);

        void InsertFinePost(FinePost finePost);

        void UpdateFinePost(FinePost finePost);

        void DeleteFinePost(int finePostID);

        IEnumerable<TallyObject> GetTallyObjects();
    }
}
