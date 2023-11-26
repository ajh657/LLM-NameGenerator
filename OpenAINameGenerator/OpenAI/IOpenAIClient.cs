using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenAINameGenerator.OpenAI
{
    public interface IOpenAIClient
    {
        bool Authenticate(string newAPIKey);
        void Dispose();
        Task<IEnumerable<string>> GenerateNames(string input);
        bool IsAuthenticated();
        bool IsKeyLoadedExternaly();
    }
}
