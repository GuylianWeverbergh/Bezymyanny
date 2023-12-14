using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezymyanny.Db
{
    public partial class Bestuurder
    {
        public virtual int BestuurderID { get; set; }
        public virtual string Naam { get; set; }
        public virtual string Voornaam { get; set; }
        public virtual Nullable<int> AdresID { get; set; }
        public virtual Nullable<DateTime> Geboortedatum { get; set; }
        public virtual string Rijksregisternummer { get; set; }
        public virtual int RijbewijstypeID { get; set; }
        public virtual Nullable<int> VoertuigID { get; set; }
        public virtual Nullable<int> TankkaartID { get; set; }
        public virtual Nullable<bool> IsDeleted { get; set; }
        public Bestuurder()
        {
        }
    }}