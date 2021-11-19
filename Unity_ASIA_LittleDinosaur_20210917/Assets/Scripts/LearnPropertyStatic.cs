
using UnityEngine;

/// <summary>
/// 學習靜態屬性 Static Property
/// </summary>

public class LearnPropertyStatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //靜態屬性
        //取得 Get
        //語法：類別名稱.靜態屬性名稱
        print("隨機值：" + Random.value);
        print("所有攝影機數量：" + Camera.allCamerasCount);

        //設定 Set - 不能對 Read Only 屬性指定
        //語法：類別名稱.靜態屬性名稱 指定 值;
        Time.timeScale = 0.5f;
        Cursor.visible = false;

        //Random.value = 0.5f         // Read Only 不能設定
    }
}
