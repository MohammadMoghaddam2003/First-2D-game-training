using UnityEngine;

public class KnifeControler : MonoBehaviour
{
  Sounds sound;


  void Start() 
  {
    sound = GameObject.Find("Sounds").GetComponent<Sounds>();
    sound.KnifeShoot();
  }

  void Update()
  {
    transform.Translate(0,20*Time.deltaTime,0,Space.World);
    Destroy(gameObject,6*Time.deltaTime);
  }

  void OnTriggerEnter2D(Collider2D Enemy) 
  {
    if (Enemy.CompareTag("Enemy"))
    {
      sound.FruitCrush();
      ScoreManager.score++;
      Destroy(Enemy.gameObject);
      Destroy(gameObject);
    }    
  }
}
