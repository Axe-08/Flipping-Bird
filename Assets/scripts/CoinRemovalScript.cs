using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRemovalScript : MonoBehaviour
{
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Destroy(gameObject);
        }
    }
}
