using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private Player player; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.AddCoins();
                Destroy(this.gameObject);
            }
            else
            {
                Debug.Log("player is null");
            }
        }
    }
}
