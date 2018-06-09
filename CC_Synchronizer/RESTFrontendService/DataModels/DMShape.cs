using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTFrontendService.DataModels
{
    public class DMShape
    {
        // only Oracle Backend values. table name = SHAPE

        public Guid ShapeID { get; set; }
        public string ShapeName { get; set; }

        // constructor
        public DMShape()
        {

        }

        public DMShape(Guid shapeID, string shapeName)
        {
            ShapeID = shapeID;
            ShapeName = shapeName;
        }
    }
}