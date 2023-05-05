using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    //variables for our Arrow, cooldown and cooldown timer consequentially
    public Arrow arrow;
    public float shootInterval = 0.75f;
    public float shootTimer = 0;

    void Update()
    {
        //intil timer equals or less than 0 we reduce it every frame
        if (shootTimer > 0)
        {
            shootTimer -= Time.deltaTime;
        }
        //if we press LMB or touch screen
        if (Input.GetMouseButton(0) == true)
        {
             // find the mouse or the touch point on screen
            Vector2 mouseScreenPos = Input.mousePosition;
             // transform the fosition to a point on scene
            Vector2 mouseScenePos = Camera.main.ScreenToWorldPoint(mouseScreenPos);
              // find position of the crossbow
            Vector2 bowPos = transform.position;
             // direction we want to look
            Vector2 wantedDirection = mouseScenePos - bowPos;
             // default direction (we look right that is)
            Vector2 defaultDirection = Vector2.up;
             // variable for angle between where we're looking now and where we wanna look
            float angle = Vector2.SignedAngle(defaultDirection, wantedDirection);
             // variable for actual orientation tthat we wanna get
            Vector3 newEuler = new Vector3(0,0,angle);
                // rotate to the orientation we need
            transform.localEulerAngles = newEuler;
            // If timer is below or equals 0, we make an Arrow, where Crossbow is, pointing the way Crossbow does, and reset cooldown
            if (shootTimer <= 0)
            {
                Instantiate(arrow, transform.position, transform.rotation);
                shootTimer = shootInterval;

            }
        }

    }

}
