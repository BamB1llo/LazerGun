using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private Weapon _weapon;
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private float _secondsBetweenShoot;

    private Weapon _curentWeapon;
    private float _elapsedTime;
    private float _lifeTime = 30;
    private int _minHealth = 0;

    private void Start()
    {
        _curentWeapon = _weapon;
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        Shoot();
        Die();
    }

    public void ApplyDamage(int damage)
    {
        _health -= damage;
    }

    private void Shoot()
    {
        if (_elapsedTime >= _secondsBetweenShoot)
        {
            _elapsedTime = 0;

            _curentWeapon.Shoot(_shootPoint);
        }
    }

    private void Die()
    {
        if (_elapsedTime >= _lifeTime || _health <= _minHealth)
            Destroy(gameObject);
    }
}
