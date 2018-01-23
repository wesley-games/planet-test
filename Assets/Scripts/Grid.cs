using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class Grid : MonoBehaviour
{
    public int xSize, ySize;
    private Vector3[] vertices;
    private int[] triangles;
    private Mesh mesh;

    void Awake()
    {
        StartCoroutine(Generate());
    }

    private IEnumerator Generate()
    {
        GetComponent<MeshFilter>().mesh = mesh = new Mesh();
        mesh.name = "Procedural Grid";

        vertices = new Vector3[(xSize + 1) * (ySize + 1)];
        triangles = new int[6];

        for (int i = 0, y = 0; y < ySize; y++)
        {
            for (int x = 0; x < xSize; x++, i++)
            {
                vertices[i] = new Vector3(x, y);
                yield return new WaitForSeconds(0.05f);
            }
        }

        triangles[0] = 0;
        triangles[1] = xSize + 0;
        triangles[2] = 1;

        triangles[3] = 1;
        triangles[4] = xSize + 0;
        triangles[5] = xSize + 1;

        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }

    private void OnDrawGizmos()
    {
        if (vertices == null) return;
        Gizmos.color = Color.black;
        foreach (Vector3 vertex in vertices)
        {
            Gizmos.DrawSphere(vertex, 0.1f);
        }
    }
}
