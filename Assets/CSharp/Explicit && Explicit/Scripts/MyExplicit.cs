using UnityEngine;

//主题：显示转换Explicit
//实现的效果：A类型显示转换到B，数据进行转换赋值
//语法：public static explicit TargetType(SourceType source) {}       --TargetType:目标类型（强转类型） SourceType：源文件类型（被转换类型）
public class MyExplicit : MonoBehaviour
{

    public class A {
        public int data;

        public A(int data) {
            this.data = data;
        }

        public static explicit operator B(A a) {
            return new B(a.data*10);
        }
    }

    public class B {
        public int data;

        public B(int data) {
            this.data = data;
        }
    }

    public void Awake() {
        A a = new A(5);
        B b = (B)a;
        Debug.Log(a.data);
        Debug.Log(b.data);
        //打印结果：
        //5
        //50
    }
}
