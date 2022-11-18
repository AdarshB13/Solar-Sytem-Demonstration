using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshgen : MonoBehaviour
{
    MeshFilter meshFilter;

    void Start()
    {
        meshFilter=GetComponent<MeshFilter>();
    }

    void Update()
    {
        Mesh mesh=new Mesh();
        Vector3[] vertices = new Vector3[4]
        {
            new Vector3(0, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(0, 1, 0),
            new Vector3(0, 0, 1),
        };
        mesh.vertices = vertices;

        int[] tris = new int[12]
        {
            0,1,2,
            0,1,3,
            0,2,3,
            3,2,1
        };
        mesh.triangles = tris;

        Vector3[] normals = new Vector3[4]
        {
            new Vector3(0,0,1),
            new Vector3(0,1,0),
            new Vector3(-1,0,0),
            new Vector3(0,0,0)
        };
        mesh.normals = normals;

        Vector2[] uv = new Vector2[4]
        {
            new Vector2(0, 0),
            new Vector2(1, 0),
            new Vector2(0, 1),
            new Vector2(1, 1)
        };
        mesh.uv = uv;
        mesh.RecalculateNormals();
        meshFilter.mesh = mesh;
    }
}
