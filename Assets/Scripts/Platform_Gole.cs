using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Gole : MonoBehaviour
{

    public bool hasBlue;
    public bool hasPink;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player_BottomTrigger")) {
            string parentTag = collision.transform.parent.tag;
            if (parentTag == "Player_Blue")
                hasBlue = false;
            else if (parentTag == "Player_Pink")
                hasPink = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player_BottomTrigger"))
        {
            string parentTag = collision.transform.parent.tag;
            if (parentTag == "Player_Blue")
                hasBlue = true;
            else if (parentTag == "Player_Pink")
                hasPink = true;
        }
        if (hasPink && hasBlue)
            GameManager.instance.CompleteLevel();
    }
}
