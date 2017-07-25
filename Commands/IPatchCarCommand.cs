namespace GameMaster.Commands
{
    using Boilerplate.AspNetCore;
    using Microsoft.AspNetCore.JsonPatch;
    using GameMaster.ViewModels;

    public interface IPatchCarCommand : IAsyncCommand<int, JsonPatchDocument<SaveCar>>
    {
    }
}
