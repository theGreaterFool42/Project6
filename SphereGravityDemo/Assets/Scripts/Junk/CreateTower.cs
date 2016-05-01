using UnityEngine;
using System.Collections;


public class CreateTower : MonoBehaviour
{
    public float radius;
    public float levels;

    public Transform towerBlock;

    void Start()
    {
        Vector3 center = transform.position;

        float blockHeight = towerBlock.localScale.y;

        float circumference = 2f * Mathf.PI * radius;
        float blocks = (int)(circumference * (0.75f * towerBlock.localScale.z));

        float angle = 360 / blocks;

        float alpha = 0;

        for (int i = 0; i < levels; i++)
        {
            float yPos = center.y + i * blockHeight + blockHeight / 2f;
            alpha = (angle / 2f) * i;

            for (int j = 0; j < blocks; j++)
            {
                float xPos = center.x + radius * Mathf.Cos(alpha * Mathf.PI / 180f);
                float zPos = center.z + radius * Mathf.Sin(alpha * Mathf.PI / 180f);

                Instantiate(towerBlock, new Vector3(xPos, yPos, zPos), Quaternion.Euler(0f, -alpha, 0f));

                alpha += angle;
            }
        }
    }
}