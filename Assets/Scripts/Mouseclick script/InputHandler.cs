using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Transform _dragTarget;
    private Vector3   _offset;
    
    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Camera             mainCamera = Camera.main;
            List<RaycastHit2D> hits = new List<RaycastHit2D>(Physics2D.RaycastAll(mainCamera.ScreenToWorldPoint(Input.mousePosition), mainCamera.transform.forward));
            
            if(hits.Count > 0)
            {
                if(hits.Exists(hit => hit.transform.GetComponent<Controller>()))
                {
                    _dragTarget = hits.Find(hit => hit.transform.GetComponent<Controller>()).transform;
                    _offset     = _dragTarget.position - mainCamera.ScreenToWorldPoint(Input.mousePosition);
                    _offset.z   = 0f;
                }
            }
        }

        if(Input.GetMouseButtonUp(0))
        {
            _dragTarget = null;
        }

        if(Input.GetMouseButton(0) && _dragTarget)
        {
            Camera  mainCamera    = Camera.main;
            Vector3 inputPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            _dragTarget.position = new Vector3(inputPosition.x, inputPosition.y, _dragTarget.position.z) + _offset;
        }
    }
}
