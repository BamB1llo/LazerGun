using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    private Rigidbody2D _rigidbody;
    private Vector3[] _points;
    private int _index;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        CreatePositions();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void CreatePositions()
    {
        Vector3 point = new Vector3(2.5f, 4.14f, 0);
        Vector3 point1 = new Vector3(-2.5f, 1.24f, 0);
        Vector3 point2 = new Vector3(2.5f, 2.75f, 0);
        Vector3 point3 = new Vector3(-2.5f, 4.14f, 0);
        Vector3 point4 = new Vector3(2.5f, 1.24f, 0);
        Vector3 point5 = new Vector3(-2.5f, 2.75f, 0);

        _points = new Vector3[] { point, point1, point2, point3, point4, point5 };
    }

    private void Move()
    {
        _rigidbody.MovePosition(Vector3.MoveTowards(transform.position, _points[_index], _movementSpeed * Time.deltaTime));

        if(Vector3.Distance(transform.position, _points[_index]) < 0.01f)
        {
            if(_index < _points.Length -1)
            {
                _index++;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        
        Debug.Log("Я дошел");
    }
}
