namespace AwsCodeGuru.Commands
{
    using AwsCodeGuru.ViewModels;
    using Boxed.AspNetCore;

    public interface IPutCarCommand : IAsyncCommand<int, SaveCar>
    {
    }
}
