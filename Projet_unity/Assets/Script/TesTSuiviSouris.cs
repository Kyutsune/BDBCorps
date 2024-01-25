using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Souris : MonoBehaviour
{
    public float lerpSpeed = 30f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Clic gauche pressé");

            // Obtenez la position du clic de la souris
            Vector3 posClick = Input.mousePosition;

            // Convertissez les coordonnées de l'écran en coordonnées du monde 3D
            Vector3 posClickWorld = Camera.main.ScreenToWorldPoint(new Vector3(posClick.x, posClick.y, 10f));

            Debug.Log("Coordonnées du clic : X=" + posClickWorld.x + ", Y=" + posClickWorld.y + ", Z=" + posClickWorld.z);

            // Interpolez la position actuelle vers la position du clic
            transform.position = Vector3.Lerp(transform.position, posClickWorld, lerpSpeed * Time.deltaTime);
        }
    }
}
