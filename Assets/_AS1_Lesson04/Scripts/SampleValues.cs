using System;
using UnityEditor;
using UnityEngine;              // Unityの基本機能
using UnityEngine.InputSystem;  // 入力デバイスの機能

// ============================
// 「変数」の練習用クラス
// ===========================
public class SampleValues : MonoBehaviour
{
    // フィールド（『グローバル変数』の宣言場所）
    // 『グローバル変数』：クラス内で共有できる変数のこと

    public string Name = "大城貴之";        // 名前の変数 型:文字列(string)
    public int Age = 35;                    // 年齢の変数 型:整数(int)
    public string Job = "プログラマ";       // 職業の変数 型:文字列(string)
    public int BirthMonth = 3;              // 誕生月の変数 型:整数(int)
    public int Hp = 10;
    public int Attack = 3;
    public int Level = 1;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"名前: { Name }です。\n年齢： { Age }歳です。\n職業：　{ Job }です。\n誕生月：　{ BirthMonth }月です。");
    }

    // Update is called once per frame
    void Update()
    {
        // ==========================================
        // [ｘｘｘ]ボタンを押したら、ログを表示する
        // ==========================================
        if ( Keyboard.current.upArrowKey.isPressed )
        {
            Debug.Log("上矢印キーが押されました。");
            Age += 1;
            Debug.Log($"年齢アップ => { Age }歳");
        }

        if(Keyboard.current.downArrowKey.isPressed)
        {
            Debug.Log("下矢印キーが押されました。");
            Age -= 1;
            Debug.Log($"年齢ダウン => { Age }歳");
        }

        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log($"今日の日付は { DateTime.Now } です。");
            Debug.Log($"Hp => {Hp}, Attack => {Attack}, Level => {Level}");
        }

        if(Keyboard.current.rightArrowKey.isPressed)
        {
            Debug.Log($"敵に{Attack}のダメージ！！");
        }
    }
}
