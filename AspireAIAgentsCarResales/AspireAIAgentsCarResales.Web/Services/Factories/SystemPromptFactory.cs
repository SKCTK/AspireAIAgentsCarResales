using AspireAIAgentsCarResales.Web.Services.Models;
using static AspireAIAgentsCarResales.Web.Services.StructuredFormats.ChatResponseFormatBuilder;

namespace AspireAIAgentsCarResales.Web.Services.Factories
{
    internal static class SystemPromptFactory
    {
        public static string GetAgentName(AgentType agentType)
        {

            string name = string.Empty;
            switch (agentType)
            {
                case AgentType.RegionalDemand:
                    name = "RegionalDemand";
                    break;
                case AgentType.EconomicImpact:
                    name = "EconomicImpact";
                    break;
                case AgentType.CompetitiveMarket:
                    name = "CompetitiveMarket";
                    break;
                case AgentType.FinalReview:
                    name = "FinalReview";
                    break;
                case AgentType.SelectionStrategy:
                    name = "SelectionStrategy";
                    break;
                case AgentType.TerminationStrategy:
                    name = "TerminationStrategy";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(agentType), agentType, null);
            }



            return name;//.ToUpper();
        }


        public static string GetAgentPrompts(AgentType agentType)
        {

            string promptFile = string.Empty;
            switch (agentType)
            {
                case AgentType.RegionalDemand:
                    promptFile = "RegionalDemand.prompty";
                    break;
                case AgentType.EconomicImpact:
                    promptFile = "EconomicImpact.prompty";
                    break;
                case AgentType.CompetitiveMarket:
                    promptFile = "CompetitiveMarket.prompty";
                    break;
                case AgentType.FinalReview:
                    promptFile = "FinalReview.prompty";
                    break;
                case AgentType.SelectionStrategy:
                    promptFile = "SelectionStrategy.prompty";
                    break;
                case AgentType.TerminationStrategy:
                    promptFile = "TerminationStrategy.prompty";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(agentType), agentType, null);
            }

            string prompt = $"{File.ReadAllText("Prompts/" + promptFile)}";

            return prompt;
        }

        public static string GetStrategyPrompts(ChatResponseStrategy strategyType)
        {
            string prompt = string.Empty;
            switch (strategyType)
            {
                case ChatResponseStrategy.Continuation:
                    prompt = File.ReadAllText("Prompts/SelectionStrategy.prompty");
                    break;
                case ChatResponseStrategy.Termination:
                    prompt = File.ReadAllText("Prompts/TerminationStrategy.prompty");
                    break;

            }
            return prompt;
        }
        public static string CreateSystemPrompt(string systemPrompt)
        {
            return systemPrompt;
        }
        public static string CreateSystemPrompt(string systemPrompt, string additionalInfo)
        {
            return $"{systemPrompt} {additionalInfo}";
        }
        public static string CreateSystemPrompt(string systemPrompt, string additionalInfo, string context)
        {
            return $"{systemPrompt} {additionalInfo} {context}";
        }
    }
}
