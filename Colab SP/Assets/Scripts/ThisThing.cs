using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisThing
{
    public int Value = 0;
	public void Start()
    {
        float Yeah = 0.2f + 0.1f;
        Debug.Log(Yeah);
        float No = Yeah;
        Yeah = 0.4f;
        Debug.Log(No);
    }

}

public class BeegBrain : ThisThing
{

}