
namespace Microsoft.BotBuilderSamples
{
    /// <summary>
    /// Stores Salutation state for the conversation. (whether the bot has greeted the user or not)
    public class SalutationState
    {
        /// <summary>
        /// Gets or sets whether the user has been welcomed in the conversation.
        /// </summary>
        /// <value>The user has been welcomed in the conversation.</value>
        public bool DidBotGreetUser { get; set; } = false;
    }
}