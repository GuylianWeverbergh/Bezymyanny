using Ado.Data.SqlServer;
using Bezymyanny.Db.AdresRepository;

namespace Bezymyanny.Db.RepositoryPacks
{
    public partial class AdresRepositoryPack : SqlServerTable
    {
        public virtual AdresQuery Query { get; set; }
        public virtual AdresInsert Insert { get; set; }
        public virtual AdresUpdate Update { get; set; }
        public virtual AdresDelete Delete { get; set; }
        public AdresRepositoryPack(SqlServerDbAccess dbAccess) : base(dbAccess)
        {
            Query = new AdresQuery(this);
            Insert = new AdresInsert(this);
            Update = new AdresUpdate(this);
            Delete = new AdresDelete(this);
        }
    }}