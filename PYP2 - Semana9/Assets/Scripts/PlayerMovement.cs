using GameJolt.API;
using GameJolt.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private bool hasMoved = false;

    void Update()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (moveDirection != Vector3.zero)
        {
            transform.position += moveDirection * moveSpeed * Time.deltaTime;

            if (!hasMoved)
            {
                hasMoved = true;
                UnlockTrophy();
            }
        }
    }

    void UnlockTrophy()
    {
        Trophies.TryUnlock(234425, (trophyResult) =>
        {
            GameJoltUI.Instance.ShowTrophies();            
        });
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Lose");
        }
    }
}
