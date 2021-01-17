using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{

    public bool rtbtnHolded,ltbtnHolded;

    
    public void WhenRightButtonHolded()
    {
        rtbtnHolded = true;
    }

    public void WhenLeftButtonHolded()
    {
        ltbtnHolded = true;
    }

    public void WhenRightButtonReleased()
    {
        rtbtnHolded = false;
    }

    public void WhenLeftButtonReleased()
    {
        ltbtnHolded = false;
    }

}
