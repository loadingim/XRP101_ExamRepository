using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerStatus _status;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        _status = GetComponent<PlayerStatus>();
    }

    private void Update()
    {
        MovePosition();
    }

    private void MovePosition()
    {
        Vector3 direction = Vector3.zero;
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        // 대각선으로 움직일때 1.14가되어 Nomalize()를 이용해 정규화 해준다.
        direction.Normalize();
        if (direction == Vector3.zero) return;
        
        transform.Translate(_status.MoveSpeed * Time.deltaTime * direction);
    }
}
