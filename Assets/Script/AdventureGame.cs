using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField]  Text textComponent;
    [SerializeField] State startingState;

    State currentState;

    void Start()
    {
        currentState = startingState;

        textComponent.text = currentState.GetStateStory();

    }


    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = currentState.GetNextStates();
       

        for(int i=0; i<nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1+i))
            {
                currentState = nextStates[i];
            }
        }

        textComponent.text = currentState.GetStateStory();

        //For'da yapıyoruz bu işlemi zati
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    currentState = nextStates[0];
        //}


        //else if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    currentState = nextStates[1];
        //}

        //else if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    currentState = nextStates[2];
        //}

        //else if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    currentState = nextStates[3];
        //}


    }
}
