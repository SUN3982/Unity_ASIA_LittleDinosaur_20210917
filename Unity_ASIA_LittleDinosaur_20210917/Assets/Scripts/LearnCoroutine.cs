using UnityEngine;
using System.Collections;

/// <summary>
///  �{�Ѩ�P�{��
/// </summary>
public class LearnCoroutine : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Test());         //�Ұʨ�P�{��(��P�{��())
    }
    private IEnumerator Test()
    {
        print("�o�O�Ĥ@�q��r�T��");
        yield return new WaitForSeconds(1);
        print("�o�O�ĤG�q��r�T��");
        yield return new WaitForSeconds(3);
        print("�o�O�ĤT�q��r�T��");
    }
    private IEnumerator TestWithLoop()
    {
        for (int i = 0; i < 15; i++)
        {
            print("�Ʀr:" + i);
            yield return new WaitForSeconds(0.1f);

        }

    }
}
