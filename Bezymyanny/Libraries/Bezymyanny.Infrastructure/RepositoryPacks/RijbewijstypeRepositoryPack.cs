using Ado.Data.SqlServer;
using Bezymyanny.Db.RijbewijstypeRepository;

namespace Bezymyanny.Db.RepositoryPacks
{
    public partial class RijbewijstypeRepositoryPack : SqlServerTable
    {
        public virtual RijbewijstypeQuery Query { get; set; }
        public virtual RijbewijstypeInsert Insert { get; set; }
        public virtual RijbewijstypeUpdate Update { get; set; }
        public virtual RijbewijstypeDelete Delete { get; set; }
        public RijbewijstypeRepositoryPack(SqlServerDbAccess dbAccess) : base(dbAccess)
        {
            Query = new RijbewijstypeQuery(this);
            Insert = new RijbewijstypeInsert(this);
            Update = new RijbewijstypeUpdate(this);
            Delete = new RijbewijstypeDelete(this);
        }
    }}