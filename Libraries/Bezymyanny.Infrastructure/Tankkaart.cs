using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezymyanny.Db
{
    public partial class Tankkaart
    {
        public virtual int TankkaartID { get; set; }
        public virtual int Kaartnummer { get; set; }
        public virtual Nullable<DateTime> Geldigheidsdatum { get; set; }
        public virtual Nullable<int> Pincode { get; set; }
        public virtual Nullable<int> BestuurderID { get; set; }
        public virtual Nullable<bool> Geblokkeerd { get; set; }
        public virtual Nullable<bool> IsDeleted { get; set; }
        public Tankkaart()
        {
        }
    }}