using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Utilisez cette directive pour TextMeshPro

public class GestionTexte : MonoBehaviour
{
    public TMP_Text texteUI; // Utilisez TMP_Text au lieu de Text pour TextMeshPro

    void Start()
    {
        // Assurez-vous que le composant TextMeshPro est attaché à l'objet ou attribuez-le via l'inspecteur.
        if (texteUI == null)
        {
            texteUI = GetComponent<TMP_Text>();
        }

        // Modifiez le texte initial
        texteUI.text = "Bonjour, Unity!";
    }

    void Update()
    {
        // Exemple de modification du texte pendant la mise à jour
        if (Input.GetKeyDown(KeyCode.Space))
        {
            texteUI.text = "La touche Espace a été enfoncée!";
        }
    }
}
