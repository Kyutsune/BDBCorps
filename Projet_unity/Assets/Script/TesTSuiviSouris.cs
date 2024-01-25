using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Souris : MonoBehaviour
{
    public float lerpSpeed = 30f;
    public float moveSpeed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        // Obtenez la position du clic de la souris
        Vector3 posClick = Input.mousePosition;

        Vector3 ChangementLoinZ=new Vector3(0f,0f,-100f);
         Vector3 ChangementProcheZ=new Vector3(0f,0f,100f);

        // Convertissez les coordonnées de l'écran en coordonnées du monde 3D
        Vector3 posClickWorld = Camera.main.ScreenToWorldPoint(new Vector3(posClick.x, posClick.y, 10f));
        Vector3 directionToCamera = (Camera.main.transform.position - transform.position).normalized;
        if (Input.GetMouseButton(0))
        {
            // Interpolez la position actuelle vers la position du clic
            transform.position = Vector3.Lerp(transform.position, posClickWorld, lerpSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.P))
            {
                // Rapproche l'objet
                transform.position += directionToCamera * moveSpeed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.O))
            {
                // Eloigne l'objet
                transform.position -= directionToCamera * moveSpeed * Time.deltaTime;
            }
        }
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clic gauche pressé");
            Debug.Log("Coordonnées du clic : X=" + posClickWorld.x + ", Y=" + posClickWorld.y + ", Z=" + posClickWorld.z);
        }
    }
}
