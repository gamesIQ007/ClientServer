using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class ServerConnection : MonoBehaviour
{
    [SerializeField] private string resourseURL;

    public async Task<PlayerStats> RequestPlayerStatsAsync()
    {
        // Отправляем запрос и отправляем данные
        WebRequest request = WebRequest.Create(resourseURL);
        request.Method = "GET";
        
        // Получаем ответ
        WebResponse response = await request.GetResponseAsync();
        StreamReader stream = new StreamReader(response.GetResponseStream());
        string responseText = await stream.ReadToEndAsync();

        return JsonUtility.FromJson<PlayerStats>(responseText);
    }
}
