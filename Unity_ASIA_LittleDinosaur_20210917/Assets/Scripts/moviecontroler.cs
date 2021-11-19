
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
    #endregion

    /// <summary>
    /// ���餸�� Rigidbody 2D
    /// </summary>
    private Rigidbody2D rig;

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

    #region ��k
    /// <summary>
    /// ���a�O�_�������ʫ��� ���k�� ��A�BD
    /// ���󲾰ʦ欰(API)
    /// </summary>
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        print("���a���k�����:" + h);
    }
    #endregion
}