using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGrouping : MonoBehaviour
{
    public static ManagerGrouping managerGrouping;  //ManagerGrouping is singleton

    //These are GameEnvironmentGroup
    public ObjectPoolingManager opM;          //Provide Pooling function

    //These are Related with Player

    //These are UserActionGroup
    public KeyInputManager kiM;         //Action about Pressing a Key
    public InputBindingManager ibM;     //Make InputBinding

    //These are UIManagerGroup
    public UiWindowManager uwM;


    void Awake()    //for singleton
    {
        if (ManagerGrouping.managerGrouping == null)
        {
            ManagerGrouping.managerGrouping = this;
        }
    }
}