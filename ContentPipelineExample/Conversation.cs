using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentPipelineExample
{
    public class Conversation
    {
        public Line[] Lines;
    }

    public class Line
    {
        public string Speaker;
        public string Text;
    }
}
