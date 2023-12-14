using Ado.Data.SqlServer;
using Bezymyanny.Db.VoertuigRepository;

namespace Bezymyanny.Db.RepositoryPacks
{
    public partial class VoertuigRepositoryPack : SqlServerTable
    {
        public virtual VoertuigQuery Query { get; set; }
        public virtual VoertuigInsert Insert { get; set; }
        public virtual VoertuigUpdate Update { get; set; }
        public virtual VoertuigDelete Delete { get; set; }
        public VoertuigRepositoryPack(SqlServerDbAccess dbAccess) : base(dbAccess)
        {
            Query = new VoertuigQuery(this);
            Insert = new VoertuigInsert(this);
            Update = new VoertuigUpdate(this);
            Delete = new VoertuigDelete(this);
        }
    }}