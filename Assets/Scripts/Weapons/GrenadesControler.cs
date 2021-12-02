using UnityEngine;

public class GrenadesControler : MonoBehaviour
{
  public GameObject explosion;
  Transform grenadesPlace;
  Sounds sound;
  float timer;


  void Start() 
  {
    grenadesPlace = GameObject.Find("Knife Place").GetComponent<Transform>();
    transform.position= Vector3.Lerp(transform.position,new Vector3(grenadesPlace.position.x,3.4f,7.980977e-10f),3);
    sound = GameObject.Find("Sounds").GetComponent<Sounds>();
    sound.KnifeShoot();
    Invoke("Explosion",7);
  }

  void Update()
  {
    timer = timer + Time.deltaTime;
    Destroy(gameObject,7);
    sound.Grenade();

  }

  void OnTriggerEnter2D(Collider2D Enemy) 
  {
    if (Enemy.CompareTag("Enemy") && timer >= 5)
    {
      sound.Grenade();
      Instantiate(explosion,transform.position,Quaternion.identity);
      Destroy(Enemy.gameObject);
      Destroy(gameObject);
      timer = 0;
    }    
  }

  void Explosion()
  {
    Instantiate(explosion,transform.position,Quaternion.identity);
  }
}
