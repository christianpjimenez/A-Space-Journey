using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Right : MonoBehaviour
{
     public void OnPointEnter ()
    {
        Destroy(gameObject);
    }

}
