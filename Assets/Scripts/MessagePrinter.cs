using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagePrinter : MonoBehaviour
{
    [SerializeField] private StateSystem stateSystem;

    private void Start()
    {
        PrintMessages();

        // Changing to an unregistered state throws an error
        stateSystem.ChangeCurrentState(state: "stateD");
    }

    private void PrintMessages()
    {
        if (stateSystem.CurrentState == "welcome")
            Debug.Log("Welcome to this app");

        else if (stateSystem.CurrentState == "update")
            Debug.Log("Downloading the update now.");

        else if (stateSystem.CurrentState == "goodbye")
            Debug.Log("Thanks you for using this app. See you soon.");
    }
}
