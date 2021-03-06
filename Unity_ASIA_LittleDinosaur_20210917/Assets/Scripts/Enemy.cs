using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region 欄位
    [Header("檢查追蹤區域大小與位移")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3TrackOffset;
    [Header("移動速度")]
    public float speed = 1.5f;
    [Header("目標圖層")]
    public LayerMask layerTarget;
    [Header("動畫參數")]
    public string parameterWalk = "關鍵走路";
    [Header("面相目標物件")]
    public Transform target;

    private float angle = 0;
    private Rigidbody2D rig;
    private Animator ani;
    #endregion

    #region 事件
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize);
    }
    private void Update()
    {
        CheckTargetInArea();
    }
    #endregion

    #region
    private void CheckTargetInArea()
    {
        Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize, 0);
        if (hit) Move();
    }
    private void Move()
    {   
        if(target.position.x> transform.position.x)
        {
                //  右邊 angle = 180
        }
        else if (target.position.x < transform.position.x)
        {
                //  左邊 angle = 0
        }
        angle = target.position.x > transform.position.x ? 180 : 0;
        transform.eulerAngles = Vector3.up * angle;
        rig.velocity = transform.TransformDirection( new Vector2(-speed, rig.velocity.y));
        ani.SetBool(parameterWalk,true);

        float distance = Vector3.Distance(target.position, transform.position);
        print("與目標的距離:" + distance);
    }
    #endregion
}
