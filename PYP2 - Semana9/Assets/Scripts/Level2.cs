using GameJolt.API;
using GameJolt.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : LevelBase
{
    void Start()
    {
        CheckpointObserver.Instance.RegisterHandler(this);
        UnlockTrophy();
    }

    void UnlockTrophy()
    {
        Trophies.TryUnlock(234422, (trophyResult) =>
        {
            GameJoltUI.Instance.ShowTrophies();
        });
    }

    void OnDestroy()
    {
        CheckpointObserver.Instance.UnregisterHandler(this);
    }   

    public override void OnCheckpointReached()
    {        
        bool playerWon = true; 
        if (playerWon)
        {
            SceneManager.LoadScene("Victory");
        }
        else
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
