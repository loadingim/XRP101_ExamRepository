using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Vector3 SetPoint { get; private set; }

    public void SetPosition(float x, float y, float z)
    {
        // 함수가 실행되도 값을 안 받아 오기에 받아 오도록 변경
        SetPoint = new Vector3(x, y, z);
        transform.position = SetPoint;
    }
}
