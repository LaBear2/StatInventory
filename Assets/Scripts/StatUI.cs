using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatUI : MonoBehaviour
{
    public GameObject StatPanel;
    bool activeStat = false;

    private void Start()
    {
        StatPanel.SetActive(activeStat);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            activeStat = !activeStat;
            StatPanel.SetActive(activeStat);
        }
    }
}
