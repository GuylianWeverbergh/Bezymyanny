using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezymyanny.Db
{
    public partial class Brandstoftype
    {
        public virtual int BrandstoftypeID { get; set; }
        public virtual string Beschrijving { get; set; }
        public virtual Nullable<bool> IsDeleted { get; set; }
        public Brandstoftype()
        {
        }
    }}