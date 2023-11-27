using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownCharacterController _controller; // 캐릭터가 바라보도록 한다

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Debug.Log(rotZ);

        armRenderer.flipY = Mathf.Abs(rotZ) > 90f; // y축을 기준으로 뒤집는 코드
        characterRenderer.flipX = armRenderer.flipY; // 캐릭터를 기준으로 무기가 90도를 넘어가게 되면 뒤집는다
        armPivot.rotation = Quaternion.Euler(0, 0, rotZ); // 무기 회전
    }
}
