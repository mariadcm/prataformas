using System;
using Unity.VisualScripting;
using UnityEngine;
//equivalente ao nosso Youtube
public static class PlayerObserverManager
{
    // criar o canal de moedas do player
    public static event Action<int> OnMoedasChanged;

    //posta um video novo no canal (notifica os inscritos)
    public static void changeMoedas(int valor)
    {
        OnMoedasChanged?.Invoke(valor);
    }

    public static void ChangedMoedas(int moedas)
    {
        throw new NotImplementedException();
    }
}
