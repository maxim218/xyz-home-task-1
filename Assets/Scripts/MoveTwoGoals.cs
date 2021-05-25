using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTwoGoals : MonoBehaviour {
    [SerializeField] private GameObject goalA = null;
    [SerializeField] private GameObject goalB = null;
    [SerializeField] private float speed = 0f;

    private bool _goalFlag = false;
    
    private void Update() {
        // choose target
        GameObject targetGameObject = _goalFlag ? goalA : goalB;
        
        // move to target
        transform.position = Vector2.MoveTowards(
            transform.position, 
            targetGameObject.transform.position, 
            speed * Time.deltaTime
        );

        // find distance and change target
        float distance = Vector2.Distance(transform.position, targetGameObject.transform.position);
        if (distance < 0.1f) _goalFlag = !_goalFlag;
    }
}
