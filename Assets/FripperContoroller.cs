using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperContoroller : MonoBehaviour
{
       
        private HingeJoint myHingeJoint;

      
        private float defaultAngle = 20;
        
        private float flickAngle = -20;

        
        void Start ()
        {
                
                this.myHingeJoint = GetComponent<HingeJoint>();

                
                SetAngle(this.defaultAngle);
        }

        
        void Update ()
        {

                
                if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
                {
                        SetAngle (this.flickAngle);
                }
                
                if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
                {
                        SetAngle (this.flickAngle);
                }

                
                if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
                {
                        SetAngle (this.defaultAngle);
                }
                if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
                {
                        SetAngle (this.defaultAngle);
                }
        }

        
        public void SetAngle (float angle)
        {
                JointSpring jointSpr = this.myHingeJoint.spring;
                jointSpr.targetPosition = angle;
                this.myHingeJoint.spring = jointSpr;
        }
    
}
