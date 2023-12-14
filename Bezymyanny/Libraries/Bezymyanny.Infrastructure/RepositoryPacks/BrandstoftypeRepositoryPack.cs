using Ado.Data.SqlServer;
using Bezymyanny.Db.BrandstoftypeRepository;

namespace Bezymyanny.Db.RepositoryPacks
{
    public partial class BrandstoftypeRepositoryPack : SqlServerTable
    {
        public virtual BrandstoftypeQuery Query { get; set; }
        public virtual BrandstoftypeInsert Insert { get; set; }
        public virtual BrandstoftypeUpdate Update { get; set; }
        public virtual BrandstoftypeDelete Delete { get; set; }
        public BrandstoftypeRepositoryPack(SqlServerDbAccess dbAccess) : base(dbAccess)
        {
            Query = new BrandstoftypeQuery(this);
            Insert = new BrandstoftypeInsert(this);
            Update = new BrandstoftypeUpdate(this);
            Delete = new BrandstoftypeDelete(this);
        }
    }}