using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineExtension
{
    [ContentSerializerRuntimeType("ContentPipelineExample.Conversation, ContentPipelineExample")]
    public class ConversationContent
    {
        public DialogLineContent[] Lines;
    }
}
