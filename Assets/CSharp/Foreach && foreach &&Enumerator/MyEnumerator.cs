using System.Collections.Generic;
using UnityEngine;

//主题：枚举器
//实现的效果：用Foreach/foreach/Enumerator实现枚举器的效果
//语法：1.集合实例.ForEach(()=>{}) 
//       2.foreach(var item in 集合实例) {} 是枚举器的语法糖
//       3.var temple = 集合实例.GetEnumerator() 
//         while(temple.MoveNext()) {}

public class MyEnumerator:MonoBehaviour {

    List<int> myList = new List<int>() { 1, 2, 3, 4, 5 };
    void Awake() {
        //Foreach
        myList.ForEach((item) => {
            Debug.Log(item);
        });
        //foreach
        foreach (var item in myList) {
            Debug.Log(item);
        }
        //Enumerator
        var temple = myList.GetEnumerator();
        while (temple.MoveNext()) {
            Debug.Log(temple.Current);
        }
    }
}