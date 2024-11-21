using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsScript : MonoBehaviour
{
    public Text pointsUI;
    public Text recordUI;

    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (points > PlayerPrefs.GetInt("Record"))
        {
            PlayerPrefs.SetInt("Record", points);
        }
        pointsUI.text = "Pontuacao: " + points;
        recordUI.text = "Recorde: " + PlayerPrefs.GetInt("Record");
    }
}
