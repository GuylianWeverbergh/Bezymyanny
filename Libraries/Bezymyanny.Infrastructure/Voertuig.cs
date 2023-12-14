using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezymyanny.Db
{
    public partial class Voertuig
    {
        public virtual int VoertuigID { get; set; }
        public virtual string Merk { get; set; }
        public virtual string Model { get; set; }
        public virtual string Chassisnummer { get; set; }
        public virtual string Nummerplaat { get; set; }
        public virtual int BrandstoftypeId { get; set; }
        public virtual string Kleur { get; set; }
        public virtual Nullable<byte> AantalDeuren { get; set; }
        public virtual Nullable<int> BestuurderID { get; set; }
        public virtual Nullable<bool> IsDeleted { get; set; }
        public Voertuig()
        {
        }
    }}