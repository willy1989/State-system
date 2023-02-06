using System;
using UnityEngine;

[CreateAssetMenu(fileName = "State register", menuName = "ScriptableObjects/State register", order = 1)]
public class StateRegister : ScriptableObject
{
    [SerializeField] private string[] states;

    private void OnValidate()
    {
        for(int i = 0; i < states.Length; i++)
        {
            states[i] = states[i].StateStringCleanUp();
        }
    }

    public bool TryGetState(string matchingState, out string state)
    {
        matchingState = matchingState.StateStringCleanUp();

        state = string.Empty;

        foreach (string item in states) 
        { 
            if(item == matchingState)
            {
                state = matchingState;
                return true;
            }
        }

        return false;
    }
}

public class InvalidStateException : Exception
{
    public InvalidStateException(string stateName) : base(message: "The state : " + "'" + stateName + "'" + " you input doesn't exist in the register. " +
                                                                   " Please check the spelling again.")
    {
    }
}

public class EmptyStateException : Exception
{
    public EmptyStateException() : base(message: "The state name can't be empty. Please type in a name. ")
    {
    }
}
