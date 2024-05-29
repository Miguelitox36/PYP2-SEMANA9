using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointObserver : MonoBehaviour
{
    private static CheckpointObserver _instance;
    public static CheckpointObserver Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new CheckpointObserver();
            }
            return _instance;
        }
    }

    private List<ICheckpointHandler> _handlers = new List<ICheckpointHandler>();

    public void RegisterHandler(ICheckpointHandler handler)
    {
        if (!_handlers.Contains(handler))
        {
            _handlers.Add(handler);
        }
    }

    public void UnregisterHandler(ICheckpointHandler handler)
    {
        if (_handlers.Contains(handler))
        {
            _handlers.Remove(handler);
        }
    }

    public void NotifyCheckpointReached()
    {
        foreach (var handler in _handlers)
        {
            handler.OnCheckpointReached();
        }
    }
}
