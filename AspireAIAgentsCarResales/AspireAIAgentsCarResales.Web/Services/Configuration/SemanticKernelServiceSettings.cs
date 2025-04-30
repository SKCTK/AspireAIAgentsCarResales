using Aspire.Azure.AI.OpenAI;

namespace AspireAIAgentsCarResales.Web.Services.Configuration
{
    public record SemanticKernelServiceSettings
    {
        public required AzureOpenAISettings AzureOpenAISettings { get; init; }
        public required CosmosDBSettings CosmosDBVectorStoreSettings { get; init; }
    }
}
