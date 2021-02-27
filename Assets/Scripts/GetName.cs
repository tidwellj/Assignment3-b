
using UnityEngine.UI;
using UnityEngine;
public class GetName : MonoBehaviour
{
    
   
    static public string userIDs;
    

    // Start is called before the first frame update
    public void textr(string s)
    {
        userIDs = s;
       
        Debug.Log(userIDs);
        Debug.Log("Value Changed");

    }


}
