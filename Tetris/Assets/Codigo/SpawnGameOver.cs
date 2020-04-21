using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGameOver : MonoBehaviour
{
    public GameObject[] Gameover;

    // Start is called before the first frame update
    void Start()
    {
        //NewGameOver();
    }

    public void NewGameOver()
    {
        Instantiate(Gameover[Random.Range(0, Gameover.Length)], transform.position, Quaternion.identity);
        
    }
}
