using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookModel : BaseModel
    {
        public override object this[string propName]
        {
            get
            {
                if (this == null) return null;

                var type = typeof(BookModel);
                var props = type.GetProperties();
                var prop = props.FirstOrDefault(x => x.Name == propName);

                if (prop == null)
                    return null;

                return prop.GetValue(this);
            }
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Writer { get; set; }
    }
}
