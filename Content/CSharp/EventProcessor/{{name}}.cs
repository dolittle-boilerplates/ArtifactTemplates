using Dolittle.Events.Processing;

namespace {{namespace}}
{
    public class {{name}} : ICanProcessEvents
    {
        {{#each events}}
        [EventProcessor("{{eventProcessor}}")]
        void Process({{eventName}} @event)
        {

        }
        {{/each}}
        
    }
}
