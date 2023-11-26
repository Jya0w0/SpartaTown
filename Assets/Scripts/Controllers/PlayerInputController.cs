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
        CallMoveEvent(moveinput);
    }

    private void OnLook(InputValue value)
    {
        // Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>(); // ���콺 �������� �޾ƿ´�
        Vector2 worldPos = _camera.WorldToScreenPoint(newAim); // ���콺 ��ġ�� ���� ��ġ�� �ٲ۴�
        newAim = (worldPos - (Vector2)transform.position).normalized; // ĳ���Ϳ� ���콺 Ŀ�������� �Ÿ��� ����

        if (newAim.magnitude >= .9f) // magnitude : ũ��(normalized �߱� ������ 1)
        {
            CallLookEvent(newAim);
        }
    }

    private void OnFire(InputValue value)
    {
        Debug.Log("OnFire" + value.ToString());
    }
}
