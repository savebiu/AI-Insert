using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.UI;
using UnityEngine.Events;

/*Unity接入AI模块
 * 1.导入HTTP请求库-需要通过Json进行处理（通过NewtonsoftJson.Json或LitJson进行序列化和反序列化）
 * 2.创建UI对话框，用于输入问题和显示回答
 * 3.编写API调用函数，通过HTTP请求获取AI回答
 */

public class AI : MonoBehaviour
{

    private string apiKey = "";     //APIkey
    private string apiUrl = "https://api.deepseek.com/chat/completions";     //网址

    public InputField questionInputField;   //输入框
    public Text answerText;               //答案框

    //协程（请求问题， AI回答的数据解析）
    IEnumerator PostRequest(string message, UnityAction<string> callback)
    {
        //创建匿名类型请求体-相当于快捷函数
        var requestionBody = new
        {
            model = "deepseek-chat",
            messages = new[]
            {
                new {role = "user", content = message}      //信息结构为: 身份(System, User, Assistant, Tool), 内容
            }
        };

    }
    
}
