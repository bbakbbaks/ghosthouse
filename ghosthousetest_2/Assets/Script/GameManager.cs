using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject ghost1;

    static GameManager m_cInstance;

    static public GameManager GetInstance()
    {
        return m_cInstance;
    }

    // Use this for initialization
    void Start () {
        m_cInstance = this;
    }
	
	// Update is called once per frame
	void Update () {
        PdGhost();
	}

    public void PdGhost()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitinfo = new RaycastHit();
        if (Physics.Raycast(ray, out hitinfo, 100.0f, 1 << LayerMask.NameToLayer("Default")))
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                GameObject ghost_1 = Instantiate(ghost1, hitinfo.point, Quaternion.identity);
            }
        }
    }
}
