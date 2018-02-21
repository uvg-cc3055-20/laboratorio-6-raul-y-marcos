using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
//Raul Monzon y Marcos Gutierrez

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{   
   
    private VirtualButtonBehaviour virtualBtn;
    public Animator birdAnim;

    // Use this for initialization
    void Start()
    {
        virtualBtn = GetComponent<VirtualButtonBehaviour>();
        virtualBtn.RegisterEventHandler(this);

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
        birdAnim.SetTrigger("sing");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
    }
}
