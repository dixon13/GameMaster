namespace GameMaster.Commands
{
    using Boilerplate.AspNetCore;
    using GameMaster.ViewModels;

    public interface IPutCarCommand : IAsyncCommand<int, SaveCar>
    {
    }
}
