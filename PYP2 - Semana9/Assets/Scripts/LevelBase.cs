using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LevelBase : MonoBehaviour, ICheckpointHandler
{
    public abstract void OnCheckpointReached();
}
