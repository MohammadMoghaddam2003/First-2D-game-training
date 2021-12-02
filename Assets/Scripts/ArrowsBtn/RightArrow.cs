using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArrow : MonoBehaviour
{
   public GameObject player;

    void OnMouseDrag() 
    {
        player.transform.Translate(8*Time.deltaTime,0,0);

      if (player.transform.position.x > 7)
      {
        player.transform.position = new Vector3 (7,player.transform.position.y,0);
      }
    }
}
