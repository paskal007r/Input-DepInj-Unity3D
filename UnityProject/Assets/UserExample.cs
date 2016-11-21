using UnityEngine;
using UnityEngine.UI;

public class UserExample : MonoBehaviour
{
    [SerializeField]
    Toggle xButton;
    [SerializeField]
    Toggle yButton;
    [SerializeField]
    Toggle aButton;
    [SerializeField]
    Toggle bButton;
    [SerializeField]
    Toggle lTriggerButton;
    [SerializeField]
    Toggle rTriggerButton;
    [SerializeField]
    Text rStick;
    [SerializeField]
    Text lStick;



    public void LogCallTLCont() { ShowLogButton(lTriggerButton, "TL Cont"); }
    public void LogCallTRCont() { ShowLogButton(rTriggerButton, "TR Cont"); }
    public void LogCallA() { ShowLogButton(aButton, "A "); }
    public void LogCallB() { ShowLogButton(bButton, "B "); }
    public void LogCallX() { ShowLogButton(xButton, "X "); }
    public void LogCallY() { ShowLogButton(yButton, "Y "); }
    public void LogCallACont() { ShowLogButton(aButton, "A Cont"); }
    public void LogCallBCont() { ShowLogButton(bButton, "B Cont"); }
    public void LogCallXCont() { ShowLogButton(xButton, "X Cont"); }
    public void LogCallYCont() { ShowLogButton(yButton, "Y Cont"); }
    public void LogCallL(Vector2 direction) { ShowLogAxis(lStick, "L stick with dir", direction); }
    public void LogCallR(Vector2 direction) { ShowLogAxis(rStick, "R stick with dir", direction); }

    void ShowLogButton(Toggle toggle, string text)
    {
        toggle.isOn = true;
        Debug.Log(text);
    }
    void ShowLogAxis(Text field, string text, Vector2 direction)
    {
        field.text = direction.ToString();
        Debug.Log(text + direction);
    }
    public void ResetUI()
    {
        xButton.isOn = false;
        yButton.isOn = false;
        aButton.isOn = false;
        bButton.isOn = false;
        lTriggerButton.isOn = false;
        rTriggerButton.isOn = false;
        rStick.text = Vector2.zero.ToString();
        lStick.text = Vector2.zero.ToString();
    }
}
