using Ado.Data.SqlServer;
using Bezymyanny.Db.BestuurderRepository;

namespace Bezymyanny.Db.RepositoryPacks
{
    public partial class BestuurderRepositoryPack : SqlServerTable
    {
        public virtual BestuurderQuery Query { get; set; }
        public virtual BestuurderInsert Insert { get; set; }
        public virtual BestuurderUpdate Update { get; set; }
        public virtual BestuurderDelete Delete { get; set; }
        public BestuurderRepositoryPack(SqlServerDbAccess dbAccess) : base(dbAccess)
        {
            Query = new BestuurderQuery(this);
            Insert = new BestuurderInsert(this);
            Update = new BestuurderUpdate(this);
            Delete = new BestuurderDelete(this);
        }
    }}