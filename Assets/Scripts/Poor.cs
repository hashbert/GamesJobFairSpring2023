using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Poor : MonoBehaviour
{
    [SerializeField] private float _minHungerDelayTime = 3f;
    [SerializeField] private float _maxHungerDelayTime = 7f;
    [SerializeField] private float _randomHungerDelayTime = 7f;
    [SerializeField] private InputActionReference _select;
    // Start is called before the first frame update

    private enum HumanState
    {
        Idle,
        Hungry,
        Walking,
        Thankful
    }

    private HumanState _state = HumanState.Idle;

    //private void OnEnable()
    //{
    //    _select.action.Enable();
    //    _select.action.started += OnSelectObject;
    //}
    //private void OnDisable()
    //{
    //    _select.action.Disable();
    //    _select.action.started -= OnSelectObject;
    //}
    //private void OnSelectObject(InputAction.CallbackContext obj)
    //{
    //    //print("I was clicked!");
    //}


    void Start()
    {
        _randomHungerDelayTime = RandomHungerDelayTime(_minHungerDelayTime, _maxHungerDelayTime);
    }

    // Update is called once per frame
    void Update()
    {
        switch (_state)
        {
            case HumanState.Idle:
                _randomHungerDelayTime -= Time.deltaTime;
                if (_randomHungerDelayTime < 0)
                {
                    _randomHungerDelayTime = RandomHungerDelayTime(_minHungerDelayTime, _maxHungerDelayTime);
                    _state = HumanState.Hungry;
                }
                break;
            case HumanState.Hungry:
                break;
            case HumanState.Walking:
                break;
            case HumanState.Thankful:
                break;
            default:
                break;
        }
    }

    private float RandomHungerDelayTime(float x, float y)
    {
        return UnityEngine.Random.Range(x, y);
    }
}
