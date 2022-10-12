using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshParticleSystem : MonoBehaviour
{
    private Mesh mesh;
    private Vector3[] vertices;
    private Vector2[] uv;
    private int[] triangles;
    private void Awake() {
        mesh = new Mesh();

        vertices = new Vector3[4];
        uv = new Vector2[4];
        triangles = new int[6];

        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles; 

        GetComponent<MeshFilter>().mesh = mesh;
    }
    
    private void AddQuad() {
        //Relocate Vertices
        int vIndex = 0;
        int vIndex0 = vIndex;
        int vIndex1 = vIndex+1;
        int vIndex2 = vIndex+2;
        int vIndex3 = vIndex+3;
 
        Vector3 quadSize = new Vector3(1,1);
        float rotation = 0f;
        vertices[vIndex0] = Quaternion.Euler(0, 0, rotation - 180)* quadSize;
        vertices[vIndex1] = Quaternion.Euler(0, 0, rotation - 270)* quadSize;
        vertices[vIndex2] = Quaternion.Euler(0, 0, rotation - 0)  * quadSize;
        vertices[vIndex3] = Quaternion.Euler(0, 0, rotation - 90) * quadSize;

        //Create triangles
        int tIndex = 0;
        triangles[tIndex + 0] = vIndex0;
        triangles[tIndex + 1] = vIndex1;
        triangles[tIndex + 2] = vIndex2;

        triangles[tIndex + 3] = vIndex0;
        triangles[tIndex + 4] = vIndex2;
        triangles[tIndex + 5] = vIndex3;

    }
}
