using UnityEngine;

public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private GameObject[] sparrows;
    [SerializeField] private float interactionDistance = 3f;

    private void Update()
    {
        if (player == null) return;

        foreach (GameObject sparrow in sparrows)
        {
            if (sparrow == null || sparrow.activeSelf) continue;

            float distance = Vector3.Distance(
                player.position, sparrow.transform.position
            );

            if (distance <= interactionDistance)
            {
                sparrow.SetActive(true);
            }
        }
    }
}
// Step 1: write the TreeOfBirds class in this file!
