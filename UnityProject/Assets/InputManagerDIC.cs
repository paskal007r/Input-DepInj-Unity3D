using UnityEngine;

public class InputManagerDIC : MonoBehaviour
{
    [SerializeField]
    UserExample target;
    public void LoadInputManager()
    {
        InputManager.XbuttonPress = target.LogCallX;
        InputManager.YbuttonPress = target.LogCallY;
        InputManager.AbuttonPress = target.LogCallA;
        InputManager.BbuttonPress = target.LogCallB;
        InputManager.XbuttonPressContinuous = target.LogCallXCont;
        InputManager.YbuttonPressContinuous = target.LogCallYCont;
        InputManager.AbuttonPressContinuous = target.LogCallACont;
        InputManager.BbuttonPressContinuous = target.LogCallBCont;
        InputManager.leftStickEffect = target.LogCallL;
        InputManager.rightStickEffect = target.LogCallR;
        InputManager.leftTriggerPressContinuous = target.LogCallTLCont;
        InputManager.rightTriggerPressContinuous = target.LogCallTRCont;
        InputManager.InputStartRead = target.ResetUI;

    }
}
