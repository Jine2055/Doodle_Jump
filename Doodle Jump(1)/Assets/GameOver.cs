using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
     public Text overText;
     void OnTriggerEnter2D(Collider2D collision)
     {
        if(collision.tag == "Doodler")
        {
            overText.text = "Game Over";     
		}
	 }
}
