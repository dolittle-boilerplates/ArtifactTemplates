using System;
using System.Linq;
using Dolittle.Queries;
using Dolittle.ReadModels;

namespace {{namespace}}
{
    public class {{name}} : IQueryFor<{{readModel}}>
    {
        readonly IReadModelRepositoryFor<{{readModel}}> _repositoryFor{{readModel}};

        public {{name}}(IReadModelRepositoryFor<{{readModel}}> repositoryFor{{readModel}})
        {
            _repositoryFor{{readModel}} = repositoryFor{{readModel}};
        }

        public IQueryable<{{readModel}}> Query => _repositoryFor{{readModel}}.Query;
    }
}
