using System;
using System.Collections.Generic;
using SocketIOClient;
using SocketIOClient.Newtonsoft.Json;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using Newtonsoft.Json.Linq;

public class SecondApplication : MonoBehaviour
{
    public SocketIOUnity socket;

    [SerializeField]
    float timer = 0;
    [SerializeField]
    GameObject videoBumper;
    // Start is called before the first frame update
    void Start()
    {
        //var uri = new Uri("http://192.168.0.150:11100");
        var uri = new Uri(File.ReadAllText("C:/ip_config.txt"));
        socket = new SocketIOUnity(uri, new SocketIOOptions
        {
            Query = new Dictionary<string, string>
                {
                    {"token", "UNITY" }
                }
            ,
            EIO = 4
            ,
            Transport = SocketIOClient.Transport.TransportProtocol.WebSocket
        });
        socket.JsonSerializer = new NewtonsoftJsonSerializer();

        ///// reserved socketio events
        socket.OnConnected += (sender, e) =>
        {
            Debug.Log("socket.OnConnected");
        };
        socket.OnPing += (sender, e) =>
        {
            Debug.Log("Ping");
        };
        socket.OnPong += (sender, e) =>
        {
            Debug.Log("Pong: " + e.TotalMilliseconds);
        };
        socket.OnDisconnected += (sender, e) =>
        {
            Debug.Log("disconnect: " + e);
        };
        socket.OnReconnectAttempt += (sender, e) =>
        {
            Debug.Log($"{DateTime.Now} Reconnecting: attempt = {e}");
        };
        ////

        Debug.Log("Connecting...");
        socket.Connect();

    }

    // Update is called once per frame
    void Update()
    {

        //timer += Time.deltaTime;
        //if (Input.GetMouseButtonDown(0))
        //{
        //    // the player moved the mouse, reset the timer
        //    timer = 0.0f;
        //    videoBumper.SetActive(false);
        //}

        //if (timer > 6000000000f)
        //{
        //    // inactivity for a period has occured, do what you want
        //    videoBumper.SetActive(true);
        //}
    }

    public void showHome()
    {
        socket.Emit("home");
    }

    public void showAmar()
    {
        socket.Emit("amar");
    }

    public void showBergen()
    {
        socket.Emit("bergen");
    }

     public void showCaspia()
    {
        socket.Emit("caspia");
    }

    public void showDahlia()
    {
        socket.Emit("dahlia");
    }

    public void showTulip()
    {
        socket.Emit("tulip");
    }

    public void showPrime()
    {
        socket.Emit("prime");
    }

    public void showPride()
    {
        socket.Emit("pride");
    }

}
