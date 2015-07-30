using MvcSiteMapProvider;
using SpodIglyMVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpodIglyMVC.Infrastructure
{
    public class ProductDetalisDynamicNodeProvider : DynamicNodeProviderBase
    {
        private StoreContext db = new StoreContext();
        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            var reurnValue = new List<DynamicNode>();
            foreach (var a in db.Albums)
            {
                DynamicNode n = new DynamicNode();
                n.Title = a.AlbumTitle;
                n.Key = "Album_" + a.AlbumID;
                n.ParentKey = "Genre_" + a.GenreID;
                n.RouteValues.Add("id", a.AlbumID);
                reurnValue.Add(n);
            }
            return reurnValue;
        }
    }
}
