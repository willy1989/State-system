using UnityEngine;

public class StateHolder : MonoBehaviour
{
    [SerializeField] private string startState;

    private string currentState;

    [SerializeField] private StateRegister stateRegister;

    private void Awake()
    {
        ChangeState(stateName: startState);
    }

    public void ChangeState(string stateName)
    {
        stateName = stateName.StateStringCleanUp();

        if (stateName == string.Empty)
        {
            throw new EmptyStateException();
        }

        else if (stateRegister.TryGetState(matchingState: stateName, out string newState))
        {
            currentState = newState;
        }

        else
        {
            throw new InvalidStateException(stateName: stateName);
        } 
    }
}
