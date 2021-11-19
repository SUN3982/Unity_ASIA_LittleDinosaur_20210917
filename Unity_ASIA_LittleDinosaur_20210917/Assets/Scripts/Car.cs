using UnityEngine;    //引用Unity引擎命名空間：可使用此空間的API

//單行註解
//2021_10_22
//class 類別：物件的藍圖
//語法 類別 類別 類別名稱｛類別內容(成員)｝
//此類別要在 Unity 內使用必須繼承 MonoBehaviour
//括號"皆須"成對出現：()、[]、{}、<>、''、""
public class Car : MonoBehaviour
{
    #region 欄位語法及四大常用類型
    //欄位 Field：保存各種類型的資料
    //語法：修飾詞 資料類型 欄位名稱 指定 預設值 結束符號
    //※四大常用類型：
    //整　數：儲存沒有小數點的正負整數 - int
    //浮點數：儲存帶有小數點的正負整數 - float
    //字　串：儲存文字資訊　　　　　　 - string
    //布林值：是與否 true、false　　  - bool
    //※修飾詞
    //私人：其他類別不能存取、不顯示 private
    //公開：其他類別可以存取、顯　示 public
    //欄位屬性 Attritube
    //語法：[屬性名稱(值)]
    //1. 標題 Header(字串)
    //2. 提示 Tooltup(字串)
    //3. 範圍 Range(最小值，最大值) - 僅適用於數值類型

    public int cc = 1000;
    [Range(1, 10)]
    public float weight = 3.5f;
    [Tooltip("車子的品牌名稱")]
    public string brand = "賓士";
    [Header("是否有天窗")]
    public bool hasSkyWindow = true;
    #endregion

    #region Unity 內資料類型
    //顏色、向量、(座標)、按鍵、遊戲物件、元件
    //顏色 Color
    public Color color;
    public Color colorRed = Color.red;
    public Color colorCustum1 = new Color(1, 0, 1, 0.8f);

    //向量 Vector
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2Custum = new Vector2(1, 5);
    public Vector3 v3Custum = new Vector3(1, 3, 5);
    public Vector4 v4Custum = new Vector4(1, 2, 3, 4);

    //按鍵 Keycode
    public KeyCode Keycode;
    public KeyCode KeycodeMouseLeft = KeyCode.Mouse0;
    public KeyCode KeycodeJump = KeyCode.Space;

    //遊戲物件 GameObject
    public GameObject goCamera;

    //元件 Component
    public Transform traCamera;
    public Camera cam;
    #endregion

    #region 事件：程式的入口
    //開始事件：遊戲播放時執行一次
    private void Start()
    {
        //呼叫方法：方法名稱();
        Test();
        Drive80();
        Drive(120);　　　　　　//呼叫時填入的稱為：引數

        float w99 = ConvertWeight(9.9f);
        print("9.9轉換：" + w99);
        print("重量轉換：" + ConvertWeight(weight));
    }
    #endregion

    #region 方法語法
    //方法：保存程式內容的區塊，陳述式、演算法
    //語法：修飾詞 傳回類型 方法名稱  (參數1，參數2，...，參數N) { 程式內容 }
    //無傳回 void：使用方法時不會傳回資料
    //自訂方法：不會執行，必須呼叫才會執行
    private void Test()
    {
        //輸出(訊息) - 將訊息輸出至 Unity 儀錶板 Console
        print("Hello,World :D ");
    }
    private void Drive80()
    {
        print("開車時速：" + 80);
    }
    private void Drive(int speed)
    {
        print("開車時速：" + speed);
        print("開車音效：咻~");
    }

    private float ConvertWeight(float setWeight)
    {
        return setWeight * 50;
    }
    #endregion
}