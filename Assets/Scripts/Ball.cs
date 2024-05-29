using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        ResetPosition();
    }
    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;

        AddStartingForce();
        
    }
    public void AddStartingForce()
    {
        // x 방향이 0이 아닌 값을 선택합니다.
    float x = Random.Range(-1.0f, 1.0f);
    // x와 수직하지 않은 y 값을 선택합니다.
    float y = Random.Range(-1.0f, 1.0f);
    while (Mathf.Approximately(x, 0) && Mathf.Approximately(y, 0))
    {
        y = Random.Range(-1.0f, 1.0f);
    }
    
    // 방향 벡터를 생성합니다.
    Vector2 direction = new Vector2(x, y).normalized;
    
    _rigidbody.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }

  

    
}
