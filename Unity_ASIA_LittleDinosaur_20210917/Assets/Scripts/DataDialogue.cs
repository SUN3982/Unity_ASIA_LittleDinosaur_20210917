using UnityEngine;

[CreateAssetMenu(menuName = "對話資料/對話資料")]
/// <summary>
/// 對話資料
/// 保存 NPC 要跟玩家說的話內容
/// </summary>
/// Scriptable Object 腳本化物件;將程式資料儲存至 Project內的物件

public class DataDialogue :ScriptableObject
{
    // Text Area (最小行數，最大行數) - 僅限 string
    [Header("對話內容"), TextArea(3, 5)]
    public string[] dialogues; 
}

