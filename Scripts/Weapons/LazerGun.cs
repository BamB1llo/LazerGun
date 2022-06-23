using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerGun : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        Instantiate(Bullet, shootPoint.position, Quaternion.Euler(0f, 0f, -90f));
    }
}
