namespace BettingEngine.Betting
{
    /// <summary>
    /// Represents the outcome of a <see cref="IWager{TResults}"/> made at a <see cref="IBet{TResults}"/>.
    /// </summary>
    public interface IOutcome
    {
        /// <summary>
        /// The type of outcome.
        /// </summary>
        OutcomeType Type { get; }

        /// <summary>
        /// The amount of winnings for an outcome with its <see cref="Type"/>
        /// being equal to <see cref="OutcomeType.Win"/>
        /// </summary>
        decimal Winnings { get; }
    }
}