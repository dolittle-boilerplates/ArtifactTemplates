using Dolittle.Commands.Handling;

namespace {{namespace}}
{
    public class {{name}} : ICanHandleCommands
    {
        {{#each commands}}
        public void Handle({{this}} cmd)
        {

        }
        
        {{/each}}
    }
}
