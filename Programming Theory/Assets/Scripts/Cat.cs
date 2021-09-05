using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : AnimalBehaviour
{
    public override void Jump()
    {
        Debug.Log("Cat is Overriden");
        transform.Rotate(0,90.0f,0,Space.Self);
        base.Jump();
    }
}
