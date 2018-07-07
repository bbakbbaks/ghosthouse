using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
    public float m_fSpeed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CameraMove();
	}

    public void CameraMove()
    {
        float fVertical = Input.GetAxis("Vertical");
        float fHorizontal = Input.GetAxis("Horizontal");

        if (Mathf.Abs(fVertical) > 0 || Mathf.Abs(fHorizontal) > 0)
        {
            float fYTranslation = fVertical * m_fSpeed;
            float fXTranslation = fHorizontal * m_fSpeed;
            fXTranslation *= Time.deltaTime;
            fYTranslation *= Time.deltaTime;
            transform.Translate(fXTranslation, fYTranslation, 0);
        }

        Vector3 limitmap;
        limitmap.x = Mathf.Clamp(transform.position.x, -22, (float)16.6);
        limitmap.y = Mathf.Clamp(transform.position.y, (float)-23.2, (float)12.3);
        limitmap.z = Mathf.Clamp(transform.position.z, -10, 10);
        transform.position = limitmap;


    }

}
