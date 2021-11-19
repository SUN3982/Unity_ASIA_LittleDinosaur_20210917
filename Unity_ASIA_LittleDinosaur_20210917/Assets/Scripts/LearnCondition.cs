
using UnityEngine;

/// <summary>
/// 認識判斷式 (條件式)
/// </summary>
public class LearnCondition : MonoBehaviour
{
    public bool openDoor;
    public int score = 70;
    public string weapon = "刀子";

    // Start is called before the first frame update
    
    //開始事件：播放遊戲時執行一次
    private void Start()
    {
        #region 判斷式 if
        //語法：
        //當布林值為 true ，執行 if 的 {}
        //if (布林值) { 程式內容 }
        if (true) 
        {
            print("認識判斷式if");

        }

        //當布林值為 true ，執行 if 的 {}
        //當布林值為 false ，執行 else 的 {}
        //if (布林值) { 程式內容 }
        //else { 程式內容 }
        if (openDoor)
        {
            print("開門!");
        }
        else
        {
            print("關門!");
        }

        #endregion
    }

    //更新事件：約一秒六十次 (60 FPS)
    private void Update()
    {

        #region 判斷式 if
        print("持續執行~");

        //否則 如果 else if (布林值) { 程式內容 } - if下方 else上方 - 無數量限制
        //如果 >= 60 及格
        //如果 <= 60 但是 >= 40 補考
        //否則 不及格

        if(score >= 60)
        {
            print("及格");
        }
        else
        {
            print("不及格");
        }
        #endregion

        #region 判斷式 switch
        //switch (值)
        //{
        //    case "刀子":
        //         攻擊力：10;
        //         break;
        //    case "機關槍":
        //         攻擊力：1000;
        //         break;
        //    default:
        //         這不是武器;
        //         break;
        //}

        switch (weapon)
        {
            case "刀子":
                print("攻擊力 10");
                break;
            case "機關槍":
                print("攻擊力 1000");
                break;
            default:
                print("這不是武器！");
                break;
        }

        #endregion
    }
}
