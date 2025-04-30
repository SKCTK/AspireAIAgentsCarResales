The Aspire Framework AI Multiagent Application called AspireAIAgentsCarResales is an advanced, AI-powered resale analysis platform designed to optimize vehicle resale forecasting using Azure OpenAI multiagents. This system integrates real-time car advert sales data from the UK market and regional resale insights from the Office for National Statistics (ONS) to provide comprehensive resale trend analysis and decision-making support.
To run the application you need to add your openai connection string with endpoint and key in the JSON file there like so
{
  "openai": {
    "Endpoint": "https://your-openai-instance.openai.azure.com/",
    "ApiKey": "your-api-key",
  }
}