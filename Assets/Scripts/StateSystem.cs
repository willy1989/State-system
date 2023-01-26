using System;
using UnityEngine;

public class StateSystem : MonoBehaviour
{
    public string CurrentState => currentState;

    [SerializeField] private string currentState;

    [SerializeField] private StateRegister stateRegister;

    private void Awake()
    {
        if(currentState == null ||currentState == string.Empty)
        {
            throw new ArgumentException("You didn't set up the current state's value for " + gameObject.name +
                                        " . " + "Please do so before running the application.");
        }
    }

    public void ChangeCurrentState(string state)
    {
        state = StringCleanUp(state);

        if (stateRegister.IsStateInRegister(state) == true)
            currentState = state;
    }

    private string StringCleanUp(string state)
    {
        return state.ToLower().Trim();
    }
}
