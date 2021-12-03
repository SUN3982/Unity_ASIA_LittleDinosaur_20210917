
using UnityEngine;

/// <summary>
/// 控制器:2D橫向卷軸 腳色移動
/// </summary>
public class moviecontroler : MonoBehaviour
{
    #region 欄位:公開
    [Header("移動速度"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("跳躍高度"), Range(0, 1500)]
    public float jump = 30f;
    [Header("檢查地板尺寸與位移")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundoffset;
    [Header("跳躍按鍵與可跳躍圖層")]
    public KeyCode keyjump = KeyCode.Space;
    public LayerMask canJumpLayer;
    [Header("動畫參數 : 走路與跳躍")]
    public string parameterWalk = "開關走路";
    public string parameterJump = "開關跳躍";
    #endregion


    #region 私人
    private Animator ani;
    ///<summary> 
    ///剛體元件 Rigidboby 2D
    ///</summary> 
    private Rigidbody2D rig;
    [SerializeField]
    private bool isGrounded;
    #endregion

    #region 事件
    /// <summary>
    /// 繪製圖示
    /// 在Unity繪製輔助用圖示
    /// 線條、射線、圖形、方形、扇形、圖片
    /// 圖示 Gizmos 類別
    /// </summary>
    private void OnDrawGizmos()
    {
        //1.決定圖示顏色
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        //2.決定繪製圖形
        //transform.position 此物件的世界座標
        //transform.TransformDirection()根據變形元件的區域座標轉換為世界座標
        Gizmos.DrawSphere(transform.position +
            transform.TransformDirection(checkGroundoffset), checkGroundRadius);

    }

    private void Start()
    {
        //剛體欄位 = 取得元件<2D 剛體>()
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }
   
    /// <summary>
    /// Update 約 60 FPS
    /// 固定更新事件 : 50 FPS
    /// 處理物理行為
    /// </summary>

    private void FixedUpdate()
    {
        Move();
    }
    private void Update()
    {
        Flip();
        CheckGround();
        Jump();
    }
    #endregion

    #region 方法
    /// <summary>
    /// 玩家是否有按移動按紐 左右建 或A、D
    /// 物件移動行為(API)
    /// </summary>
    private void Move()
    {
        //h 值 指定為 輸入.取得軸向(水平軸)-水平軸代表作右鍵與A、D
        float h = Input.GetAxis("Horizontal");
        //print("玩家左右按鍵值:" + h);

        //剛體元件.加速度=新 二維向量(h值*移動速度，加速度.垂直)；
        rig.velocity = new Vector2(h * speed, rig.velocity.y);


        ani.SetBool(parameterWalk, h != 0);
    }

    ///<summary>
    ///翻面:
    ///左:角度 Y 180
    ///右:角度 Y0
    ///</summary>
    private void Flip()
    {
        float h = Input.GetAxis("Horizontal");

        if (h > 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (h < 0)
        {
            transform.eulerAngles = Vector3.zero;
        }
    }
   


    private void CheckGround()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position +
                  transform.TransformDirection(checkGroundoffset), checkGroundRadius, canJumpLayer);
        //print("碰到的物件名稱:" + hit.name);
        isGrounded = hit;

        ani.SetBool(parameterJump, !isGrounded);
   
    }
    private void Jump()
    {
        if (isGrounded && Input.GetKeyDown(keyjump))
        {
            rig.AddForce(new Vector2(0, jump));
        }
    }
    #endregion
}