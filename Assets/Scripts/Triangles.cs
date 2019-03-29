using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangles : MonoBehaviour
{
    public GameObject triangleObj;

    float xOffSet;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "Left")
        {
            xOffSet = 0.5f;
        }
        else
        {
            xOffSet = -0.5f;
        }

        initTriangles();
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void initTriangles()
    {
        foreach(Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        for (int i= 0; i < 12; i++)
        {
            int randomY = Random.Range(-6, 7);
            GameObject spike = (GameObject)Instantiate(triangleObj, new Vector2(transform.position.x + xOffSet, randomY * 1.5f), transform.rotation);
            spike.transform.SetParent(transform);
        }
        
        //Debug.Log(spike.transform.position);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        initTriangles();
    }
}
