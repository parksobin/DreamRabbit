using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject realgame;

    bool realstart;
    void Start()
    {
        tutorial.SetActive(true);
        realgame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tutorialend()
    {
        tutorial.SetActive(false);
        realgame.SetActive(true);
    }
}
