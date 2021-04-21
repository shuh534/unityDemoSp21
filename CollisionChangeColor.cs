using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision){
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.green;
    }
}
