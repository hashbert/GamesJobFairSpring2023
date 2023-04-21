using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Human : MonoBehaviour
{
    [SerializeField] private InputActionReference _select;
    // Start is called before the first frame update

    private void OnEnable()
    {
        _select.action.Enable();
        _select.action.started += OnSelectObject;
    }
    private void OnDisable()
    {
        _select.action.Disable();
        _select.action.started -= OnSelectObject;
    }
    private void OnSelectObject(InputAction.CallbackContext obj)
    {
        //print("I was clicked!");
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
