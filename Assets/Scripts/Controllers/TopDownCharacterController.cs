using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    // event : 외부에서 호출하지 못하게 막아주는 기능
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction); //?. : OnLookEvent이 Null이 아닐 때만 동작
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}

// 이동 연습 코드
//{
//    //[SerializeField] private float speed = 5f;

//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        //float x = Input.GetAxisRaw("Horizontal");
//        //float y = Input.GetAxisRaw("Vertical");

//        //transform.position += new Vector3(x, y) * speed * Time.deltaTime;
//    }
//}
