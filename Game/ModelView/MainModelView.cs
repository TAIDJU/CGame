namespace ModelView
{
    public sealed class MainModelView
    {
        public static GameCycleModelView GameCycleModelView { get; private set; }


        public MainModelView()
        {
            GameCycleModelView = new GameCycleModelView();
        }
    }
}