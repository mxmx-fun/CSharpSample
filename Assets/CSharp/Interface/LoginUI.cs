using UnityEngine;

public class LoginUI : IUIForm
{
    int IUIForm.ID => 1000;

    int IUIForm.Layer => 2;

    int IUIForm.Order => 0;

    void IUIForm.CloseUI()
    {
        Debug.Log("LoginUI CloseUI");
    }

    void IUIForm.OpenUI()
    {
        Debug.Log("LoginUI OpenUI");
    }
}