using UnityEngine;

public class LazerGun : Weapon
{
    private float _turnX = 0f;
    private float _turnY = 0f;
    private float _turnZ = -90f;

    public override void Shoot(Transform shootPoint)
    {
        Instantiate(Bullet, shootPoint.position, Quaternion.Euler(_turnX, _turnY, _turnZ));
    }
}
