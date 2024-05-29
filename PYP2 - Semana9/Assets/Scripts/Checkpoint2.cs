using GameJolt.API;
using GameJolt.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint2 : MonoBehaviour
{
    void Start()
    {
        UnlockTrophy();
    }

    void UnlockTrophy()
    {
        Trophies.TryUnlock(234427);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CheckpointObserver.Instance.NotifyCheckpointReached();
            SceneManager.LoadScene("Victory");
        }
    }
}
