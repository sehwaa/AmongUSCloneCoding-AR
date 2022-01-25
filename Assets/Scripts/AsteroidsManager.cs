using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AsteroidsManager : MonoBehaviour
{
    TextMeshProUGUI Score;

    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.Find("MissionText_Weapons").transform.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MultipleImageTracker.clearAsteroid == 5)
        {
            Score.color = Color.green;
        }

        Score.text = "무기고 - 소행성 파괴(" + MultipleImageTracker.clearAsteroid + "/5)";
    }

}
