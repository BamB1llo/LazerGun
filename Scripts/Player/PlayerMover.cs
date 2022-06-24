using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    
    private Rigidbody2D _rigidbody;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        TryMove();
    }

    private void TryMove()
    {
        float verticalMove = Input.GetAxisRaw("Vertical") * _movementSpeed;
        float horizontalMove = Input.GetAxisRaw("Horizontal") * _movementSpeed;

        _rigidbody.velocity = new Vector2(horizontalMove, verticalMove);
    }
}
