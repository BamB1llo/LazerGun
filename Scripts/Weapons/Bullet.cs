using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] protected int _damage;
    [SerializeField] protected float _speed;

    protected abstract void Move();
    protected abstract void DistroyBullet();
}
