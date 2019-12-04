namespace AwsCodeGuru.Commands
{
    using AwsCodeGuru.ViewModels;
    using Boxed.AspNetCore;

    public interface IGetCarPageCommand : IAsyncCommand<PageOptions>
    {
    }
}
