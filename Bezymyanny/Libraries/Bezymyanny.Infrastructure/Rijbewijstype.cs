using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezymyanny.Db
{
    public partial class Rijbewijstype
    {
        public virtual int RijbewijstypeID { get; set; }
        public virtual string Beschrijving { get; set; }
        public virtual Nullable<bool> IsDeleted { get; set; }
        public Rijbewijstype()
        {
        }
    }}