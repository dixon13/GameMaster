namespace GameMaster.Commands
{
    using Boilerplate.AspNetCore;
    using GameMaster.ViewModels;

    public interface IPostCarCommand : IAsyncCommand<SaveCar>
    {
    }
}
