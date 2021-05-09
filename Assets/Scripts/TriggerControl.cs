using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerControl : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            //Invoke("FallDown", 0.1f);
            FallDown();
        }
    }
    void FallDown()
    {
        
        Destroy(transform.parent.gameObject, 3f);
    }
}
