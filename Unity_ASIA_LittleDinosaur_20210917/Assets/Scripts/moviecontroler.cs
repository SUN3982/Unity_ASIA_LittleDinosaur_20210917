
using UnityEngine;

/// <summary>
/// ���:2D��V���b �}�Ⲿ��
/// </summary>
public class moviecontroler : MonoBehaviour
{
    #region ���:���}
    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("���D����"), Range(0, 1500)]
    public float jump = 10f;
    [Header("�ˬd�a�O�ؤo�P�첾")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundoffset;
    [Header("���D����P�i���D�ϼh")]
    public KeyCode keyjump = KeyCode.Space;
    public LayerMask canJumpLayer;
    #endregion

    ///<summary> 
    ///���餸�� Rigidboby 2D
    ///</summary> 
    private Rigidbody2D rig;

    /// <summary>
    /// ø�s�ϥ�
    /// �bUnityø�s���U�ιϥ�
    /// �u���B�g�u�B�ϧΡB��ΡB���ΡB�Ϥ�
    /// �ϥ� Gizmos ���O
    /// </summary>
    private void OnDrawGizmos()
    {
        //1.�M�w�ϥ��C��
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        //2.�M�wø�s�ϧ�
        //transform.position �����󪺥@�ɮy��
        //transform.TransformDirection()�ھ��ܧΤ��󪺰ϰ�y���ഫ���@�ɮy��
        Gizmos.DrawSphere(transform.position +
            transform.TransformDirection(checkGroundoffset), checkGroundRadius);

    }



    private void Start()
    {
        //������� = ���o����<2D ����>()
        rig = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Update �� 60 FPS
    /// �T�w��s�ƥ� : 50 FPS
    /// �B�z���z�欰
    /// </summary>

    private void FixedUpdate()
    {
        Move();
    }
    private void Update()
    {
        Flip();
    }

    #region ��k
    /// <summary>
    /// ���a�O�_�������ʫ��� ���k�� ��A�BD
    /// ���󲾰ʦ欰(API)
    /// </summary>
    private void Move()
    {
        //h �� ���w�� ��J.���o�b�V(�����b)-�����b�N��@�k��PA�BD
        float h = Input.GetAxis("Horizontal");
        print("���a���k�����:" + h);

        //���餸��.�[�t��=�s �G���V�q(h��*���ʳt�סA�[�t��.����)�F
        rig.velocity = new Vector2(h * speed, rig.velocity.y);
    }

    ///<summary>
    ///½��:
    ///��:���� Y 180
    ///�k:���� Y0
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
    #endregion
}