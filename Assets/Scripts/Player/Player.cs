using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;
    
    private Animator _animator;
    private string _idleRight = "IdleRight";
    private int _currentHealth;

    public int CurrentHealth => _currentHealth;

    public event UnityAction <int, int> HealthIsChanged;

    public void Start()
    {
        _animator = GetComponent<Animator>();
        _currentHealth = _maxHealth;        
        
        _animator.Play(_idleRight);
    }

    public void ApplyDamage(int damage)
    {
        _currentHealth -= damage;

        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
            gameObject.SetActive (false);
        }

        HealthIsChanged?.Invoke(_currentHealth,_maxHealth);
    }

    public void ApplyHealing(int damage)
    {
        if (_currentHealth == 0)
            gameObject.SetActive(true);

        _currentHealth += damage;

        if (_currentHealth > _maxHealth)
            _currentHealth = _maxHealth;        

        HealthIsChanged?.Invoke(_currentHealth, _maxHealth);
    }
}