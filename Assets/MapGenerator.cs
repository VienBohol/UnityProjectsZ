using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public GameObject ceiling1;
    public GameObject floor1;
    public GameObject ceiling;
    public GameObject floor;
    public GameObject RomanLegionnaire;

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be placed here
    }

    // Update is called once per frame
    void Update()
    {
        if (RomanLegionnaire.transform.position.x > floor.transform.position.x) {
            var tempCeiling = ceiling1;
            var tempFloor = floor1;
            ceiling1 = ceiling;
            floor1 = floor;
            tempCeiling.transform.position += new Vector3(40, 0, 0);
            tempFloor.transform.position += new Vector3(40, 0, 0);
            ceiling = tempCeiling;
            floor = tempFloor;
        }
    }
}
