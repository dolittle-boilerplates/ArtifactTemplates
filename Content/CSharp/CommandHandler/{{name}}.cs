using Dolittle.Commands.Handling;

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
