using UnityEngine;
using Nova;

public class inventorySlot : MonoBehaviour
{
    public inventoryItem itemInSlot;
    public TextBlock text;
    public UIBlock2D imageBlock;
    
    // Update is called once per frame
    void Update()
    {
        updateSlot();   
    }

    public void updateSlot()
    {
        text.Text = itemInSlot.itemName;
        imageBlock.SetImage(itemInSlot.image);
    }
}
