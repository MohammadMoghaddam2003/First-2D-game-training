using UnityEngine;

public class PlayerControler : MonoBehaviour
{
[Range(1,10)]
public float speedMovement ;

public GameObject knife , grenades;

public Transform knifePlace;

public Sprite knifeImg , grenadesImg;

public SpriteRenderer weaponeImage;


    void Start() 
    {
        Time.timeScale = 1f;
    }
    
    void Update()
    {
        ChangeImageOfPlayer();
        Movement();
        Fire();       
    }

    void Movement ()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
           transform.Translate(-speedMovement*Time.deltaTime,0,0);
           if (transform.position.x < -7)
           {
               transform.position = new Vector3 (-7,transform.position.y,0);
           }
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
                transform.Translate(speedMovement*Time.deltaTime,0,0);
          if (transform.position.x > 7)
           {
               transform.position = new Vector3 (7,transform.position.y,0);
           }
        }
    }

    void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
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


    void ChangeImageOfPlayer()
    {
         if (Weapons._selectedWeapones == weaponesEnum.Knife)
        {
           weaponeImage.sprite = knifeImg;
           transform.localScale = new Vector3 (0.06220429f,-0.06220429f,0.06220429f);
        }
        else
        {
           weaponeImage.sprite = grenadesImg;
           transform.localScale = new Vector3 (.4f,.4f,.4f);
        }
    }
}
