using UnityEngine;

public class DamageControler : MonoBehaviour
{
    public GameObject losePanel;
    public GameObject[] damage;
    Sounds sound;
    int indexOfDamage;


    void Start() 
    {
        sound = GameObject.Find("Sounds").GetComponent<Sounds>();
    }
    

    void OnTriggerEnter2D(Collider2D enemy) 
    {
        if (enemy.CompareTag("Enemy"))    
        {
            Destroy(enemy.gameObject);
            Destroy(damage[indexOfDamage]);
            indexOfDamage++;

            if (indexOfDamage == 3)
            {
                losePanel.SetActive(true);
                sound.PlayerLose();
                Time.timeScale = 0;
            }
        }
    }
}
