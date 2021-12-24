using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//建立專案內的選單(menuName = "專案名稱") 資料夾/子資料
[CreateAssetMenu(menuName = "FDay Learning/對話資料")]
///<summary>
///對話資料
///保存 NPC 要對玩家說的對話內容
///</summary>
///ScriptableObject 腳本化物件：將程式資料儲存至 Project 內的物件

public class DataDialogue : ScriptableObject
{
    [Header("對話內容"), TextArea(3, 5)]
    public string[] dialogue;
}
