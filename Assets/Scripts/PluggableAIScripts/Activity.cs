using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Activity : ScriptableObject
{
    public abstract void Act(StateController controller);
}
