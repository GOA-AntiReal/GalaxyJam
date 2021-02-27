using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilemapController : MonoBehaviour
{
    public Grid grid;
    public GameObject instantiateObject;
    public List<GameObject> unitList;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWOrldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float y = Mathf.Round(mouseWOrldPos[1]);
            float x = Mathf.Round(mouseWOrldPos[0]);
            if (y % 2 == 1 || y % 2 == -1)
            {
                x += 0.5f;
            }
            float endY = (y * 0.75f) + 0.35f;
            GameObject spawnedObject = Instantiate(instantiateObject);
            spawnedObject.transform.position = new Vector3(x, endY, transform.position.z);
            unitList.Add(spawnedObject);
        }
    }
}
