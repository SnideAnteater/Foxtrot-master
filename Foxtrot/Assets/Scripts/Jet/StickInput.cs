using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Foxtrot
{
   public class StickInput : MonoBehaviour
   {
        public Joystick joystick;
        
        [Tooltip("When true, pulls input from the player.")]
         public bool isPlayer = false;
          [SerializeField]
          private Vector3 stickInput;
          [SerializeField]
          private float throttle;

          public float Pitch
          {
             get { return stickInput.x; }
             set { stickInput.x = value; }
          }
          public float Roll
          {
             get { return stickInput.z; }
             set { stickInput.z = value; }
          }
          public float Yaw
          {
             get { return stickInput.y; }
             set { stickInput.y = value; }
          }
          /// <summary>
          /// Pitch and Roll represented as a Vector3, in that order.
          /// </summary>
          public Vector3 Combined
          {
             get { return stickInput; }
             set { stickInput = value; }
          }

          [SerializeField]
          public float Throttle
          {
             get { return throttle; }
             set { throttle = value; }
          }

        public const float ThrottleNeutral = 0.33f;
        public const float ThrottleMin = 0.1f;
        public const float ThrottleMax = 1f;
        public const float ThrottleSpeed = 2f;
        public float target =  ThrottleNeutral;
          

        public void FlyUP()
        {
            target = ThrottleMax;
        }
        public void FlyDown()
        {
            target = ThrottleMin;
        }

        public void Reset()
        {
            target = ThrottleNeutral;
        }

        public void Update()
          {
             if (isPlayer)
             {
                Pitch = joystick.Vertical;
                Roll = -(joystick.Horizontal);
                throttle = Mathf.MoveTowards(throttle, target, ThrottleSpeed * Time.deltaTime);
             }
          }
       }
}