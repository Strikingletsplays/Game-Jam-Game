using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class obj : MonoBehaviour {

    [SerializeField]
    private Text pickUpText;
    public Image HUDCanvas;
    public Image Canvas;
    public GameObject Arrows;
    public GameObject End;
    public Image Screw, Cogg, Pipe;
    private bool pickUpAllowed;

    // Use this for initialization
    private void Start () {
        pickUpText.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	private void Update () {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Mikatroon"))
        {
            pickUpText.gameObject.SetActive(true);
            Canvas.gameObject.SetActive(true);
            pickUpAllowed = true;
        }        
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Mikatroon"))
        {
            pickUpText.gameObject.SetActive(false);
            Canvas.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        Destroy(gameObject);
        if (this.gameObject.name == "screw")
        {
            HUDCanvas.gameObject.SetActive(true);
            Screw.gameObject.SetActive(true);
        }
            
        if (this.gameObject.name == "gear")
        {
            HUDCanvas.gameObject.SetActive(true);
            Cogg.gameObject.SetActive(true);
        }
            
        if (this.gameObject.name == "pipe")
        {
            HUDCanvas.gameObject.SetActive(true);
            Pipe.gameObject.SetActive(true);
        }
            
        
        if (Screw.gameObject.activeSelf && Cogg.gameObject.activeSelf)
         Arrows.gameObject.SetActive(true);

        if (Screw.gameObject.activeSelf && Cogg.gameObject.activeSelf && Pipe.gameObject.activeSelf)
        {
            End.gameObject.SetActive(true);
 //           if (Input.GetKeyDown(KeyCode.Return))
 //               {
 //                  Application.Quit();
 //                   Debug.Log("trexi vre");
 //               }
        }
            
    }

}
