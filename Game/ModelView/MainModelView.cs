using Model;

namespace ViewModel;

public sealed class MainModelView
{
    public MainModel MainModel { get; }


    public MainModelView()
    {
        MainModel = new MainModel();
    }
}
