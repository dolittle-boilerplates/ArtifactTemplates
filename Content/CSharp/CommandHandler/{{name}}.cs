using Dolittle.Commands.Handling;
{{#each imports}}
using {{namespace}};
{{/each}}

namespace {{namespace}}
{
    public class {{name}} : ICanHandleCommands
    {
        {{#each commands}}
        void Handle({{commandName}} cmd)
        {

        }
        {{/each}}
    }
}
