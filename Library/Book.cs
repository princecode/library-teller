using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book : Media
    {

        public override string Title { get; set; }
        public override string Length { get; set; }
        public override int RentalLength { get; set; }
        protected DateTime RentedDate { get; set; }


    }
}
