using Dolittle.Events.Processing;
{{#if readModels}}
using Dolittle.ReadModels;
{{/if}}

namespace {{namespace}}
{
    public class {{name}} : ICanProcessEvents
    {
        {{#if readModels}}
        {{#each readModels}}
        readonly IReadModelRepositoryFor<{{this}}> _repositoryFor{{this}};
        {{/each}}

        public {{name}}(
            {{#each readModels}}{{#if @first}}IReadModelRepositoryFor<{{this}}> repositoryFor{{this}},{{/if}}            {{#if @last}}IReadModelRepositoryFor<{{this}}> repositoryFor{{this}}{{/if}}
            {{/each}}
        )
        {
            {{#each readModels}}
            _repositoryFor{{this}} = repositoryFor{{this}};
            {{/each}}
        }
        {{/if}}
        
        {{#each events}}
        [EventProcessor("{{createGuid}}")]
        public void Process({{this}} @event)
        {

        }
        
        {{/each}}
    }
}
