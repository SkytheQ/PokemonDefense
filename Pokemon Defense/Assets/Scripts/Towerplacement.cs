using UnityEngine;
using System.Collections;

public class Towerplacement : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
	
	}

    
  

    // Update is called once per frame
    void Update ()
    {
	   
	}

   
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlaceTower();
        }
    }
    private void PlaceTower()
    {
        GameObject tower = (GameObject)Instantiate(GameManager.Instance.TowerPrefab, transform.position, Quaternion.identity);
        //tower.GetComponent<SpriteRenderer>().sortingOrder = GridPosition.Y;

        tower.transform.SetParent(transform);
    }
}
