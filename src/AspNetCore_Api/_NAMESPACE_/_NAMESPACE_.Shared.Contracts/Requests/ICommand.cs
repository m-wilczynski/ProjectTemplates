namespace _NAMESPACE_.Shared.Contracts.Requests
{
    /// <summary>
    /// Modify information in system
    /// </summary>
    public interface ICommand : IRequest
    {
        /// <summary>
        /// User that modifies system
        /// </summary>
        User User { get; }
    }
}
