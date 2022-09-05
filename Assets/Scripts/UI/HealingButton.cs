using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingButton : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _healing;

    public void HealingPlayer()
    {
        if (_player == null)
            return;

        _player.ApplyHealing(_healing);
    }
}
