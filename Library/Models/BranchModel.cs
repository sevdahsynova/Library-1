using Library.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BranchModel : BaseModel
    {
        public override object this[string propName]
        {
            get
            {
                if (this == null) return null;

                var type = typeof(BranchModel);
                var props = type.GetProperties();
                var prop = props.FirstOrDefault(x => x.Name == propName);
                
                if(prop == null)
                    return null;

                return prop.GetValue(this);
            }
        }


        [Export("Name",1)]
        public string Name { get; set; }
        [Export("Address",3)]
        public string Address { get; set; }
        [Export("Phone Number", 2)]
        public string PhoneNumber { get; set; }
        public string Note { get; set; }

        public bool Contains(string searchText)
        {
            var lowerText = searchText.ToLower(); // or ToUpper()

            return (Name != null && Name.ToLower().Contains(lowerText)) ||
                    (Address != null && Address.ToLower().Contains(lowerText)) ||
                    (PhoneNumber != null && PhoneNumber.ToLower().Contains(lowerText)) ||
                    (Note != null && Note.ToLower().Contains(lowerText));
        }


    }
}
