
using UnityEngine;

/// <summary>
/// 學習迴圈
/// 1.while *
/// 2.do while
/// 3.for *
/// 4.foreach
/// </summary>

public class LearnLoop : MonoBehaviour
{
    private void Start()
    {
        //迴圈作用：
        //重複執行相同程式並且可以指定次數

        #region while 迴圈
        //語法：
        //while (布林值) { 程式內容 }
        //特性：當布林值為 true 會持續執行 {} 直到布林值為 false
        int i = 1;
        while (i < 11)
        {
            print("while 迴圈：" + i);
            i++;
        }
        #endregion

        #region for 迴圈
        //語法：
        //for (初始值;布林值;迴圈結束後要執行的程式;) { 程式內容 }
        for (int j = 1; j < 11; j++)
        {
            print("for迴圈：" + j);
        }
        #endregion
    }
}