using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrapper : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        if(this.gameObject.activeSelf)
        {
            Vector2 thisPosition =  transform.position;

            if (Camera.main.WorldToViewportPoint(transform.position).y > 1 || Camera.main.WorldToViewportPoint(transform.position).y < 0 )
            {
                thisPosition.y = -thisPosition.y;
            }
            if (Camera.main.WorldToViewportPoint(transform.position).x > 1 || Camera.main.WorldToViewportPoint(transform.position).x < 0 )
            {
                thisPosition.x = -thisPosition.x;
            
            }
            transform.position = thisPosition;
        }
    }
}
