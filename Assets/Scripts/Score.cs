using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Transform player;
    public Text scoreText;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }
    void Update()
    {
        scoreText.text = (player.position.z + 47.5).ToString("0");
    }
}
