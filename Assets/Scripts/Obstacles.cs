using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public GameObject triangleObj;
    // Start is called before the first frame update
    void Start()
    {
        initObstacles();
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void initObstacles()
    {
        foreach(Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        for (int i= 0; i < 12; i++)
        {
            int randomY = Random.Range(-6, 7);
            GameObject spike = (GameObject)Instantiate(triangleObj, new Vector2(transform.position.x + 0.5f, randomY * 1.5f), Quaternion.identity);
            spike.transform.SetParent(transform);
        }
        
        //Debug.Log(spike.transform.position);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        initObstacles();
    }
}
