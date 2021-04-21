using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChangeSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision){
        gameObject.transform.localScale += new Vector3(2, 2, 2);
    }
}
