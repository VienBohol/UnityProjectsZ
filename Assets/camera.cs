using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Use '=' to assign the new position to transform.position
        transform.position = transform.position + new Vector3(5f * Time.deltaTime, 0, 0);
    }
}
