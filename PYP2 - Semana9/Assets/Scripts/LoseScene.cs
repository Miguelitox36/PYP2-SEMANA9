using GameJolt.UI;
using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScene : MonoBehaviour
{
    void Start()
    {
        UnlockTrophy();
    }

    void UnlockTrophy()
    {
        Trophies.TryUnlock(234426, (trophyResult) =>
        {
            StartCoroutine(ReturnToMenu());
        });
        Trophies.TryUnlock(234423, (trophyResult) =>
        {
            StartCoroutine(ReturnToMenu());
        });
    }

    IEnumerator ReturnToMenu()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Menu");
    }
}
