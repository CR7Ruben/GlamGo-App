using CommunityToolkit.Mvvm.Input;
using GlamGoApp.Models;

namespace GlamGoApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}