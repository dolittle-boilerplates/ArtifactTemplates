using Dolittle.Commands.Handling;
{{#if aggregateRoots}}
using Dolittle.Domain;
{{/if}}
namespace {{namespace}}
{
    public class {{name}} : ICanHandleCommands
    {
        {{#if aggregateRoots}}
        {{#each aggregateRoots}}
        readonly IAggregateRootRepositoryFor<{{this}}>  _aggregateRootRepoFor{{this}};
        {{/each}}

        public {{name}}(
            {{#each aggregateRoots}}{{#if @first}}IAggregateRootRepositoryFor<{{this}}>  aggregateRootRepoFor{{this}}{{#unless @last}},{{/unless}}{{/if}}            {{#if @last}}{{#unless @first}}IAggregateRootRepositoryFor<{{this}}>  aggregateRootRepoFor{{this}}{{/unless}}{{/if}}
            {{/each}}
        )
        {
            {{#each aggregateRoots}}
             _aggregateRootRepoFor{{this}} =  aggregateRootRepoFor{{this}};
            {{/each}}
        }
        {{/if}}

        {{#each commands}}
        public void Handle({{this}} cmd)
        {

        }
        
        {{/each}}
    }
}
