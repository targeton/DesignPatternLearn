using System.Collections;

namespace FlyweightDesignPattern
{
    public class WebSiteFactory
    {
        private Hashtable _flyweights = new Hashtable();

        public WebSite GetWebSiteCategory(string key)
        {
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights.Add(key,new ConcreteWebSite(key));
            }
            return (WebSite)_flyweights[key];
        }

        public int GetWebSiteCount()
        {
            return _flyweights.Count;
        }
    }
}