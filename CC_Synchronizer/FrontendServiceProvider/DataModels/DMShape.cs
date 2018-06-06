using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontendServiceProvider.DataModels
{
    class DMShape
    {
        // only Oracle Backend values. table name = SHAPE
        // how many values do we need?
        public Guid ShapeID { get; set; }
        public string ShapeName { get; set; }

        // add constructor
    }
}
