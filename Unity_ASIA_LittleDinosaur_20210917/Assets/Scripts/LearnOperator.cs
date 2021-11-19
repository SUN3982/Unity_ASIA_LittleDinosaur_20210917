
using UnityEngine;

/// <summary>
/// 學習運算子
/// 1.指定 =
/// 2.數學 + - * /  餘數:%  遞增:++  遞減:--
/// 3.比較 > < >= <= == !=
/// 4.邏輯 &&(並且)  ||(或者)  顛倒 !
/// </summary>
public class LearnOperator : MonoBehaviour
{
    #region 指定運算子
    //指定運算子特性：
    //※指定運算子會先運行右邊再指定給左邊
    public int number = 10;     //指定：將數字10指定給欄位number

    public float numberA = 20;
    public float numberB = 3;
    public int numberC = 30;
    public int numberD = 5;

    public int numberE = 9;
    public int numberF = 1;

    #endregion

    #region  
    private void Start()
    {
        #region 數學運算子
        print("加法" + (numberA + numberB));
        print("減法" + (numberA - numberB));
        print("乘法" + (numberA * numberB));
        print("除法" + (numberA / numberB));
        print("餘數" + (numberA % numberB));

        numberC = numberC - 1;
        print("numberC減1：" + numberC);
        numberC--;                           //遞減
        print("numberC減1：" + numberC);

        numberD = numberD + 10;
        print("numberD 加 10：" + numberD);
        numberD += 10;                       //遞增指定 + - * / %
        print("numberD 加 10：" + numberD);
        #endregion

        #region 比較運算子
        //作用：比較兩個值，並取得布林值結果
        print("E > F：" + (numberE > numberF));
        print("E < F：" + (numberE < numberF));
        print("E >= F：" + (numberE >= numberF));
        print("E <= F：" + (numberE <= numberF));
        print("E == F：" + (numberE == numberF));
        print("E != F：" + (numberE != numberF));

        #endregion

        #region 邏輯運算子
        //作用：比較兩個布林值，並取得布林值結果
        //並且：只要有一個false，結果為false
        print("T && T：" + (true && true));
        print("T && F：" + (true && false));
        print("F && T：" + (false && true));
        print("F && F：" + (false && false));

        //或著：只要有一個true，結果為true
        print("T || T：" + (true || true));
        print("T || F：" + (true || false));
        print("F || T：" + (false || true));
        print("F || F：" + (false || false));

        //顛倒：將布林值給為相反
        print("!true：" + (!true));
        print("!false：" + (!false));
        #endregion
    }
    #endregion
}
