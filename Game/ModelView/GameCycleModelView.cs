using Model;

namespace ViewModel;

public class GameCycleModelView : ModelView
{
    public GameCycle GameCycle { get; }

    public GameCycleModelView()
    {
        GameCycle = new GameCycle();
    }
}
