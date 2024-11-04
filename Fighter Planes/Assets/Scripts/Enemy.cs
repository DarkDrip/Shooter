using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();


    }

    void EnemyMove()
    {
        enemy.transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3f);

        if (enemy.transform.position.y < -8.5f)
        {
            Destroy(this.gameObject);
        }
    }

}
