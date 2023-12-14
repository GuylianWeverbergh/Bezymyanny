using Ado.Data.SqlServer;
using Bezymyanny.Db.RepositoryPacks;

namespace Bezymyanny.Db
{
    public partial class BezymyannyDb : SqlServerDbAccess
    {
        public virtual AdresRepositoryPack Adres { get; set; }
        public virtual BestuurderRepositoryPack Bestuurder { get; set; }
        public virtual BrandstoftypeRepositoryPack Brandstoftype { get; set; }
        public virtual RijbewijstypeRepositoryPack Rijbewijstype { get; set; }
        public virtual TankkaartRepositoryPack Tankkaart { get; set; }
        public virtual VoertuigRepositoryPack Voertuig { get; set; }
        public BezymyannyDb(string connectionString) : base(new ConnectionStringBuilder { ConnectionString = connectionString })
        {
            Adres = new AdresRepositoryPack(this);
            Bestuurder = new BestuurderRepositoryPack(this);
            Brandstoftype = new BrandstoftypeRepositoryPack(this);
            Rijbewijstype = new RijbewijstypeRepositoryPack(this);
            Tankkaart = new TankkaartRepositoryPack(this);
            Voertuig = new VoertuigRepositoryPack(this);
        }
    }
}
