using UnityEngine;

public class LazerBulletPlayer : Bullet
{
    private float _lifeTime = 1;
    private float _elapsedTime;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        Move();
        DistroyBullet();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            enemy.ApplyDamage(_damage);

            Destroy(gameObject);
        }
    } 

    protected override void Move()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime, Space.World);
    }

    protected override void DistroyBullet()
    {
        if (_elapsedTime >= _lifeTime)
            Destroy(gameObject);
    }
}
