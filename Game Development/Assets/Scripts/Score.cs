//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        //converts the number of the Z position into a string,
        scoreText.text = player.position.z.ToString("0");
    }
}
