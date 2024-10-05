using lnn_ui.Models;
using lnn_ui.Services;
using Microsoft.AspNetCore.Components;

namespace lnn_ui.Components.Pages;

partial class Graphs
{
    [Inject] private HistoryService _historyService { get; set; }
    private int _count;
    private bool _dataButtonClicked = false;
    private List<LnnOutput> _data = [];

    private async void GetData()
    {
        _data = await _historyService.GetHistory(_count);
        _dataButtonClicked = true;
        StateHasChanged();
    }
}