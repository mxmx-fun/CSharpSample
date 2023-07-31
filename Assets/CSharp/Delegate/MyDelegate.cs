using System;
using UnityEngine;

//主题：委托
//实现的效果：三种语法实现委托
//语法：public 返回值类型 delegate 命名();  -- delegate （Func和Action是基于此类型封装的）
//      public Action<参数> 命名;   -- Action
//      public Func<参数...最后一个参数为返回值类型> 命名      --Func

public class MyDelegate : MonoBehaviour
{
    public delegate void DebugDelegate();
    public DebugDelegate myDelegate;
    public Action myAction;
    public Func<string,int> myFunc;
    // Start is called before the first frame update
    
    public void Start() {
        myDelegate?.Invoke();
        myAction?.Invoke();
        Debug.Log(myFunc?.Invoke("mx"));
    }
    
    void OnEnable()
    {
        myDelegate += MyDebug;
        myAction += MyDebug;
        myFunc += MyFuncDebug;
    }

    void OnDisable()
    {
        myDelegate -= MyDebug;
        myAction -= MyDebug;
        myFunc -= MyFuncDebug;
    }

    public void MyDebug()
    {
        Debug.Log("MyDebug");
    }

    public int MyFuncDebug(string name)
    {
        if (name == "mx")
        {           
            return 0;
        }
        return 1;
    }
}
