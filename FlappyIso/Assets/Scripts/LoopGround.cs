using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _width = 6f;

    private SpriteRenderer _sr;

    private Vector2 _startSize;

    private void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
        _startSize = new Vector2(_sr.size.x, _sr.size.y);

    }
    private void Update()
    {
        _sr.size = new Vector2(_sr.size.x + _speed * Time.deltaTime, _sr.size.y);
        if(_sr.size.x > _width)
        {
            _sr.size = _startSize;
        }
    }
}
