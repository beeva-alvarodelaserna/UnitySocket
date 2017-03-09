using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class socketMessg : MonoBehaviour {
	void Start () {
		JSONObject j = new JSONObject (JSONObject.Type.OBJECT);
	    j.AddField ("nombre", "sergio");
	    j.AddField ("mensaje", "enviado desde unity");

        GameObject go = GameObject.Find("SocketIO");
        SocketIOComponent socket = go.GetComponent<SocketIOComponent>();
		socket.Emit("messagesReturn", j);
	}
	void Update () {
		JSONObject j = new JSONObject (JSONObject.Type.OBJECT);
	    j.AddField ("nombre", "sergio");
	    j.AddField ("mensaje", "enviado desde unity");

        GameObject go = GameObject.Find("SocketIO");
        SocketIOComponent socket = go.GetComponent<SocketIOComponent>();
		socket.Emit("messagesReturn", j);
	}
}
