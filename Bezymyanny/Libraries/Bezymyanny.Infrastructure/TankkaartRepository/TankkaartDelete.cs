using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.TankkaartRepository
{
    public partial class TankkaartDelete
    {
        private SqlServerTable table;
        public TankkaartDelete(SqlServerTable table)
        {
            this.table = table;
        }
        public virtual void ByPrimaryKey(int tankkaartid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Tankkaart] WHERE TankkaartID=@TankkaartID;";
                sqlCommand.Parameters.AddWithValue("@TankkaartID", tankkaartid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByTankkaartID(int tankkaartid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Tankkaart] WHERE TankkaartID=@TankkaartID;";
                sqlCommand.Parameters.AddWithValue("@TankkaartID", tankkaartid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByKaartnummer(int kaartnummer)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Tankkaart] WHERE Kaartnummer=@Kaartnummer;";
                sqlCommand.Parameters.AddWithValue("@Kaartnummer", kaartnummer);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByGeldigheidsdatum(Nullable<DateTime> geldigheidsdatum)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Tankkaart] WHERE Geldigheidsdatum=@Geldigheidsdatum;";
                sqlCommand.Parameters.AddWithValue("@Geldigheidsdatum", geldigheidsdatum ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByPincode(Nullable<int> pincode)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Tankkaart] WHERE Pincode=@Pincode;";
                sqlCommand.Parameters.AddWithValue("@Pincode", pincode ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByBestuurderID(Nullable<int> bestuurderid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Tankkaart] WHERE BestuurderID=@BestuurderID;";
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByGeblokkeerd(Nullable<bool> geblokkeerd)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Tankkaart] WHERE Geblokkeerd=@Geblokkeerd;";
                sqlCommand.Parameters.AddWithValue("@Geblokkeerd", geblokkeerd ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByIsDeleted(Nullable<bool> isdeleted)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "DELETE [Tankkaart] WHERE IsDeleted=@IsDeleted;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted ?? (object)DBNull.Value);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}