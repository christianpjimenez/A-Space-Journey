using UnityEngine;

public class Pictures : MonoBehaviour
{
    [Header("Pictures")]
    public PicsSO picsSO;
    private int materialId = 1;
    MeshRenderer[] questions;

    private void Start()
    {
        questions = GetComponentsInChildren<MeshRenderer>();
        SetPics();
    }

    private void SetPics()
    {
        for (int i = 0; i < questions.Length; i++)
        {
            questions[i].materials[materialId].mainTexture = picsSO.questions[i];
        }
    }
}