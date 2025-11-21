namespace lab9;

public partial class PageA : ContentPage
{
    public string OneWayText { get; set; } = "OneWay initial";
    public string TwoWayText { get; set; } = "TwoWay initial";
    public string OneTimeText { get; set; } = "OneTime initial";

    public PageA()
    {
        InitializeComponent();
        BindingContext = this;
    }

}