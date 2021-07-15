using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonCtrl : MonoBehaviour
{
    GameObject turretObj;
    GameObject misGizmosObj;
    Transform pos;
    Transform mPos;

    public GameObject missile;
    bool shootOk = true;


    // Start is called before the first frame update
    void Start()
    {
        turretObj = GameObject.Find("Turret");
        pos = turretObj.GetComponent<Transform>();

        misGizmosObj = GameObject.Find("MisGizmos");
        mPos = misGizmosObj.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(pos.transform.position, pos.transform.forward * 12, Color.red);

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * 3 * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.forward * -3 * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * 3 * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * 3 * Time.deltaTime);

        if (shootOk)
        {
            if (Input.GetKey(KeyCode.Space))
                StartCoroutine("ShootMissile");
        }
        /*
        RaycastHit hit;
        if (Input.GetKey(KeyCode.Space))
        {
            if (Physics.Raycast(pos.transform.position, pos.transform.forward, out hit, 12.0f))
                Debug.Log(hit.collider.gameObject.name);
            else
                Debug.Log("Nothing");
        }
        */
    }

    IEnumerator ShootMissile()
    {
        shootOk = false;
        mPos = misGizmosObj.GetComponent<Transform>();
        GameObject obj = Instantiate(missile, mPos.position, mPos.rotation);
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        rb.AddForce(pos.transform.forward * 500);

        yield return new WaitForSeconds(0.5f);
        shootOk = true;
    }

}
