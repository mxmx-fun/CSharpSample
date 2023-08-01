using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//主题：位运算
//实现的效果：两个short类型值，组合成一个int值
//语法：value << 左移N位    value >> 右移N位    value1 | value2(有1为1)  value1 & value2（同1才1，异为0，同0为0）
 

public class MyBitOperation : MonoBehaviour
{   

    void Start()
    {
        ushort a = 1;
        ushort b = 2;
        uint c = (uint)a << 16 | b;
        Debug.Log(c);    
    }

}
