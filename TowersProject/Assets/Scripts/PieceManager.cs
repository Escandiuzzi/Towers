using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager : MonoBehaviour {

    public GameObject[] pieces;
    public GameObject actualPiece;
    public float value;
    public float gValue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (actualPiece == null)
        {
            var rand = Random.Range(0,7);
            actualPiece = Instantiate(pieces[rand], transform.position, Quaternion.identity) as GameObject;
            actualPiece.GetComponent<InputScript>().value = value;
            actualPiece.GetComponent<InputScript>().gValue = gValue;
        }

        else if (actualPiece)
        {
            if (actualPiece.GetComponent<InputScript>().GetStatus() == false)
            {
                actualPiece = null;
            }


        }

  

	}
}
