using GameJolt.UI;
using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScene : MonoBehaviour
{
    void Start()
    {
        UnlockTrophy();
    }

    void UnlockTrophy()
    {
        Trophies.TryUnlock(234424, (trophyResult) =>
        {
            GameJoltUI.Instance.ShowTrophies();           
        });        
    }

    IEnumerator ReturnToMenu()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Menu");
    }
}
