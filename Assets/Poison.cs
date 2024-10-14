using System.Collections;
using UnityEngine;

public class Poison : Skill
{
    public override string skillName => "Poison";

    public GameObject poisonVFX;
    public float duration = 5.0f; // Duraci�n de la habilidad

    public override void Activate()
    {
        Debug.Log("L�gica de la habilidad Poison");

        // Iniciar la corutina para activar y desactivar el efecto visual
        StartCoroutine(ActivatePoison());
    }

    private IEnumerator ActivatePoison()
    {
        // Instanciar el efecto visual
        GameObject vfxInstance = Instantiate(poisonVFX, transform.position, Quaternion.identity);

        // Esperar la duraci�n establecida
        yield return new WaitForSeconds(duration);

        // Destruir el efecto visual despu�s del tiempo
        Destroy(vfxInstance);
    }
}
