using UnityEngine;
using System.Collections;
using SocketIO;

public class touch : MonoBehaviour {

	void OnMouseDown() {

        JSONObject j = new JSONObject (JSONObject.Type.OBJECT);
	    j.AddField ("origen", "device");
	    j.AddField ("objeto", gameObject.transform.name);	
        GameObject go = GameObject.Find("SocketIO");
        SocketIOComponent socket = go.GetComponent<SocketIOComponent>();
		socket.Emit("messagesReturn", j);
    }
}
