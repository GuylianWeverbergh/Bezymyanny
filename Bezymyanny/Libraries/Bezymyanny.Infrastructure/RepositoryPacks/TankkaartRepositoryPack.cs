using Ado.Data.SqlServer;
using Bezymyanny.Db.TankkaartRepository;

namespace Bezymyanny.Db.RepositoryPacks
{
    public partial class TankkaartRepositoryPack : SqlServerTable
    {
        public virtual TankkaartQuery Query { get; set; }
        public virtual TankkaartInsert Insert { get; set; }
        public virtual TankkaartUpdate Update { get; set; }
        public virtual TankkaartDelete Delete { get; set; }
        public TankkaartRepositoryPack(SqlServerDbAccess dbAccess) : base(dbAccess)
        {
            Query = new TankkaartQuery(this);
            Insert = new TankkaartInsert(this);
            Update = new TankkaartUpdate(this);
            Delete = new TankkaartDelete(this);
        }
    }}