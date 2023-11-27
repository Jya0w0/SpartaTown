using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    // event : 외부에서 호출하지 못하게 막아주는 기능
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnAttackEvent;

    private float _timeSinceLastAttack = float.MaxValue; // 마지막으로 공격한 시간
    protected bool IsAttacking { get; set; } // Attack에 대한 프로퍼티

    protected virtual void Update() // virtual: 하위에서 상속받아 오버라이드에서 쓸 수 있도록 함
    {
        HandleAttackDelay();
    }

    private void HandleAttackDelay() // 공격에 대한 시스템 구현
    {
        if (_timeSinceLastAttack <= 0.2f) // 나중에 수정
        {
            _timeSinceLastAttack += Time.deltaTime;
        }

        if (IsAttacking && _timeSinceLastAttack > 0.2f)
        {
            _timeSinceLastAttack = 0;
            CallAttackEvent();
        }
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); //?. : OnLookEvent이 Null이 아닐 때만 동작
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    public void CallAttackEvent()
    {
        OnAttackEvent?.Invoke();
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
