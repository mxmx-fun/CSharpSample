using UnityEngine;

public class InterfaceSample : MonoBehaviour
{
    public void Awake() {
        IUIForm loginUI = new LoginUI();
        IUIForm registerUI = new RegisterUI();
        loginUI.OpenUI();
        registerUI.OpenUI();
    }
}