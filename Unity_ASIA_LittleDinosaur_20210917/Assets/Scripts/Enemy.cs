using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region ���
    [Header("�ˬd�l�ܰϰ�j�p�P�첾")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3TrackOffset;
    [Header("���ʳt��")]
    public float speed = 1.5f;
    [Header("�ؼйϼh")]
    public LayerMask layerTarget;
    [Header("�ʵe�Ѽ�")]
    public string parameterWalk = "���䨫��";
    [Header("���ۥؼЪ���")]
    public Transform target;

    private float angle = 0;
    private Rigidbody2D rig;
    private Animator ani;
    #endregion

    #region �ƥ�
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
                //  �k�� angle = 180
        }
        else if (target.position.x < transform.position.x)
        {
                //  ���� angle = 0
        }
        angle = target.position.x > transform.position.x ? 180 : 0;
        transform.eulerAngles = Vector3.up * angle;
        rig.velocity = transform.TransformDirection( new Vector2(-speed, rig.velocity.y));
        ani.SetBool(parameterWalk,true);

        float distance = Vector3.Distance(target.position, transform.position);
        print("�P�ؼЪ��Z��:" + distance);
    }
    #endregion
}