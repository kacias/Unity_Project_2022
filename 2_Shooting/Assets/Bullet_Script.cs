using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Script : MonoBehaviour
{
    public GameObject Hit_effect; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.0f, 0.0f, 0.1f);


        if (transform.position.z > 50.0f)
        {
            Destroy(gameObject, 0);
        }


    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Enemy_Tag")
        {
            Debug.Log("Collision!");
            Destroy(gameObject, 0);
            Destroy(other.gameObject, 0);
            Instantiate(Hit_effect, transform.position, Quaternion.identity); 

        }


    }
}
