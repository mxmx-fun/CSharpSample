using System;
using System.Collections.Generic;
using UnityEngine;

//主题：闭包
//实现的效果：闭包导致的值变更以及修复方法
//定义：闭包的语法就是一个匿名函数，匿名函数里面引用了外部变量，就是闭包
public class MyClosure : MonoBehaviour
{

    void Awake()
    {
        List<Action> actions = new List<Action>();
        for (int i = 0; i < 10; i++)
        {
            Action lambda = () =>
            {
                Debug.Log(i);
            };
            actions.Add(lambda);
        }

        foreach (var action in actions)
        {
            action.Invoke();
        }

        //下面的代码就等同于上面的代码 
        // for (int i = 0; i < 10; i++)
        // {
        //     actions.Add(lambda);
        // }

        // public static void lambda()
        // {
        //     Debug.Log(&i);
        // }
        //所以打印出来会全部为10

        actions.Clear();

        //解决方法：在for循环里面定义一个局部变量
        for (int i = 0; i < 10; i++)
        {
            int temp = i;
            Action lambda = () =>
            {
                Debug.Log(temp);
            };
            actions.Add(lambda);
        }

        foreach (var action in actions)
        {
            action.Invoke();
        }

        //下面的代码就等同于上面的代码 
        // for (int i = 0; i < 10; i++)
        // {
        //        int v = i;  //这里的v就是一个局部变量，每次循环都会重新定义,开辟新的空间
        //     actions.Add(lambda);
        // }

        // public static void lambda()
        // {
        //     Debug.Log(&v);
        // }
        //所以打印出来会全部为10
    }
}
