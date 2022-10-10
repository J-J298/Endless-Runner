using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider2D collision)
    {   
        if (collision.gameObject.tag == "CleanUp")
        {
            Destroy(collision.gameObject);
        }
    }
}
