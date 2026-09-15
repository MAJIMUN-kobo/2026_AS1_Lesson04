using UnityEngine;

// =====================================
// コンソールに"文字列"を表示する練習
// =====================================
public class SampleLogs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // コンソールに指定した文字列を表示する
        Debug.Log("表示する文字列");
        Debug.Log("複数記述すると同じだけ表示されます。\nは改行コードです。");
        Debug.Log("Debug.Logは文字列を「メッセージ」として表示");
        Debug.LogWarning("Debug.LogWarningは文字列を「警告」として表示");
        Debug.LogError("Debug.LogErrorは文字列を「エラー」として表示");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("毎フレーム表示します。");
    }
}
