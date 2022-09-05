using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _damage;

    public void DamagePlayer()
    {
        if (_player == null)
            return;

        _player.ApplyDamage(_damage);
    }
}
