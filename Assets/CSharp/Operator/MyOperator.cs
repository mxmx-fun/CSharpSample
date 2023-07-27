using UnityEngine;

//主题：运算符重载
//实现的效果：A类可以+ - * /
//语法：public static SourceType operator sign(SourceType lhs,SourceType rhs) {}       --SourceType：源文件类型 sign：运算符号
public class MyOperator : MonoBehaviour
{
    public class A
    {

        public int score;

        public A(int score)
        {
            this.score = score;
        }
        public static A operator +(A a, A b)
        {
            return new A(a.score + b.score);
        }

        public static A operator -(A a, A b)
        {
            return new A(a.score - b.score);
        }

        public static A operator *(A a,A b) {
            return new A(a.score * b.score);
        }

        public static A operator /(A a,A b) {
            return new A(a.score / b.score);
        }
    }

    public void Awake() {
        A a = new A(5);
        A b = new A(10);
        A c = a + b;
        A d = a - b;
        A e = a * b;
        A f = a / b;
        Debug.Log(c.score);
        Debug.Log(d.score);
        Debug.Log(e.score);
        Debug.Log(f.score);
        //打印结果：
        //15
        //-5
        //50
        //0
    }

}
