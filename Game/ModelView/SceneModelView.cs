using Model;

namespace ModelView
{
    public sealed class SceneModelView : ModelView
    {
        public Scene Scene { get; private set; }


        public void SetScene(Scene scene)
        {
            Scene = scene;
        }
    }
}