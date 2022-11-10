namespace ModelView
{
    public sealed class MainModelView
    {
        public static SceneModelView SceneModelView { get; private set; }
        public static GameCycleModelView GameCycleModelView { get; private set; }


        public MainModelView()
        {
            SceneModelView = new SceneModelView();
            GameCycleModelView = new GameCycleModelView();
        }
    }
    
    public abstract class ModelView
    {
        
    }
}
