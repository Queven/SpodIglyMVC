using MvcSiteMapProvider;
using SpodIglyMVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpodIglyMVC.Infrastructure
{
   public class ProductListDynamicNodeProvider : DynamicNodeProviderBase
    {
         
        private StoreContext db = new StoreContext();
        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            var reurnValue = new List<DynamicNode>();
            foreach (var a in db.Genres)
            {
                DynamicNode n = new DynamicNode();
                n.Title = a.Name;
                n.Key = "Genre_" + a.GenreID;
                //n.ParentKey = "Genre_" + a.GenreID;
                n.RouteValues.Add("genrename", a.Name);
                reurnValue.Add(n);
            }
            return reurnValue;
        }
    }
}

