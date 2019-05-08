using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

    [SerializeField] private Transform fruit;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Rigidbody fruitRigid;

    void Update()
    {
        //an to wumpa exei fugei makria,kane respawn
        if (Vector3.Distance(transform.position,fruit.position) > 150)
        {
            spawnF();
        }
    }

    void spawnF()
    {
        //to wumpa den epireazetai pleon apo varitita
        fruitRigid.isKinematic = true;

        //to wumpa tha gyrisei sto position tou spawnpoint
        fruit.transform.position = spawnPoint.transform.position;

        //to wumpa tha exei default rotation
        fruit.transform.rotation = Quaternion.identity;
    }
}
