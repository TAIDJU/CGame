using Addons;

namespace Model;

public class GameCycle : Model
{
    private bool _breakFlag = true;


    public GameCycle()
    {
        Debug.Log("Starting game cycle loop");
        
        while (_breakFlag)
        {
            Debug.Log("Loop");
        }
    }


    public void Break()
    {
        _breakFlag = false;
    }
}
