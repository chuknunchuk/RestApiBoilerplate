namespace AwsCodeGuru.Commands
{
    using AwsCodeGuru.ViewModels;
    using Boxed.AspNetCore;

    public interface IPostCarCommand : IAsyncCommand<SaveCar>
    {
    }
}
