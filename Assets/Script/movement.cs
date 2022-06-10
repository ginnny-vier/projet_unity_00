using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed_y = 1f;
    private float fact = -1f;
    public float min_pos  = 0;
    public GameObject max_pos;


    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {

        transform.position += new Vector3(0, speed_y * fact, 0) * Time.deltaTime;

            if (transform.position.y <= min_pos){
                fact = 1f;
            }

            else if (max_pos != null &&  transform.position.y >= max_pos.transform.position.y){
                fact = -1f;
            }

    }

    }

    // .transform.position.y => permet de recup la position d



