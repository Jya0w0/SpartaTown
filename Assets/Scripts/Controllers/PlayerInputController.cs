using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main; // Camera 씬에서 태그가 main인 코드를 찾아오겠다
    }

    private void OnMove(InputValue value)
    {
        // Debug.Log("OnMove" + value.ToString());
        Vector2 moveinput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveinput); // 움직일 때 벡터 값을 불러온다
    }

    private void OnLook(InputValue value)
    {
        // Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>(); // 마우스 포지션을 받아온다
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim); // 마우스 위치를 절대 위치로 바꾼다
        newAim = (worldPos - (Vector2)transform.position).normalized; // 캐릭터와 마우스 커서까지의 거리와 방향
        CallLookEvent(newAim);

        //if (newAim.magnitude >= .9f) // magnitude : 크기(normalized 했기 때문에 1) 혹시 모를 오류 방지를 위해 제한 // normalized해서 필요없음
        //{
        //    CallLookEvent(newAim);
        //}
    }

    private void OnFire(InputValue value)
    {
        IsAttacking = value.isPressed;
    }
}
