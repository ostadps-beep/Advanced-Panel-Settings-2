// ChartSettingsViewModel.cs

public class ChartSettingsViewModel : INotifyPropertyChanged
{
    public ChartSettingsRoot Settings { get; set; } = new();

    // لیست‌ها برای ComboBox ها
    public IList<string> ChartTypes { get; } = new[] { "Candlestick", "Line", "Histogram", "Combined" };
    public IList<string> ZoomBehaviors { get; } = new[] { "Time Axis", "Price Axis", "Both" };
    public IList<string> PriceAxisPositions { get; } = new[] { "Left", "Right" };

    // Commands
    public ICommand ApplyCommand { get; }
    public ICommand OkCommand { get; }
    public ICommand CancelCommand { get; }
    public ICommand ResetCommand { get; }

    public ChartSettingsViewModel()
    {
        ApplyCommand = new RelayCommand(Apply);
        OkCommand = new RelayCommand(Ok);
        CancelCommand = new RelayCommand(Cancel);
        ResetCommand = new RelayCommand(Reset);
    }

    private void Apply()
    {
        // اینجا منطق OnApply را اجرا می‌کنی:
        // ارسال تنظیمات سنگین (Performance, Chart.VisibleCandles, EngineMode...) به موتور
    }

    private void Ok()
    {
        // ذخیره Settings به JSON + بستن پنل
    }

    private void Cancel()
    {
        // بستن بدون ذخیره
    }

    private void Reset()
    {
        // برگرداندن Settings به مقادیر پیش‌فرض
        Settings = new ChartSettingsRoot();
        OnPropertyChanged(nameof(Settings));
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string name)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}