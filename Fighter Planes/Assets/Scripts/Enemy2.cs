using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Enemy2Move();

    }

    void Enemy2Move()
    {
        enemy2.transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * 5f);

        if (enemy2.transform.position.x > 12f)
        {
            Destroy(this.gameObject);
        }
    }
}
