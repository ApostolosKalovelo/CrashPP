using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeThrow : MonoBehaviour {
    Vector2 startPos, endPos, direction;
    float touchTimeStart, touchTimeFinish, timeInterval;
    Rigidbody rb;
    bool flag = false;
    public GameObject fruit;
    public GameObject crash;

    //allakse ti metavliti apo to unity
    [SerializeField]
    float throwForce = 140f;

    //allakse ti metavliti apo to unity
    [SerializeField]
    float throwForceXY = 1f;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody> ();
      
	}

    // Update is called once per frame
    void Update()
    {

        //me tin parodo tou kathe frame,gyrna to fruit ston aksona X
        transform.Rotate(10, 0, 0);

        //an agkikse othoni,pare ti thesi kai to xrono
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchTimeStart = Time.time;
            startPos = Input.GetTouch(0).position;
        }

        //afou stamatise h kinisi,pare to xrono kai ti thesi
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            touchTimeFinish = Time.time;

            //diarkeia
            timeInterval = touchTimeFinish - touchTimeStart;

            endPos = Input.GetTouch(0).position;

            //katefthinsi
            direction = startPos - endPos;

            //to fruit tha epireazetai pleon apo ti varitita
            rb.isKinematic = false;

            //vale mia dinami sto frouto analogi me ta parapanw
            rb.AddForce(-direction.x*throwForceXY,-direction.y*throwForceXY, throwForce/timeInterval);

            //exei pragmatopoihthei kinisi
            flag = true;
            
        }
        Debug.Log(Vector3.Distance(crash.transform.position, fruit.transform.position));
        //an exei yparksei kinisi kai h apostasi Wumpa kai Crash einai midamini
        if (Vector3.Distance(crash.transform.position, fruit.transform.position) < 28 && flag)
        {
            //prosthese mia akomi dinami gia na fainetai megaliteri h ormi stin krousi
            rb.AddForce(throwForceXY,throwForceXY, 10* throwForce / timeInterval);
            flag = false;
        }

    }
}
