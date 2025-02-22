using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.UI;
using UnityEngine.Events;

/*Unity����AIģ��
 * 1.����HTTP�����-��Ҫͨ��Json���д���ͨ��NewtonsoftJson.Json��LitJson�������л��ͷ����л���
 * 2.����UI�Ի������������������ʾ�ش�
 * 3.��дAPI���ú�����ͨ��HTTP�����ȡAI�ش�
 */

public class AI : MonoBehaviour
{

    private string apiKey = "";     //APIkey
    private string apiUrl = "https://api.deepseek.com/chat/completions";     //��ַ

    public InputField questionInputField;   //�����
    public Text answerText;               //�𰸿�

    //Э�̣��������⣬ AI�ش�����ݽ�����
    IEnumerator PostRequest(string message, UnityAction<string> callback)
    {
        //������������������-�൱�ڿ�ݺ���
        var requestionBody = new
        {
            model = "deepseek-chat",
            messages = new[]
            {
                new {role = "user", content = message}      //��Ϣ�ṹΪ: ���(System, User, Assistant, Tool), ����
            }
        };

    }
    
}
