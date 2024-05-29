using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJolt.UI;
using GameJolt.API;
using UnityEngine.SceneManagement;

public class MainSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameJoltUI.Instance.ShowSignIn((bool isSignedIn) =>
        {
            if (isSignedIn)
            {
                Debug.Log("Se logueo correctamente");
                UnlockTrophy();
            }
            else
            {
                Debug.Log("Ocurrio un error.");
            }
        });
    }
        
    void UnlockTrophy()
    {
        Trophies.TryUnlock(234419, (trophyResult) =>
        {
            SceneManager.LoadScene("Menu");
        });
    }
}
