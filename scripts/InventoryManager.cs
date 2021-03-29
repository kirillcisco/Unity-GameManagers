using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour, IGameManager
{
    public ManagerStatus status {get; private set;}

    private Dictionary<string, int> _items; // declaring a dictionary for storing items

    public void Startup()
    {
        Debug.Log("InventoryManager started");

        _items = new Dictionary<string, int>(); // initializing a dictionary for storing items

        status = ManagerStatus.Started;
    }

    private void DisplayItems() // test function to display all items in console
    {
        string itemDisplay = "items: "; 

        foreach (KeyValuePair<string, int> item in _items) // parsing a dictionary for test data output
        {
            itemDisplay += item.Key + "(" + item.Value + ") ";
        }
        Debug.Log(itemDisplay);
    }

    public void AddItem(string itemName) // public function called to add an item in dictionary
    {
        if (_items.ContainsKey(itemName))
        {
            _items[itemName] += 1;
        }
        else
        {
            _items[itemName] = 1;
        }

        DisplayItems();
    }
}
