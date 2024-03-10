using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicUI : MonoBehaviour
{

    void OnGUI(){
        int posX = 250;
        int posY = 10;
        int width = 250;
        int height = 30;
        int buffer = 10;

        List<string> itemList = Managers.Inventory.GetItemList();
        if(itemList.Count == 0){
            GUI.Box(new Rect(posX, posY, width, height), "Collect coins to speed up the game");
        }
        foreach(string item in itemList){
            int count = Managers.Inventory.GetItemCount(item);
            Texture2D image = Resources.Load<Texture2D>($"Icons/{item}");
            GUI.Box(new Rect(posX, posY, width, height), new GUIContent($"{count}", image));
            posX += width + buffer;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
