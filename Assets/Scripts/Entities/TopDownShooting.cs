using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown : MonoBehaviour
{
    private TopDownCharacterController _controller;

    [SerializeField] private Transform projectileSpawnPosition;
    private Vector2 _aimDirection = Vector2.right;

    public GameObject testPrefab; // �ӽ� �ڵ�

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _controller.OnAttackEvent += OnShoot;
        _controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection) // ���� ��ġ�� ����ش�
    {
        _aimDirection = newAimDirection;
    }

    private void OnShoot() // ���� ����
    {
        CreateProjectile();
    }

    private void CreateProjectile()
    {
        Instantiate(testPrefab, projectileSpawnPosition.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
