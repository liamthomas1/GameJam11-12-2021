using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Accessibility;
public class enemy : MonoBehaviour
{
    public GameObject Enemy;
    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(Enemy);
        }
        void OnCollisionEnter(Collision otherOBJ)
        {
            if (otherOBJ.gameObject.tag == "player")
            {
                Destroy(gameObject, .5f);
            } 
        }
    }

}
