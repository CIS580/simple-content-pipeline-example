using Microsoft.Xna.Framework.Content.Pipeline;

using TInput = PipelineExtension.ConversationContent;
using TOutput = PipelineExtension.ConversationContent;

namespace PipelineExtension
{
    [ContentProcessor(DisplayName = "Dialog Processor")]
    internal class DialogProcessor : ContentProcessor<TInput, TOutput>
    {
        public override TOutput Process(TInput input, ContentProcessorContext context)
        {
            return input;
        }
    }
}