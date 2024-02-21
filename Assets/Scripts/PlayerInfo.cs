using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private new string name;
    public string Name => name;

    [SerializeField] private string password;
    public string Password => password;

    public string GetPasswordHash()
    {
        StringBuilder sb = new();

        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            foreach (byte b in hashValue)
            {
                sb.Append($"{b:X2}");
            }
        }

        Debug.Log(sb);

        return sb.ToString();
    }
}
