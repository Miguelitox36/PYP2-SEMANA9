using GameJolt.API;
using GameJolt.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ReturnToMenu());
        UnlockTrophy();
    }

    void UnlockTrophy()
    {
        Trophies.TryUnlock(234421, (trophyResult) =>
        {
            GameJoltUI.Instance.ShowTrophies();
            StartCoroutine(ReturnToMenu());
        });
    }

    IEnumerator ReturnToMenu()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Menu");
    }
}
