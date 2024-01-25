using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class souris : MonoBehaviour
{
    private GameObject cube;
    // Start is called before the first frame update
    void Start()
    {  
        cube=GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(1f, 0, -9f);
        
    }
    public float lerpSpeed = 30f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Debug.Log("click gauche pressé");
            Vector3 posClick=Input.mousePosition;
            // Convertissez les coordonnées de l'écran en coordonnées du monde 3D
            Vector3 posClickWorld = Camera.main.ScreenToWorldPoint(new Vector3(posClick.x, posClick.y, 10f));

            Debug.Log("Coordonnées du clic : X=" + posClickWorld.x + ", Y=" + posClickWorld.y + ", Z=" + posClickWorld.z);

            Vector3 Npos=Vector3.Lerp(cube.transform.position, posClickWorld, lerpSpeed * Time.deltaTime);

            cube.transform.position=Npos;
        }
        
    }
}
