using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private Weapon _weapon;
    [SerializeField] private Transform _shootPoint;

    private Weapon _currentWeapon;
    private int _currentWeaponNumber;
    private int _currentHealth;

    public event UnityAction<int> HealthChanged;
    public event UnityAction Died;
    
    private void Start()
    {
        _currentWeapon = _weapon;
        _currentHealth = _health;
        HealthChanged?.Invoke(_health);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _currentWeapon.Shoot(_shootPoint);
        }
    }

    public void ApplyDamage(int damage)
    {
        _health -= damage;
        HealthChanged?.Invoke(_health);

        if (_health <= 0)
            Die();
    }

    public void Die()
    {
        Died?.Invoke();
        Destroy(gameObject);
    }
}
