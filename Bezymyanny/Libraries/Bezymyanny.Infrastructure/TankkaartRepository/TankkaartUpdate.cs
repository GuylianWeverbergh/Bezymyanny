using Ado.Data.SqlServer;
using System;
using System.Data.SqlClient;

namespace Bezymyanny.Db.TankkaartRepository
{
    public partial class TankkaartUpdate
    {
        private SqlServerTable table;
        public TankkaartUpdate(SqlServerTable table)
        {
            this.table = table;
        }
        private void SetSqlCommandParameter(SqlCommand sqlCommand, Tankkaart tankkaart)
        {
            sqlCommand.Parameters.AddWithValue("@TankkaartID", tankkaart.TankkaartID);
            sqlCommand.Parameters.AddWithValue("@Kaartnummer", tankkaart.Kaartnummer);
            sqlCommand.Parameters.AddWithValue("@Geldigheidsdatum", tankkaart.Geldigheidsdatum ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@Pincode", tankkaart.Pincode ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@BestuurderID", tankkaart.BestuurderID ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@Geblokkeerd", tankkaart.Geblokkeerd ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@IsDeleted", tankkaart.IsDeleted ?? (object)DBNull.Value);
        }
        public virtual void ByPrimaryKey(Tankkaart tankkaart)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Tankkaart] SET Kaartnummer=@Kaartnummer, Geldigheidsdatum=@Geldigheidsdatum, Pincode=@Pincode, BestuurderID=@BestuurderID, Geblokkeerd=@Geblokkeerd, IsDeleted=@IsDeleted WHERE TankkaartID=@TankkaartID;";
                SetSqlCommandParameter(sqlCommand, tankkaart);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByTankkaartID(Tankkaart tankkaart)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Tankkaart] SET Kaartnummer=@Kaartnummer, Geldigheidsdatum=@Geldigheidsdatum, Pincode=@Pincode, BestuurderID=@BestuurderID, Geblokkeerd=@Geblokkeerd, IsDeleted=@IsDeleted WHERE TankkaartID=@TankkaartID;";
                SetSqlCommandParameter(sqlCommand, tankkaart);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByKaartnummer(Tankkaart tankkaart)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Tankkaart] SET Geldigheidsdatum=@Geldigheidsdatum, Pincode=@Pincode, BestuurderID=@BestuurderID, Geblokkeerd=@Geblokkeerd, IsDeleted=@IsDeleted WHERE Kaartnummer=@Kaartnummer;";
                SetSqlCommandParameter(sqlCommand, tankkaart);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByGeldigheidsdatum(Tankkaart tankkaart)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Tankkaart] SET Kaartnummer=@Kaartnummer, Pincode=@Pincode, BestuurderID=@BestuurderID, Geblokkeerd=@Geblokkeerd, IsDeleted=@IsDeleted WHERE Geldigheidsdatum=@Geldigheidsdatum;";
                SetSqlCommandParameter(sqlCommand, tankkaart);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByPincode(Tankkaart tankkaart)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Tankkaart] SET Kaartnummer=@Kaartnummer, Geldigheidsdatum=@Geldigheidsdatum, BestuurderID=@BestuurderID, Geblokkeerd=@Geblokkeerd, IsDeleted=@IsDeleted WHERE Pincode=@Pincode;";
                SetSqlCommandParameter(sqlCommand, tankkaart);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByBestuurderID(Tankkaart tankkaart)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Tankkaart] SET Kaartnummer=@Kaartnummer, Geldigheidsdatum=@Geldigheidsdatum, Pincode=@Pincode, Geblokkeerd=@Geblokkeerd, IsDeleted=@IsDeleted WHERE BestuurderID=@BestuurderID;";
                SetSqlCommandParameter(sqlCommand, tankkaart);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByGeblokkeerd(Tankkaart tankkaart)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Tankkaart] SET Kaartnummer=@Kaartnummer, Geldigheidsdatum=@Geldigheidsdatum, Pincode=@Pincode, BestuurderID=@BestuurderID, IsDeleted=@IsDeleted WHERE Geblokkeerd=@Geblokkeerd;";
                SetSqlCommandParameter(sqlCommand, tankkaart);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void ByIsDeleted(Tankkaart tankkaart)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Tankkaart] SET Kaartnummer=@Kaartnummer, Geldigheidsdatum=@Geldigheidsdatum, Pincode=@Pincode, BestuurderID=@BestuurderID, Geblokkeerd=@Geblokkeerd WHERE IsDeleted=@IsDeleted;";
                SetSqlCommandParameter(sqlCommand, tankkaart);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void KaartnummerByPrimaryKey(int kaartnummer, int tankkaartid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Tankkaart] SET Kaartnummer=@Kaartnummer WHERE TankkaartID=@TankkaartID;";
                sqlCommand.Parameters.AddWithValue("@Kaartnummer", kaartnummer);
                sqlCommand.Parameters.AddWithValue("@TankkaartID", tankkaartid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void GeldigheidsdatumByPrimaryKey(Nullable<DateTime> geldigheidsdatum, int tankkaartid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Tankkaart] SET Geldigheidsdatum=@Geldigheidsdatum WHERE TankkaartID=@TankkaartID;";
                sqlCommand.Parameters.AddWithValue("@Geldigheidsdatum", geldigheidsdatum ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@TankkaartID", tankkaartid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void PincodeByPrimaryKey(Nullable<int> pincode, int tankkaartid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Tankkaart] SET Pincode=@Pincode WHERE TankkaartID=@TankkaartID;";
                sqlCommand.Parameters.AddWithValue("@Pincode", pincode ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@TankkaartID", tankkaartid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void BestuurderIDByPrimaryKey(Nullable<int> bestuurderid, int tankkaartid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Tankkaart] SET BestuurderID=@BestuurderID WHERE TankkaartID=@TankkaartID;";
                sqlCommand.Parameters.AddWithValue("@BestuurderID", bestuurderid ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@TankkaartID", tankkaartid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void GeblokkeerdByPrimaryKey(Nullable<bool> geblokkeerd, int tankkaartid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Tankkaart] SET Geblokkeerd=@Geblokkeerd WHERE TankkaartID=@TankkaartID;";
                sqlCommand.Parameters.AddWithValue("@Geblokkeerd", geblokkeerd ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@TankkaartID", tankkaartid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
        public virtual void IsDeletedByPrimaryKey(Nullable<bool> isdeleted, int tankkaartid)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "UPDATE [Tankkaart] SET IsDeleted=@IsDeleted WHERE TankkaartID=@TankkaartID;";
                sqlCommand.Parameters.AddWithValue("@IsDeleted", isdeleted ?? (object)DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@TankkaartID", tankkaartid);
                table.DbAccess.Commands.Add(sqlCommand);
            }
        }
    }}