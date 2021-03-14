using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public bool ifactive = false;
    public bool keepactive = false;
    public float endX;
    public float endY;
    public int moveTick = 0;

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (ifactive)
        {
            moveTick += 1;
            if (moveTick == 10)
            {
                moveTick = 0;
                if (Random.Range(1.0f, 2.0f) < 1.5f)
                {

                    if (transform.position.x < endX)
                    {
                        transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
                    }
                    if (transform.position.x > endX)
                    {
                        transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);
                    }
                    if (transform.position.y < endY)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y + 0.75f, transform.position.z);
                    }
                    if (transform.position.y > endY)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y - 0.75f, transform.position.z);
                    }
                }
                if (Random.Range(1.0f, 2.0f) > 1.5f)
                {
                    if (transform.position.y < endY)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y + 0.75f, transform.position.z);
                    }
                    if (transform.position.y > endY)
                    {
                        transform.position = new Vector3(transform.position.x, transform.position.y - 0.75f, transform.position.z);
                    }
                    if (transform.position.x < endX)
                    {
                        transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
                    }
                    if (transform.position.x > endX)
                    {
                        transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);
                    }
                }
                if (transform.position.y == endY && transform.position.x == endX)
                {
                    ifactive = false;
                }
            }
        }
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ifactive = true;
            GameObject tileMapImport = GameObject.Find("Tilemap");
            TilemapController tileMapScript = tileMapImport.GetComponent<TilemapController>();
            List<GameObject> importList = tileMapScript.unitList;
            Vector3 mouseWOrldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float y = Mathf.Round(mouseWOrldPos[1]);
            endX = Mathf.Round(mouseWOrldPos[0]);
            if (y % 2 == 1 || y % 2 == -1)
            {
                endX += 0.5f;
            }
            endY = (y * 0.75f) + 0.35f;
        }
        
        if (Input.GetMouseButtonDown(0))
        { 
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hi");
            }
        }
    }
}
