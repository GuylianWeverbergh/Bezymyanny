using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezymyanny.Db
{
    public partial class Adres
    {
        public virtual int AdresID { get; set; }
        public virtual string Straat { get; set; }
        public virtual string Huisnummer { get; set; }
        public virtual string Postcode { get; set; }
        public virtual string Stad { get; set; }
        public virtual string Land { get; set; }
        public virtual Nullable<bool> IsDeleted { get; set; }
        public Adres()
        {
        }
    }}