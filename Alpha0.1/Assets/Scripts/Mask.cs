using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mask : MonoBehaviour
{
    [SerializeField] public static bool canUse;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (canUse)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
