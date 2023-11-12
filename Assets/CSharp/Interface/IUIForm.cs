public interface IUIForm {
    int ID{get;}
    int Layer{get;}
    int Order{get;}

    void OpenUI();
    void CloseUI();
}