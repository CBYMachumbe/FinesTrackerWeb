using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.IService
{
    public interface IFinePostService
    {
        IEnumerable<FinePost> GetFinePosts(int page, int pageLength);

        FinePost FindFineById(int FinePostID);

        void InsertFinePost(FinePost FinePost);

        void UpdateFinePost(FinePost FinePost);

        void DeleteFinePost(int FinePostID);

        IEnumerable<TallyObject> GetTallyObjects();
    }
}
