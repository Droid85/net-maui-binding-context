namespace lab9;

public partial class PageB : ContentPage
{
    public bool Value { get; set; } = true;

    public PageB()
    {
        InitializeComponent();
        BindingContext = this;
    }

}