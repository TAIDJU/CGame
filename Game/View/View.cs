using ViewModel;

namespace View;

public class View
{
    public GameCycleModelView GameCycleModelView { get; set; }


    public View()
    {
        GameCycleModelView = new GameCycleModelView();
    }
}
