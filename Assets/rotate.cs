using UnityEngine;
using System.Collections;
using SocketIO;

public class rotate : MonoBehaviour {
    
    float rotSpeed = 20;

    void OnMouseDrag() {

        float rotX = Input.GetAxis("Mouse X")*rotSpeed*Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y")*rotSpeed*Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotX);
        transform.RotateAround(Vector3.right, rotY);

        JSONObject j = new JSONObject (JSONObject.Type.OBJECT);
	    j.AddField ("origen", "device");
	    j.AddField ("objeto", gameObject.transform.name);	
        GameObject go = GameObject.Find("SocketIO");
        SocketIOComponent socket = go.GetComponent<SocketIOComponent>();
		socket.Emit("messagesReturn", j);
    }
}