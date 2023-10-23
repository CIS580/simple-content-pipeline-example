using Microsoft.Xna.Framework.Content.Pipeline;
using System.Collections.Immutable;
using TImport = PipelineExtension.ConversationContent;

namespace PipelineExtension
{
    [ContentImporter(".txt", DisplayName = "Dialog Importer", DefaultProcessor = "DialogProcessor")]
    public class DialogImporter : ContentImporter<TImport>
    {
        public override TImport Import(string filename, ContentImporterContext context)
        {
            ConversationContent convo = new();

            string data = System.IO.File.ReadAllText(filename);
            string[] lines = data.Split('\n');

            convo.Lines = new DialogLineContent[lines.Length];

            for(int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                DialogLineContent dl = new();
                dl.Speaker = parts[0].Trim();
                dl.Text = parts[1].Trim();
                convo.Lines[i] = dl;
            }

            return convo;
        }
    }
}