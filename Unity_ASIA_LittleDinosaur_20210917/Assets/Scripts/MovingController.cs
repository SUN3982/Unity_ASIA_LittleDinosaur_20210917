
using UnityEngine;

/// <summary>
/// ����G2D ��V���b ���Ⲿ��
/// </summary>

public class MovingController : MonoBehaviour
{
    #region ���G���}
    [Header("���ʳt��"), Range(0, 500 )]
    public float speed = 3.5f;

    [Header("���D����"), Range(0, 1500)]
    public float jump = 10f;
    #endregion
}
