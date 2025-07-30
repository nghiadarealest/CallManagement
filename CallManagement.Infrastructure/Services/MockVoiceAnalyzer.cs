using System.IO;
using System.Threading.Tasks;

namespace CallManagement.Infrastructure.Services
{
    public class MockVoiceAnalyzer : IVoiceAnalyzer
    {
        public Task<(string Text, string Summary)> AnalyzeAsync(Stream audioStream)
        {
            return Task.FromResult((
                "Giọng nói giả định",
                "Tóm tắt giả định"
            ));
        }
    }
}
