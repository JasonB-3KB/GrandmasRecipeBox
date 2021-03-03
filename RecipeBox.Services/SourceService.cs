using RecipeBox.Data;
using RecipeBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Services
{
    public class SourceService
    {
        private readonly Guid _userId;

        public SourceService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateSource(SourceCreate model)
        {
            var entity =
                new Source()
                {
                    OwnerId = _userId,
                    SourceName = model.SourceName,
                    SourceOrigin = model.SourceOrigin
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Sources.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<SourceListItem> GetSources()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Sources
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new SourceListItem
                                {
                                    SourceId = e.SourceId,
                                    SourceName = e.SourceName,
                                    SourceOrigin = e.SourceOrigin
                                }
                        );

                return query.ToArray();
            }
        }

        public SourceDetail GetSourceById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Sources
                        .Single(e => e.SourceId == id && e.OwnerId == _userId);
                return
                    new SourceDetail
                    {
                        SourceId = entity.SourceId,
                        SourceName = entity.SourceName,
                        SourceOrigin = entity.SourceOrigin,
                    };
            }
        }

        public bool UpdateSource(SourceEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Sources
                        .Single(e => e.SourceId == model.SourceId && e.OwnerId == _userId);

                entity.SourceId = model.SourceId;
                entity.SourceName = model.SourceName;
                entity.SourceOrigin = model.SourceOrigin;

                return ctx.SaveChanges() == 1;
            }
        }

    }
}
