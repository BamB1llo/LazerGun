using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerBulletEnemy : Bullet
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
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            player.ApplyDamage(_damage);

            Destroy(gameObject);
        }
    } 

    protected override void Move()
    {
        transform.Translate(Vector2.down * _speed * Time.deltaTime, Space.World);
    }

    protected override void DistroyBullet()
    {
        if (_elapsedTime >= _lifeTime)
            Destroy(gameObject);
    }
}
