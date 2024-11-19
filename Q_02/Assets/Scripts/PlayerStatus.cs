using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    float value;

    // 값을 리턴해 주는 부분이 자기 자신이라 무한으로 돌고 있어 새로운 값을 만들어 할당해준다.
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
