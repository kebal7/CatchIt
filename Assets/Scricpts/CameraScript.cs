using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public SpriteRenderer backround;

    float orthoSize;
    // Start is called before the first frame update
    void Start()
    {
        orthoSize = backround.bounds.size.x * Screen.height /Screen.width * 0.5f;

        Camera.main.orthographicSize = orthoSize;
    }


}
