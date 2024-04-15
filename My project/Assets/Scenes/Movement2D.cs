using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private Rigidbody2D rigid2d;
    private float moveSpeed = 3.0f;
    private Vector3 moveDirection;

    private void Awake()
    {
        rigid2d         = GetComponent<Rigidbody2D>();

        moveSpeed       = 5.0f;
        moveDirection   = Vector3.right;
    }
    private void Update()
    {
        // 키 입력 없을 땐 이동방향 x(제자리)
        moveDirection = Vector3.zero;

        // Up/Down/Left/Right 방향키를 눌렀을 때 이동방향 설정
        //Up or Down
        if ( Input.GetKey(KeyCode.UpArrow) )
        {
            moveDirection += Vector3.up;
        }
        else if ( Input.GetKey(KeyCode.DownArrow) )
        {
            moveDirection += Vector3.down;
        }
        //Left or Right
        if ( Input.GetKey(KeyCode.LeftArrow) )
        {
            moveDirection += Vector3.left;
        }
        else if ( Input.GetKey(KeyCode.RightArrow) )
        {
            moveDirection += Vector3.right;
        }

        //이동/회전/크기를 제어하는 "Transform" 컴포넌트를 조작해 오브젝트를 이동
        // 새로운 위치 = 현재 위치 + (방향 * 속도);
        //transform.position += moveDirection * moveSpeed  * Time.deltaTime;

        //오브젝트 속력 설정
        rigid2d.velocity = moveDirection * moveSpeed;
    }
}
