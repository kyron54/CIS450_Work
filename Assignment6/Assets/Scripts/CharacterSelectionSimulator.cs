using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectionSimulator : MonoBehaviour
{
    public GameObject playerOneCap;
    public GameObject playerTwoCap;
    private MeshRenderer playerOneMesh;
    private MeshRenderer playerTwoMesh;
    public Material[] materials;

    PlayerOneCreator playerOne;
    PlayerTwoCreator playerTwo;

    // Start is called before the first frame update
    void Start()
    {
        playerOne = new PlayerOneCreator();
        playerTwo = new PlayerTwoCreator();

        playerOneMesh = playerOneCap.GetComponent<MeshRenderer>();
        playerTwoMesh = playerTwoCap.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerOne.SpawnFighter("Berserker");
            playerOneMesh.material = materials[0];
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            playerOne.SpawnFighter("Warrior");
            playerOneMesh.material = materials[1];
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            playerOne.SpawnFighter("Mage");
            playerOneMesh.material = materials[2];
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            playerOne.SpawnFighter("Rogue");
            playerOneMesh.material = materials[4];
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            playerOne.SpawnFighter("Archer");
            playerOneMesh.material = materials[3];
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            playerTwo.SpawnFighter("Berserker");
            playerTwoMesh.material = materials[0];
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            playerTwo.SpawnFighter("Warrior");
            playerTwoMesh.material = materials[1];
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            playerTwo.SpawnFighter("Mage");
            playerTwoMesh.material = materials[2];
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            playerTwo.SpawnFighter("Rogue");
            playerTwoMesh.material = materials[4];
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            playerTwo.SpawnFighter("Archer");
            playerTwoMesh.material = materials[3];
        }
    }
}
