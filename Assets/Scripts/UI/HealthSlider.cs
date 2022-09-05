using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;
    [SerializeField] private float _speed;





    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, 1, _speed * Time.deltaTime);

        if (_slider.value == 1)
        {

        }
    }






























    //private void Start()
    //{
    //    StartCoroutine(SmoothChange());
    //}

    //private void OnEnable()
    //{
    //    _player.HealthIsChanged += OnChangedValue;
    //}

    //private void OnDisable()
    //{
    //    _player.HealthIsChanged -= OnChangedValue;
    //}

    //private void OnChangedValue(int targetValue, int maxValue)
    //{
    //    _targetValue = targetValue;
    //    _maxValue = maxValue;

    //    SmoothChange();
    //}

    //private IEnumerator SmoothChange()
    //{
    //    float startValue = _slider.value;

    //    while (true)
    //    {
    //        if (_slider.value != (float)_targetValue)
    //        {
    //            _slider.value = Mathf.MoveTowards(startValue, (float)_targetValue / _maxValue, _speed * Time.deltaTime);
    //        }

    //        yield return null;
    //    }
    //}
}
