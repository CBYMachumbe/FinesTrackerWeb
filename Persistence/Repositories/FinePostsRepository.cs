using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistence.Repositories
{
    public class FinePostsRepository : GenericRepository<FinePost>, IFinePostsRepository
    {
        private readonly FinesTrackerContext finesTrackerContext;
        public FinePostsRepository()
        {
        }

        public FinePostsRepository(FinesTrackerContext finesTrackerContext) : base(finesTrackerContext)
        {
            this.finesTrackerContext = finesTrackerContext;
        }


        public void DeleteFinePost(int finePostID)
        {
            Delete(finePostID);
        }

        public FinePost FindFinePostById(int finePostID)
        {
            return finesTrackerContext.FinePosts.Include(e => e.Fine).Include(e => e.Finer)
                .Include(e => e.Finee)
                .Include(e => e.Votes)
                .Where(e => e.FinePostId == finePostID)
                .Select(e => e).FirstOrDefault();
        }

        public IEnumerable<FinePost> GetFinePosts(int page, int pageLength)
        {
            var posts = finesTrackerContext.FinePosts.Include(e => e.Fine).Include(e => e.Finer)
                .Include(e => e.Finee)
                .Include(e => e.Votes)
                .Skip(pageLength * (page - 1)).Take(pageLength).ToList();
            return posts;
        }

        public IEnumerable<TallyObject> GetTallyObjects()
        {
            List<TallyObject> tallies = new List<TallyObject>();
            var user = finesTrackerContext.Users.Select(u => u).ToList();

            user.ForEach(u => 
            {
                var posts = finesTrackerContext.FinePosts.Include(e => e.Fine)
                                                         .Include(e => e.Finer)
                                                         .Include(e => e.Finee)
                                                         .Include(e => e.Votes)
                                                         .Where(e => e.FineeId == u.UserId).Select(e => e);

                var total = posts.Count();
                double tally = posts.Where(p => p.Fine.Active).Count();
                var finesDue = (int)(tally / 3);
                tallies.Add(new TallyObject(u, total, finesDue));

            });

            return tallies;
        }

        public void InsertFinePost(FinePost finePost)
        {
            finePost.Fine.Active = true;
            finePost.Fine.DateCreated = DateTime.Now;
            Insert(finePost);
        }

        public void UpdateFinePost(FinePost finePost)
        {
            Update(finePost);
        }
    }
}
