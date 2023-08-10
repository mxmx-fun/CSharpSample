using System;
using UnityEngine;

//主题：索引器
//实现的效果：索引器的使用
//定义：索引器是一个特殊的属性，它允许类或结构的实例像数组一样通过索引来访问
//语法：索引器的语法和属性的语法很像，只是在get和set后面加了一个中括号，中括号里面是索引的类型
// element-type this[int index]
// {
//    // get 访问器
//    get
//    {
//       // 返回 index 指定的值
//    }

//    // set 访问器
//    set
//    {
//       // 设置 index 指定的值
//    }
// }

public class MyIndexer:MonoBehaviour {

    public struct TestStruct {
        public int[] array;

        public int this[int index] {
            get {
                return array[index];
            }
            set {
                array[index] = value;
            }
        }
    }

    public void Awake() {
        TestStruct test = new TestStruct();
        test.array = new int[10];
        for (int i = 0; i < 10; i++) {
            test[i] = i;
        }

        foreach(var value in test.array) {
            UnityEngine.Debug.Log(value);
        }        

    }
}