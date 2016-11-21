using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    string XbuttonName = "Fire1";
    [SerializeField]
    string YbuttonName = "Fire2";
    [SerializeField]
    string AbuttonName = "Fire3";
    [SerializeField]
    string BbuttonName = "Jump";
    [SerializeField]
    string LeftStickHorizontalName = "Horizontal";
    [SerializeField]
    string LeftStickVerticalName = "Vertical";
    [SerializeField]
    string RightStickHorizontalName = "rightStickHorizontal";
    [SerializeField]
    string RightStickVerticalName = "rightStickVertical";
    [SerializeField]
    string leftTriggerName = "leftTrigger";
    [SerializeField]
    string rightTriggerName = "rightTrigger";


    public static InputManager instance;
    [SerializeField]
    InputManagerDIC inputDIC;
    [SerializeField]
    float triggerSensibility = 0.2f;
    // Use this for initialization
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
        inputDIC.LoadInputManager();
    }

    public static buttonReaction XbuttonPress = delegate () { };
    public static buttonReaction YbuttonPress = delegate () { };
    public static buttonReaction AbuttonPress = delegate () { };
    public static buttonReaction BbuttonPress = delegate () { };
    public static buttonReaction XbuttonPressContinuous = delegate () { };
    public static buttonReaction YbuttonPressContinuous = delegate () { };
    public static buttonReaction AbuttonPressContinuous = delegate () { };
    public static buttonReaction BbuttonPressContinuous = delegate () { };
    public static axisEffect leftStickEffect = delegate (Vector2 a) { };
    public static axisEffect rightStickEffect = delegate (Vector2 a) { };
    public static buttonReaction leftTriggerPressContinuous = delegate () { };
    public static buttonReaction rightTriggerPressContinuous = delegate () { };
    public static System.Action InputStartRead = delegate () { };


    void Update()
    {
        InputStartRead();
        if (Input.GetButtonDown(XbuttonName))
        { XbuttonPress(); }
        if (Input.GetButtonDown(YbuttonName))
        { YbuttonPress(); }
        if (Input.GetButtonDown(AbuttonName))
        { AbuttonPress(); }
        if (Input.GetButtonDown(BbuttonName))
        { BbuttonPress(); }
        if (Input.GetButton(XbuttonName))
        { XbuttonPressContinuous(); }
        if (Input.GetButton(YbuttonName))
        { YbuttonPressContinuous(); }
        if (Input.GetButton(AbuttonName))
        { AbuttonPressContinuous(); }
        if (Input.GetButton(BbuttonName))
        { BbuttonPressContinuous(); }
        if (Input.GetAxis(leftTriggerName) > triggerSensibility)
        { leftTriggerPressContinuous(); }
        if (Input.GetAxis(rightTriggerName) > triggerSensibility)
        { rightTriggerPressContinuous(); }

        leftStickEffect(new Vector2(Input.GetAxis(LeftStickHorizontalName), Input.GetAxis(LeftStickVerticalName)));

        rightStickEffect(new Vector2(Input.GetAxis(RightStickHorizontalName), Input.GetAxis(RightStickVerticalName)));


    }
}
public delegate void buttonReaction();
public delegate void axisEffect(Vector2 axisVal);
