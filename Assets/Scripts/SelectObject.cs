using Microsoft.MixedReality.Toolkit.Experimental.Physics;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Physics;
using Microsoft.MixedReality.Toolkit.Utilities;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Serialization;


 
    public class SelectObject : MonoBehaviour
    {
    

        private void Start()
        {
    
        }
        private void Update()
        {
            //if (Input.GetMouseButtonDown(0))
            //{
            //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //    RaycastHit hit;
            //    if (Physics.Raycast(ray, out hit, 100))
            //        print("Hit name : " + hit.transform.name);

            //}
      
        }
        public void SetText(GameObject obj)
        {
            Debug.Log("Succes : " + obj.name);
        }
    }