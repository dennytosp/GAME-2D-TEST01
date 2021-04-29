using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class listuser : MonoBehaviour
{
    public GameObject Rownew;
    string URL="http://localhost/test1/showuser.php";
    void Start()
    {
        getdata();
    }
    public void getdata(){
        StartCoroutine(connect());   
    }
    IEnumerator connect()
    {
        WWWForm wf = new WWWForm();
        WWW w = new WWW(URL,wf);
        yield return w;
        string data = w.text;
        
        // khai bao mang de luu tru
        string[] a = new string[]{};
        a = data.Split(',');
        // mang a co 4 phan tu
        for(int i=0; i< (a.Length)-1; i++) {

            string line=a[i]  ; 

            string[] b = new string[]{};
            b = line.Split('-');
            // mang b co 5 phan tu
            GameObject g = (GameObject)Instantiate(Rownew);
              g.transform.SetParent(this.transform);
              g.transform.Find("id").GetComponent<Text>().text=b[0];
              g.transform.Find("username").GetComponent<Text>().text=b[1];
              g.transform.Find("point").GetComponent<Text>().text=b[2];

        }
        
    }
}
