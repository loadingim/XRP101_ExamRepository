using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    float value;

    // ���� ������ �ִ� �κ��� �ڱ� �ڽ��̶� �������� ���� �־� ���ο� ���� ����� �Ҵ����ش�.
    public float MoveSpeed {get { return value; }}

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        value = 5f;
    }
}
