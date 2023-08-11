using System;
using UnityEngine;


//主题：事件
//实现的效果：事件的使用
//定义：事件是一种特殊的委托，它只能在类的内部被触发
//语法：事件的语法和委托的语法很像，只是委托前面加了一个event关键字
// event delegate-type event-name;
public class MyEvent : MonoBehaviour
{

    public delegate void Act();
    public event Act Eat;

    public void EatApple()
    {
        Debug.Log("Eat Apple");
    }

    public void Start()
    {
        Eat?.Invoke();
    }

    public void OnEnable()
    {
        Eat += EatApple;
    }

    public void OnDisable()
    {
        Eat -= EatApple;
    }
}