using Dolittle.Commands.Handling;

namespace {{namespace}}
{
    public class {{name}} : ICanHandleCommands
    {
        {{#each commands}}
        void Handle({{this}} cmd)
        {

        }
        
        {{/each}}
    }
}
