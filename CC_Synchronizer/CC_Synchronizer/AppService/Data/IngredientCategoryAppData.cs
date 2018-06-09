using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Synchronizer.AppService.Data
{
    public class IngredientCategoryAppData
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int BackendID { get; set; }
        public int FrontendID { get; set; }
    }
}
