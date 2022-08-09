using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 15)
        {
            Destroy(gameObject);
        }
    }
}
