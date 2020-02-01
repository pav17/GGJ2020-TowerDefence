using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarScript : MonoBehaviour
{
    public AvatarState state; 
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case AvatarState.INACTIVE:
                UpdateInactive();
                break;
            case AvatarState.ACTIVE:
                UpdateActive();
                break;
            case AvatarState.BUILDING:
                UpdateBuilding();
                break;
            default:
                break;
        }
    }

    void UpdateInactive()
    {
    }

    void UpdateActive()
    {
        Vector2 movedirection = new Vector2();
        movedirection.x = Input.GetAxis("Horizontal");
        movedirection.y = Input.GetAxis("Vertical");
        movedirection = movedirection.normalized;

        transform.Translate(movedirection * speed * Time.deltaTime);
    }

    void UpdateBuilding()
    {
    }
}

public enum AvatarState
{
    INACTIVE,
    ACTIVE,
    BUILDING
}