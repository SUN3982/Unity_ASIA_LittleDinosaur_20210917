using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 學習靜態方法
/// </summary>
public class LearnMethodStatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //靜態方法
        //呼叫方法
        //語法：類別名稱.靜態方法名稱(對應的引數);
        int rInt = Random.Range(1, 3);
        print("隨機整數 1 與 3 ：" + rInt);
        print("-99的絕對值：" + Mathf.Abs(-99));
    }
}

