using System;
using System.Linq;
using Dolittle.Queries;

namespace {{namespace}}
{
    public class {{name}} : IQueryFor<{{readModel}}>
    {

        public IQueryable<{{readModel}}> Query
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
