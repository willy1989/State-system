using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "State register", menuName = "ScriptableObjects/StateRegister", order = 1)]
public class StateRegister : ScriptableObject
{
    [SerializeField] private string[] states;

    public string[] States => states;


    public bool IsStateInRegister(string state)
    {
        foreach (string item in states)
        {
            if (state == item)
                return true;
        }

        throw new ArgumentException("The state : " + "'" + state + "'" + " you input doesn't exist in the register: " 
                                    + this.name +" Please check the spelling again.");
    }
}
