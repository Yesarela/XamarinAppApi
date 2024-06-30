// ViewModels/MainViewModel.cs
public class MainViewModel : INotifyPropertyChanged
{
    private readonly ApiService _apiService;
    private List<Item> _items;

    public List<Item> Items
    {
        get => _items;
        set
        {
            _items = value;
            OnPropertyChanged();
        }
    }

    public MainViewModel()
    {
        _apiService = new ApiService();
        LoadItems();
    }

    private async void LoadItems()
    {
        Items = await _apiService.GetItemsAsync();
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}