using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameObject apple;
    public GameObject watermelone;
    public Slider hardness;
    float timer;
    float hardnessManager;
    float validateHardness;


    void Update()
    {
        timer += Time.deltaTime;

        if (hardness.value < 0.8f)
        {
            hardnessManager = .8f;
        }
        else
        {
            hardnessManager = hardness.value;
        }
        if (timer > hardnessManager)
        {
            EnemyMaker();
            timer = 0;
        }
    }

    void FixedUpdate() 
    {
        hardness.value -= 0.00001f;
    }


    void EnemyMaker()
    {
        int enemyChanger = Random.Range(-10,10);
        float enemyAttach = Random.Range(-7,7);

        if (enemyChanger>0)
            {
                Instantiate(apple,transform.position=new Vector3(enemyAttach,4.50f,0),Quaternion.identity);
            }
            else if (enemyChanger <0)
            {
                Instantiate(watermelone,transform.position=new Vector3(enemyAttach,4.50f,0),Quaternion.identity);
            }
    }

    public void OnPointerDown()
    {
        validateHardness = hardness.value;
    }

    public void OnPointerUp() 
    {
        if (validateHardness < hardness.value)
        {
           hardness.value = validateHardness;
        }
    }
}
