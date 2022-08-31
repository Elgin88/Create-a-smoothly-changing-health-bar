using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Player : MonoBehaviour
{
    private Animator _animator;
    private string _idleRight = "IdleRight";

    public void Start()
    {
        _animator = GetComponent<Animator>();
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
}