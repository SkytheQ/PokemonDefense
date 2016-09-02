using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Towerplacement : MonoBehaviour {

    
    public bool IsEmpty { get; private set; }

    // Use this for initialization
    void Start ()
    {
        
	}

    
  

    // Update is called once per frame
    void Update ()
    {
        
    }

    public void Setup()
    {
        IsEmpty = true;
    }
   
    private void OnMouseOver()
    {
        

        if (!EventSystem.current.IsPointerOverGameObject() && GameManager.Instance.ClickedBtn != null)
        {
            
            if(IsEmpty)
            {

            }
             else if (Input.GetMouseButtonDown(0))
            {
                PlaceTower();
            }
        }
        
    }
    private void PlaceTower()
    {
        
        GameObject tower = (GameObject)Instantiate(GameManager.Instance.ClickedBtn.TowerPrefab, transform.position, Quaternion.identity);
        //tower.GetComponent<SpriteRenderer>().sortingOrder = GridPosition.Y;

        tower.transform.SetParent(transform);

        IsEmpty = false;

        GameManager.Instance.BuyTower();

    }

}
