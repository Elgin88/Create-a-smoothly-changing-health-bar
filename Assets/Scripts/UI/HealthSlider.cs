using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;
    [SerializeField] private float _speedOfDuration;

    private Coroutine _smoothChangeJob;
    private float _targetValue;
    
    private void Start()
    {
        _slider.value = 1;
    }

    private void OnEnable()
    {
        _player.HealthIsChanged += OnHealthChanged;        
    }

    private void OnDisable()
    {
        _player.HealthIsChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(int targetHealt, int maxHealth)
    {
        if (_smoothChangeJob != null)
            StopCoroutine(_smoothChangeJob);

        _smoothChangeJob = StartCoroutine(SmoothChange(targetHealt, maxHealth));
    }

    private IEnumerator SmoothChange(int targetHealt, int maxHealth)
    {
        while (true)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, (float) targetHealt / maxHealth, _speedOfDuration * Time.deltaTime);
            
            yield return null;
        }  
    }
}
