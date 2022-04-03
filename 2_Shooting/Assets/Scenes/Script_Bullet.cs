using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Bullet : MonoBehaviour
{
    public GameObject obj_effect;

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

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy_Tag")
        {
            Debug.Log("Collision with Enemy");
            Destroy(gameObject, 0);
            Destroy(col.gameObject, 0);
            Instantiate(obj_effect, transform.position, Quaternion.identity); 

        }

    }
}
