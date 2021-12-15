using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class Hopscotch : MonoBehaviour
{
    [SerializeField]
    GameObject upDown;
    [SerializeField]
    GameObject leftRight;

    public bool isUpDown;
    private bool active;

    PlayerInput input;
    InputAction up, down, left, right;

    int count;

    [SerializeField]
    UnityEvent OnSuccess;

    void Start()
    {
        count = 1;
        isUpDown = true;

        input = GetComponent<PlayerInput>();
        up = input.actions["Up"];
        down = input.actions["Down"];
        left = input.actions["Left"];
        right = input.actions["Right"];

        active = false;

        upDown.SetActive(false);
        leftRight.SetActive(false); 
    }

    public void Run() 
    {
        active = true;
    }

    bool letGoFirst = false;
    private void Update()
    {
        if (isUpDown && active && !letGoFirst)
        {
            upDown.SetActive(true);
            leftRight.SetActive(false);
            if (up.ReadValue<float>() == 1 && down.ReadValue<float>() == 1)
            {
                count++;
                letGoFirst = true;
                isUpDown = !isUpDown;
                if (count > 3)
                {
                    count = 1;
                    active = false;
                    OnSuccess.Invoke();
                }
            }
        }
        else if (!isUpDown && active && !letGoFirst)
        {
            upDown.SetActive(false);
            leftRight.SetActive(true);
            if (left.ReadValue<float>() == 1 && right.ReadValue<float>() == 1)
            {
                count++;
                letGoFirst = true;
                isUpDown = !isUpDown;
                if (count > 3)
                {
                    count = 1;
                    active = false;
                    OnSuccess.Invoke();
                }
            }
        }
        else 
        {
            upDown.SetActive(false);
            leftRight.SetActive(false);
        }

        if (letGoFirst) 
        {
            letGoFirst = left.ReadValue<float>() + right.ReadValue<float>() + up.ReadValue<float>() + down.ReadValue<float>() == 0;
        }
    }


}
