using UnityEngine;

[CreateAssetMenu(menuName = "��ܸ��/��ܸ��")]
/// <summary>
/// ��ܸ��
/// �O�s NPC �n�򪱮a�����ܤ��e
/// </summary>
/// Scriptable Object �}���ƪ���;�N�{������x�s�� Project��������

public class DataDialogue :ScriptableObject
{
    // Text Area (�̤p��ơA�̤j���) - �ȭ� string
    [Header("��ܤ��e"), TextArea(3, 5)]
    public string[] dialogues; 
}
