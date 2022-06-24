using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    private Rigidbody2D _rigidbody;
    private Vector3[] _points;
    private int _index;
    private float _distanceToPoint = 0.01f;

    private float _positionOnXLeft = -2.5f;
    private float _positionOnXRight = 2.5f;
    private float _positionOnY = 4.14f;
    private float _positionOnY1 = 1.24f;
    private float _positionOnY2 = 2.75f;
    private float _positionOnZ = 0f;

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
        Vector3 point = new Vector3(_positionOnXRight, _positionOnY, _positionOnZ);
        Vector3 point1 = new Vector3(_positionOnXLeft, _positionOnY1, _positionOnZ);
        Vector3 point2 = new Vector3(_positionOnXRight, _positionOnY2, _positionOnZ);
        Vector3 point3 = new Vector3(_positionOnXLeft, _positionOnY, _positionOnZ);
        Vector3 point4 = new Vector3(_positionOnXRight, _positionOnY1, _positionOnZ);
        Vector3 point5 = new Vector3(_positionOnXLeft, _positionOnY2, _positionOnZ);

        _points = new Vector3[] { point, point1, point2, point3, point4, point5 };
    }

    private void Move()
    {
        _rigidbody.MovePosition(Vector3.MoveTowards(transform.position, _points[_index], _movementSpeed * Time.deltaTime));

        if (Vector3.Distance(transform.position, _points[_index]) < _distanceToPoint)
        {
            if (_index < _points.Length - 1)
                _index++;
            else
                Destroy(gameObject);
        }
    }
}
