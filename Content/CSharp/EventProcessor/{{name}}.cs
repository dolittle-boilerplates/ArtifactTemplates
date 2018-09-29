using Dolittle.Events.Processing;

namespace {{namespace}}
{
    public class {{name}} : ICanProcessEvents
    {
        {{#each events}}
        [EventProcessor(INSERT_GUID)]
        public void Process({{this}} @event)
        {

        }
        
        {{/each}}
    }
}
