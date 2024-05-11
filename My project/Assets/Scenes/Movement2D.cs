using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private Rigidbody2D rigid2d;

    [SerializeField]
    private float moveSpeed = 3.0f;
    [SerializeField]
    private float jumpForce = 8.0f;

    private Vector3 moveDirection;

    public Animator animator; // 애니메이션 컨트롤러


    private void Awake()
    {
        rigid2d         = GetComponent<Rigidbody2D>();
        animator        = GetComponent<Animator>();

        moveSpeed       = 5.0f;
        moveDirection   = Vector3.right;
    }

    public void jump()
    {
        rigid2d       = GetComponent<Rigidbody2D>();
        moveDirection = Vector3.up;
        rigid2d.velocity = moveDirection * jumpForce;
    }

    //public void attack()
    //{
        //충돌 생성 함수 호출, weapon에서 공격력 받아오기
        //or
        //weapon에 가서 충돌판정 생성 함수 호출
    //}
    private void Update()
    {
        // 키 입력 없을 땐 이동방향 x(제자리)
        moveDirection = Vector3.zero;

        // jump
        if ( Input.GetKey(KeyCode.A) )
        {
            //attack(); //attack 호출
            animator.SetTrigger("Isattack"); // 애니메이션 실행
        }
        if ( Input.GetKey(KeyCode.Space) )
        {
             jump();
             animator.SetTrigger("Isjump"); // 애니메이션 실행
        }
        //Left or Right
        if ( Input.GetKey(KeyCode.LeftArrow) )
        {
            moveDirection += Vector3.left;
            animator.SetTrigger("Iswalk"); // 애니메이션 실행
        }
        else if ( Input.GetKey(KeyCode.RightArrow) )
        {
            moveDirection += Vector3.right;
            animator.SetTrigger("Iswalk"); // 애니메이션 실행
        }

        //이동/회전/크기를 제어하는 "Transform" 컴포넌트를 조작해 오브젝트를 이동
        // 새로운 위치 = 현재 위치 + (방향 * 속도);
        //transform.position += moveDirection * moveSpeed  * Time.deltaTime;

        //오브젝트 속력 설정
        rigid2d.velocity = moveDirection * moveSpeed;
    }
}
