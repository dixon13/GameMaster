namespace GameMaster.Commands
{
    using Boilerplate.AspNetCore;
    using GameMaster.ViewModels;

    public interface IGetCarPageCommand : IAsyncCommand<PageOptions>
    {
    }
}
