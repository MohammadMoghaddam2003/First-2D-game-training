using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBtn : MonoBehaviour
{
    public GameObject knife , grenades;

    public Transform knifePlace;


   public void OnClick()
   {
     if (Weapons._selectedWeapones == weaponesEnum.Knife)
     {
          Instantiate(knife,knifePlace.transform.position,Quaternion.identity);
     }
     else
     {
          Instantiate(grenades,knifePlace.transform.position,Quaternion.identity);
     }
   }
}
