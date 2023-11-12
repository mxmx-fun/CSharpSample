using UnityEngine;

public class RegisterUI : IUIForm
{
    int IUIForm.ID => 1100;

    int IUIForm.Layer => 2;

    int IUIForm.Order => 1;

    void IUIForm.CloseUI()
    {
        Debug.Log("RegisterUI CloseUI");
    }

    void IUIForm.OpenUI()
    {
        Debug.Log("RegisterUI OpenUI");
    }
}