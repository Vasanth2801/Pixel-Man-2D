using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    public int coinCount = 0;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoin()
    {
        coinCount++;
    }
}