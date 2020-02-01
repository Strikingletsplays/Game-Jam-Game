using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawnCheck : MonoBehaviour
{

    public GameObject Arrows;
    void OnTriggerEnter2D()
    {
        if (!Arrows.gameObject.activeSelf)
        {
            SceneManager.LoadScene("lvl1");
        }
    }
}
