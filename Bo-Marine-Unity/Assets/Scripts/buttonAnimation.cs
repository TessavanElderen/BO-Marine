using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void PressButton()
    {
        GetComponent<Animation>().Play("NewGameButton");
    }
}
