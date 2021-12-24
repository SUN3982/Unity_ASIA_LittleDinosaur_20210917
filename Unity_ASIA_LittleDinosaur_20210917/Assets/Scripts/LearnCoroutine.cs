using System.Collections;    //引用 系統.集合  包含協同程序
using System.Collections.Generic;
using UnityEngine;

public class LearnCoroutine : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Test());
        StartCoroutine(TestWithLoop());
    }


    private IEnumerator Test()
    {
        print("這是第一段文字");       
        yield return new WaitForSeconds(1);
        print("這是第二段文字");
        yield return new WaitForSeconds(3);
        print("哈哈是我啦");
    }

    private IEnumerator TestWithLoop()
    {
        for (int i = 0; i < 15; i++)
        {
            print("數字：" + i);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
