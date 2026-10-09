using UnityEngine;

public class AbrirWeb : MonoBehaviour
{
    public string url;

    public void AbrirPagina()
    {
        Application.OpenURL(url);
    }
}