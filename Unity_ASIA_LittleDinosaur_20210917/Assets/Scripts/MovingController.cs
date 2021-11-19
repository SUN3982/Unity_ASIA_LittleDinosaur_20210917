
using UnityEngine;

/// <summary>
/// 控制器：2D 橫向卷軸 角色移動
/// </summary>

public class MovingController : MonoBehaviour
{
    #region 欄位：公開
    [Header("移動速度"), Range(0, 500 )]
    public float speed = 3.5f;

    [Header("跳躍高度"), Range(0, 1500)]
    public float jump = 10f;
    #endregion
}
