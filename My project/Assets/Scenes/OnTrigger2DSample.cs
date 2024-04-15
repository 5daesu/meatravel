using UnityEngine;

public class OnTrigger2DSample : MonoBehaviour
{
    [SerializeField]
    private Transform       moveObject;
    [SerializeField]
    private Vector3         moveDirection;
    [SerializeField]
    private float           moveSpeed;


    private void OnTriggerEnter2D(Collider2D other) //충돌이 시작되는 순간 1회 호출
    {
        moveObject.GetComponent<SpriteRenderer>().color = Color.black;    
    }

    private void OnTriggerStay2D(Collider2D other) //충돌이 유지되는 동안 매 프레임 호출
    {
        moveObject.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerExit2D(Collider2D other) //충돌이 종료되는 순간 1회 호출
    {
        moveObject.GetComponent<SpriteRenderer>().color = Color.white;
        moveObject.position = new Vector3(0, 2.5f, 0);
    }
}
