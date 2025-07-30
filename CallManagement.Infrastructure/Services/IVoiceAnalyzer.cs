using System.IO;
using System.Threading.Tasks;

namespace CallManagement.Infrastructure.Services
{
    public interface IVoiceAnalyzer
    {
        Task<(string Text, string Summary)> AnalyzeAsync(Stream audioStream);
    }
}
