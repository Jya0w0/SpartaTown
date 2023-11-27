using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>(); // ﻿GetComponent : Inspector 안의 Compenent를 가져온다
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move; // Move 구독
    }

    private void FixedUpdate() // 물리처리 이후에 이동처리 메서드 호출
    {
        ApplyMovment(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction; // 키보드 입력값 설정
    }

    private void ApplyMovment(Vector2 direction) // 이동처리
    {
        direction = direction * 5; // 5라는 속도로 이동

        _rigidbody.velocity = direction;
    }
}
