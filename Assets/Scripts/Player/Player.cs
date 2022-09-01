using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;

    private Animator _animator;
    private string _idleRight = "IdleRight";
    private int _currentHealth;

    public void Start()
    {
        _animator = GetComponent<Animator>();
        _currentHealth = _maxHealth;

        StartCoroutine(PlayAnimation());
    }

    private IEnumerator PlayAnimation()
    {
        while (true)
        {
            _animator.Play(_idleRight);
            yield return null;
        }
    }

    public void ApplyDamage(int damage)
    {
        _currentHealth -= damage;

        if (_currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void ApplyHealing(int damage)
    {
        _currentHealth += damage;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
    }
}