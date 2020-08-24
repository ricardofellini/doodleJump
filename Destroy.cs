using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    private GameObject myPlat;
    public GameObject bouncePowerPrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.gameObject.name.StartsWith("Platformer"))
        {

            if(Random.Range(1, 6) == 1)
            {

                Destroy(collision.gameObject);
                Instantiate(bouncePowerPrefab, new Vector2(Random.Range(-3.5f, 3.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            }
            else
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-3.5f, 3.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)));
            }
                

        }else if (collision.gameObject.name.StartsWith("PlatformerUpPower"))
        {

            if (Random.Range(1, 6) == 1)
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-3.5f, 3.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)));

            }
            else
            {
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-3.5f, 3.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f))), Quaternion.identity);
            }


        }



        //if(Random.Range(1, 6) > 1)
        //{
        //    myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);

      //  }
      //  else
     //   {

    //        myPlat = (GameObject)Instantiate(bouncePowerPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);
    //    }


        

      //  Destroy(collision.gameObject);
    }

}
