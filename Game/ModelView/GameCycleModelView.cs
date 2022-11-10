using System;
using Addons;
using Model;

namespace ModelView
{
    public sealed class GameCycleModelView : ModelView
    {
        public GameCycle GameCycle { get; }
        
        
        public GameCycleModelView()
        {
            Logger.Debug("Stat of game cycle");
            GameCycle = new GameCycle();
            
            CreateScene();
            MainModelView.SceneModelView.Scene.DisplayScene();
        }
        
        
        private void Update()
        {
            while (GameCycle.Update)
            {
            }
        }
        
        private void CreateScene()
        {
            MainModelView.SceneModelView.SetScene(Scene.GetTestScene());
        }
    }
}