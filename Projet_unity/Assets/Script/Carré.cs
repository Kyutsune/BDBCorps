using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Carré : MonoBehaviour
{
    private Personnage personnage = new Personnage(); 
    private List<GameObject> cubes = new List<GameObject>();
    bool droite_ou_gauche = false;
    int nb_cube=1;

    // Start is called before the first frame update
    void Start()
    {
        CreerCube();
        Debug.Log("ici on log");
    }

    // Update is called once per frame
    void Update()
    {
        if (!droite_ou_gauche)
        {
            // Déplace le personnage vers la droite jusqu'à ce qu'il atteigne la position X de 5
            personnage.PositionX += 1*Time.deltaTime;

            // Si le personnage atteint la position X de 5, inverse la direction
            if (personnage.PositionX >= 5)
            {
                droite_ou_gauche = true;
                CreerCube();
            }
        }
        else
        {
            // Déplace le personnage vers la gauche jusqu'à ce qu'il atteigne la position X de 0
            personnage.PositionX -= 1*Time.deltaTime ;

            // Si le personnage atteint la position X de 0, réinitialise la direction
            if (personnage.PositionX <= 0)
            {
                droite_ou_gauche = false;
                CreerCube();

            }
        }

        foreach (GameObject cube in cubes)
        {
            cube.transform.position = new Vector3(personnage.PositionX, personnage.PositionY, 0f);

            // Ajoutez le script InteractionClic s'il n'est pas déjà attaché
            if (cube.GetComponent<InteractionClic>() == null)
            {
                cube.AddComponent<InteractionClic>();
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (cubes.Count > 0)
            {
                int lastIndex = cubes.Count - 1;
                GameObject lastCube = cubes[lastIndex];

                if (lastCube != null)  // Vérifiez si le dernier cube est toujours valide
                {
                    Destroy(lastCube);
                    cubes.RemoveAt(lastIndex);
                    nb_cube--;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            droite_ou_gauche=!droite_ou_gauche;
        }


    }

    void CreerCube()
    {
        GameObject nouveauCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        nouveauCube.name = "MonCubeamoi,pas a toi " + nb_cube.ToString();
        nb_cube++;
        cubes.Add(nouveauCube);
    }
    
}
