using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip knifeShoot , fruitCrush , playerLose , grenad;


    public void KnifeShoot()
    {
        audioSource.clip=knifeShoot;
        audioSource.Play();
    }

    public void FruitCrush()
    {
        audioSource.clip = fruitCrush;
        audioSource.Play();
    }

    public void PlayerLose ()
    {
        audioSource.clip = playerLose;
        audioSource.Play();
    }

     public void Grenade ()
    {
        audioSource.clip = grenad;
        audioSource.Play();
    }
}
