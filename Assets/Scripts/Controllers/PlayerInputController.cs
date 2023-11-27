using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main; // Camera ������ �±װ� main�� �ڵ带 ã�ƿ��ڴ�
    }

    private void OnMove(InputValue value)
    {
        // Debug.Log("OnMove" + value.ToString());
        Vector2 moveinput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveinput); // ������ �� ���� ���� �ҷ��´�
    }

    private void OnLook(InputValue value)
    {
        // Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>(); // ���콺 �������� �޾ƿ´�
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim); // ���콺 ��ġ�� ���� ��ġ�� �ٲ۴�
        newAim = (worldPos - (Vector2)transform.position).normalized; // ĳ���Ϳ� ���콺 Ŀ�������� �Ÿ��� ����
        CallLookEvent(newAim);

        //if (newAim.magnitude >= .9f) // magnitude : ũ��(normalized �߱� ������ 1) Ȥ�� �� ���� ������ ���� ���� // normalized�ؼ� �ʿ����
        //{
        //    CallLookEvent(newAim);
        //}
    }

    private void OnFire(InputValue value)
    {
        IsAttacking = value.isPressed;
    }
}
