using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrosshairFX : MonoBehaviour
{
    PlayerController playerController;
    GameObject player;
    Image crosshair;

    public Color grappleColor;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<PlayerController>();
        crosshair = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController.canGrapple)
        {
            crosshair.color = grappleColor;
        }
        else
        {
            crosshair.color = Color.white;
        }
    }
}
