using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ThisThing Thaught = new ThisThing();
        Thaught.Value = 2;

        ThisThing Thinked = Thaught;
        Thaught.Value = 3;
        Thinked.Value = 4;
        Debug.Log(Thaught.Value);

        BeegBrain brain = new BeegBrain();
        brain.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

