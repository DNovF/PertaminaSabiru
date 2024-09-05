using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    Sprite[] menuBulet;

    [SerializeField]
    Image imgBulet;

    [SerializeField]
    GameObject[] Menu;

    [SerializeField]
    GameObject[] SubMenu1;

    [SerializeField]
    GameObject[] SubMenu2;

    [SerializeField]
    GameObject[] SubMenu3;

    [SerializeField]
    GameObject[] SubMenu4;

    [SerializeField]
    GameObject[] SubMenu5;

    [SerializeField]
    GameObject[] SubMenu6;

    [SerializeField]
    GameObject[] SubMenu7;

    [SerializeField]
    GameObject[] amargalery;

    [SerializeField]
    GameObject[] bergengalery;

    [SerializeField]
    GameObject[] caspiagalery;

    [SerializeField]
    GameObject[] dahliagalery;

    [SerializeField]
    GameObject[] tulipgalery;

    [SerializeField]
    GameObject[] primegalery;

    [SerializeField]
    GameObject[] pridegalery;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void home()
    {
        
        for (int a = 0; a < Menu.Length; a++)
        {
            Menu[a].SetActive(false);
            imgBulet.sprite = menuBulet[0];
        }

    }

    public void closepopup()
    {

        for (int a = 0; a < amargalery.Length; a++)
        {
            amargalery[a].SetActive(false);
            
        }

        for (int a = 0; a < bergengalery.Length; a++)
        {
            bergengalery[a].SetActive(false);

        }

        for (int a = 0; a < caspiagalery.Length; a++)
        {
            caspiagalery[a].SetActive(false);

        }

        for (int a = 0; a < dahliagalery.Length; a++)
        {
            dahliagalery[a].SetActive(false);

        }

        for (int a = 0; a < tulipgalery.Length; a++)
        {
            tulipgalery[a].SetActive(false);

        }

        for (int a = 0; a < primegalery.Length; a++)
        {
            primegalery[a].SetActive(false);

        }

        for (int a = 0; a < pridegalery.Length; a++)
        {
            pridegalery[a].SetActive(false);

        }

    }

    public void selectMenuBulet(int menuSelect)
    {
        imgBulet.sprite = menuBulet[menuSelect];

    }

    public void select_menu(int materi)
    {
        
        for (int a = 0; a < Menu.Length; a++)
        {
            if (a == materi)
            {
                Menu[a].SetActive(true);
            }
            else
            {
                Menu[a].SetActive(false);

            }
        }

    }

    public void select_submenu1(int materi)
    {

        for (int a = 0; a < SubMenu1.Length; a++)
        {
            if (a == materi)
            {
                SubMenu1[a].SetActive(true);
            }
            else
            {
                SubMenu1[a].SetActive(false);

            }
        }

    }

    public void select_submenu2(int materi)
    {

        for (int a = 0; a < SubMenu2.Length; a++)
        {
            if (a == materi)
            {
                SubMenu2[a].SetActive(true);
            }
            else
            {
                SubMenu2[a].SetActive(false);

            }
        }

    }

    public void select_submenu3(int materi)
    {

        for (int a = 0; a < SubMenu3.Length; a++)
        {
            if (a == materi)
            {
                SubMenu3[a].SetActive(true);
            }
            else
            {
                SubMenu3[a].SetActive(false);

            }
        }

    }

    public void select_submenu4(int materi)
    {

        for (int a = 0; a < SubMenu4.Length; a++)
        {
            if (a == materi)
            {
                SubMenu4[a].SetActive(true);
            }
            else
            {
                SubMenu4[a].SetActive(false);

            }
        }

    }

    public void select_submenu5(int materi)
    {

        for (int a = 0; a < SubMenu5.Length; a++)
        {
            if (a == materi)
            {
                SubMenu5[a].SetActive(true);
            }
            else
            {
                SubMenu5[a].SetActive(false);

            }
        }

    }

    public void select_submenu6(int materi)
    {

        for (int a = 0; a < SubMenu6.Length; a++)
        {
            if (a == materi)
            {
                SubMenu6[a].SetActive(true);
            }
            else
            {
                SubMenu6[a].SetActive(false);

            }
        }

    }

    public void select_submenu7(int materi)
    {

        for (int a = 0; a < SubMenu7.Length; a++)
        {
            if (a == materi)
            {
                SubMenu7[a].SetActive(true);
            }
            else
            {
                SubMenu7[a].SetActive(false);

            }
        }

    }

    public void select_amargalery(int materi)
    {

        for (int a = 0; a < amargalery.Length; a++)
        {
            if (a == materi)
            {
                amargalery[a].SetActive(true);
            }
            else
            {
                amargalery[a].SetActive(false);

            }
        }

    }

    public void select_bergengalery(int materi)
    {

        for (int a = 0; a < bergengalery.Length; a++)
        {
            if (a == materi)
            {
                bergengalery[a].SetActive(true);
            }
            else
            {
                bergengalery[a].SetActive(false);

            }
        }

    }

    public void select_caspiagalery(int materi)
    {

        for (int a = 0; a < caspiagalery.Length; a++)
        {
            if (a == materi)
            {
                caspiagalery[a].SetActive(true);
            }
            else
            {
                caspiagalery[a].SetActive(false);

            }
        }

    }

    public void select_dahliagalery(int materi)
    {

        for (int a = 0; a < dahliagalery.Length; a++)
        {
            if (a == materi)
            {
                dahliagalery[a].SetActive(true);
            }
            else
            {
                dahliagalery[a].SetActive(false);

            }
        }

    }

    public void select_tulipgalery(int materi)
    {

        for (int a = 0; a < tulipgalery.Length; a++)
        {
            if (a == materi)
            {
                tulipgalery[a].SetActive(true);
            }
            else
            {
                tulipgalery[a].SetActive(false);

            }
        }

    }

    public void select_primegalery(int materi)
    {

        for (int a = 0; a < primegalery.Length; a++)
        {
            if (a == materi)
            {
                primegalery[a].SetActive(true);
            }
            else
            {
                primegalery[a].SetActive(false);

            }
        }

    }

    public void select_pridegalery(int materi)
    {

        for (int a = 0; a < pridegalery.Length; a++)
        {
            if (a == materi)
            {
                pridegalery[a].SetActive(true);
            }
            else
            {
                pridegalery[a].SetActive(false);

            }
        }

    }

}
