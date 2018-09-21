using Dolittle.Events.Processing;
{{#each imports}}
using {{namespace}};
{{/each}}

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
