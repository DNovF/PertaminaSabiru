using System;
using System.Collections.Generic;
using SocketIOClient;
using SocketIOClient.Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json.Linq;
using System.IO;

public class MainApplication : MonoBehaviour
{
    public SocketIOUnity socket;

    public InputField EventNameTxt;
    public InputField DataTxt;
    public Text ReceivedText;

    public GameObject objectToSpin;
    [SerializeField]
    GameObject home;
    [SerializeField]
    GameObject amar;
    [SerializeField]
    GameObject bergen;
    [SerializeField]
    GameObject caspia;
    [SerializeField]
    GameObject dahlia;
    [SerializeField]
    GameObject tulip;
    [SerializeField]
    GameObject prime;
    [SerializeField]
    GameObject pride;

    // Start is called before the first frame update
    void Start()
    {
        //TODO: check the Uri if Valid.
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

        socket.On("home", (response) =>
        {
            Debug.Log(response);
            UnityThread.executeInUpdate(() => {
                home.SetActive(true);
                amar.SetActive(false);
                bergen.SetActive(false);
                caspia.SetActive(false);
                dahlia.SetActive(false);
                tulip.SetActive(false);
                prime.SetActive(false);
                pride.SetActive(false);
                
            });
        });

        socket.On("amar", (response) =>
        {
            Debug.Log(response);
            UnityThread.executeInUpdate(() => {
                home.SetActive(true);
                amar.SetActive(true);
                bergen.SetActive(false);
                caspia.SetActive(false);
                dahlia.SetActive(false);
                tulip.SetActive(false);
                prime.SetActive(false);
                pride.SetActive(false);

            });
        });

        socket.On("bergen", (response) =>
        {
            Debug.Log(response);
            UnityThread.executeInUpdate(() => {
                home.SetActive(true);
                amar.SetActive(false);
                bergen.SetActive(true);
                caspia.SetActive(false);
                dahlia.SetActive(false);
                tulip.SetActive(false);
                prime.SetActive(false);
                pride.SetActive(false);

            });
        });

        socket.On("caspia", (response) =>
        {
            Debug.Log(response);
            UnityThread.executeInUpdate(() => {
                home.SetActive(true);
                amar.SetActive(false);
                bergen.SetActive(false);
                caspia.SetActive(true);
                dahlia.SetActive(false);
                tulip.SetActive(false);
                prime.SetActive(false);
                pride.SetActive(false);

            });
        });

        socket.On("dahlia", (response) =>
        {
            Debug.Log(response);
            UnityThread.executeInUpdate(() => {
                home.SetActive(true);
                amar.SetActive(false);
                bergen.SetActive(false);
                caspia.SetActive(false);
                dahlia.SetActive(true);
                tulip.SetActive(false);
                prime.SetActive(false);
                pride.SetActive(false);

            });
        });

        socket.On("tulip", (response) =>
        {
            Debug.Log(response);
            UnityThread.executeInUpdate(() => {
                home.SetActive(true);
                amar.SetActive(false);
                bergen.SetActive(false);
                caspia.SetActive(false);
                dahlia.SetActive(false);
                tulip.SetActive(true);
                prime.SetActive(false);
                pride.SetActive(false);

            });
        });

        socket.On("prime", (response) =>
        {
            Debug.Log(response);
            UnityThread.executeInUpdate(() => {
                home.SetActive(true);
                amar.SetActive(false);
                bergen.SetActive(false);
                caspia.SetActive(false);
                dahlia.SetActive(false);
                tulip.SetActive(false);
                prime.SetActive(true);
                pride.SetActive(false);

            });
        });

        socket.On("pride", (response) =>
        {
            Debug.Log(response);
            UnityThread.executeInUpdate(() => {
                home.SetActive(true);
                amar.SetActive(false);
                bergen.SetActive(false);
                caspia.SetActive(false);
                dahlia.SetActive(false);
                tulip.SetActive(false);
                prime.SetActive(false);
                pride.SetActive(true);

            });
        });


        //socket.OnUnityThread("kalimantan", (data) =>
        //{
        //    kalimantan.SetActive(true);
        //});

        ReceivedText.text = "";
        socket.OnAnyInUnityThread((name, response) =>
        {
            Debug.Log(response);
            timer = 0.0f;
            videoBumper.SetActive(false);
            //ReceivedText.text += "Received On " + name + " : " + response.GetValue().GetRawText() + "\n";
        });
    }

    public void EmitTest()
    {
        string eventName = EventNameTxt.text.Trim().Length < 1 ? "hello" : EventNameTxt.text;
        string txt = DataTxt.text;
        if (!IsJSON(txt))
        {
            socket.Emit(eventName, txt);
        }
        else
        {
            socket.EmitStringAsJSON(eventName, txt);
        }
    }

    public static bool IsJSON(string str)
    {
        if (string.IsNullOrWhiteSpace(str)) { return false; }
        str = str.Trim();
        if ((str.StartsWith("{") && str.EndsWith("}")) || //For object
            (str.StartsWith("[") && str.EndsWith("]"))) //For array
        {
            try
            {
                var obj = JToken.Parse(str);
                return true;
            }
            catch (Exception ex) //some other exception
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public void EmitSpin()
    {
        socket.Emit("spin");
    }

    public void EmitClass()
    {
        TestClass testClass = new TestClass(new string[] { "foo", "bar", "baz", "qux" });
        TestClass2 testClass2 = new TestClass2("lorem ipsum");
        socket.Emit("class", testClass2);
    }

    // our test class
    [System.Serializable]
    class TestClass
    {
        public string[] arr;

        public TestClass(string[] arr)
        {
            this.arr = arr;
        }
    }

    [System.Serializable]
    class TestClass2
    {
        public string text;

        public TestClass2(string text)
        {
            this.text = text;
        }
    }
    //


    float rotateAngle = 45;
    readonly float MaxRotateAngle = 45;

    [SerializeField]
    public float timer = 0;
    [SerializeField]
    GameObject videoBumper;
    void Update()
    {
        if (rotateAngle < MaxRotateAngle)
        {
            rotateAngle++;
            objectToSpin.transform.Rotate(0, 1, 0);
        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    socket.Emit("kalimantan");
        //}

        //timer += Time.deltaTime;
        //if (Input.GetMouseButtonDown(0))
        //{
        //    // the player moved the mouse, reset the timer
        //    timer = 0.0f;
        //    videoBumper.SetActive(false);
        //}

        //if (timer > 600f)
        //{
        //    // inactivity for a period has occured, do what you want
        //    videoBumper.SetActive(true);
        //}
    }
}