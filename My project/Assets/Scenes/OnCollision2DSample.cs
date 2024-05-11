using UnityEngine;

public class OnCollision2DSample : MonoBehaviour
{
    [SerializeField]
    private Color              myColor;
    private SpriteRenderer     spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // <summary>
    // 충돌이 일어나는 순간 1회 호출(Enter)
    // </summary>
    private void OnCollisionEnter2D(Collision2D other) 
    {
        spriteRenderer.color = myColor;
    }
    /*
    충돌이 유지되는 동안 매 프레임 호출(Stay)
    */
    private void OnCollisionStay2D(Collision2D other) 
    {
        Debug.Log($"{gameObject.name} : OncollisionStay2D() 메소드 실행");
    }

    /*
    충돌이 종료되는 순간 1회 호출(Exit)
    */
    private void OnCollisionExit2D(Collision2D other) 
    {
        spriteRenderer.color = Color.white;
    }
}
