using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject ShortPanel, LengthPanel, shortpanelobjects, lengthpanelobjects;

    [HideInInspector]
    public List<GameObject> Objs;
    [HideInInspector]
    public List<GameObject> ListObjs;

    private void Start()
    {
        
    }

    public void OnShortArrowBtnClicked()
    {
        ShortPanel.SetActive(false);
        LengthPanel.SetActive(true);
    }

    public void OnLengthArrowBtnClicked()
    {
        ShortPanel.SetActive(true);
        LengthPanel.SetActive(false);
        //setshortpanelobjects();
    }

    public void OnItemSelection(int n)
    {
        //ListObjs.Clear();
        //Objs.Clear();

        //foreach(Transform t in lengthpanelobjects.transform)
        //{
        //    ListObjs.Add(t.transform.gameObject);
        //}

        //Debug.Log(n);

        //for (int i = -1; i < 4; i++)
        //{
        //    Objs.Add(ListObjs[n-i]);
        //}

        //for (int i = 0; i < Objs.Count; i++)
        //{
        //    Debug.Log(Objs[i].name);
        //}
    }

    void setshortpanelobjects()
    {
        foreach (Transform t in shortpanelobjects.transform)
        {
            Destroy(t.transform.gameObject);
        }

        for (int i = Objs.Count - 1; 0 <= i; i--)
        {
            Debug.Log(i);
            Objs[i].transform.SetParent(shortpanelobjects.transform);
        }
    }
}
