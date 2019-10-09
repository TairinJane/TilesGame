using UnityEngine;

public class Tile : MonoBehaviour
{
    private static Tile previousSelected;
    private bool isSelected;
    Vector3 pos;
    float speed = 3.0f;
    private Color startColor;
    private Renderer rend;
    private bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        isSelected = false;
        rend = GetComponent<Renderer>();
        isActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSelected)
        {
            RaycastHit2D hit;

            if (Input.GetKey(KeyCode.A) && transform.position == pos)
            {
                // Left
                hit = Physics2D.Raycast(transform.position, Vector2.left, 1);
                //Debug.Log(hit.collider.name);
                if (!hit.collider) pos += Vector3.left;
            }

            if (Input.GetKey(KeyCode.D) && transform.position == pos)
            {
                // Right
                hit = Physics2D.Raycast(transform.position, Vector2.right, 1);
                //Debug.Log(hit.collider.name);
                if (!hit.collider) pos += Vector3.right;
            }

            if (Input.GetKey(KeyCode.W) && transform.position == pos)
            {
                // Up
                hit = Physics2D.Raycast(transform.position, Vector2.up, 1);
                //Debug.Log(hit.collider.name);
                if (!hit.collider) pos += Vector3.up;
            }

            if (Input.GetKey(KeyCode.S) && transform.position == pos)
            {
                // Down
                hit = Physics2D.Raycast(transform.position, Vector2.down, 1);
                //Debug.Log(hit.collider.name);
                if (!hit.collider) pos += Vector3.down;
            }

            transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
        }
    }

    private void SelectTile()
    {
        isSelected = true;
        rend.material.color = Color.red;
        startColor = Color.red;
        previousSelected = this;
        Debug.Log("Select");
    }

    private void DeselectTile()
    {
        isSelected = false;
        rend.material.color = Color.white;
        startColor = Color.white;
        previousSelected = null;
        Debug.Log("Deselect");
    }

    private void OnMouseDown()
    {
        if (isActive)
        {
            Debug.Log(name);
            if (isSelected)
            {
                DeselectTile();
            }
            else
            {
                if (previousSelected == null)
                {
                    SelectTile();
                }
                else
                {
                    previousSelected.DeselectTile();
                    SelectTile();
                }
            }
        }
    }

    void OnMouseEnter()
    {
        startColor = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = Color.green;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = startColor;
    }

    public void Deactivate()
    {
        if (isActive)
        {
           // if (isSelected) DeselectTile();
            isActive = false;
        }
    }
}