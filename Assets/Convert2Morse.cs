using System.Collections.Generic;
using UnityEngine;

public class Convert2Morse : MonoBehaviour
{
    private string input;
    private List<char> temp = new List<char>();
    public GameObject grid;
    public GameObject[] images;
    private string newLine = "                                   ";
    bool isShutterPressed;

    void Start()
    {
        input = "ユク カワ ノ ナガレ ハ タエズ シテ / シカモ モト ノ ミズ ニ アラズ /              " + newLine
        + "ヨドミ ニ ウカブ ウタカタ ハ / カツ キエ カツ ムスビテ / ヒサシク トドマリタル タメシ ナシ /              " + newLine
        + "ヨ ノ ナカ ニ アル ヒト ト スミカ ト マタ カク ノ ゴトシ /       " + newLine
        + "タマシキ ミヤコ ノ ウチ ニ / ムネ ヲ ナラベ イラカヲ アラソヘル / タカキ イヤシキ　ヒト　ノ　スマイ　ハ / ヨヨ ヲ ヘテ ツキセヌ モノ ナレド /"
        + "コレ ヲ マコト カ ト タズヌレバ / ムカシ アリシ イエ ハ マレ ナリ /                   " + newLine
        + "アルイハ コゾ ヤケテ コトシ ツクレリ / アルイ ハ オオイエ ホロビテ コイエ ト ナル /                         " + newLine
        + "スム　ヒト　モ　コレ　ニ　オナジ / トコロ　モ　カハラズ / ヒト　モ　オオカレド / イニシ　ニ　ミエシ　ヒト　ハ　サンジュウニン　ガ　ナカ　ニ / ワズカニ　ヒトリ　フタリ　ナリ /                        " + newLine
        + "アシタ ニ シニ / ユウベ ニ ウマルル ナラヒ / タダ ミズ ノ アワ ニゾ ニタリケル /";

        // 文章を文字に分解
        temp.AddRange(input);
        
        // 文字を符号に変換
        for (int i = 0; i < temp.Count; i++)
            this.ConvertChar2Morse(temp[i]);

        // 変換後のコードを表示
        //t.text = string.Join(" ", result.ToArray());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isShutterPressed)
        { 
            string folderPath = "Assets/Screenshots/"; 
            var screenshotName = "Screenshot_" +
                                    System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + // puts the current time right into the screenshot name
                                    ".png"; // put youre favorite data format here
            ScreenCapture.CaptureScreenshot(System.IO.Path.Combine(folderPath, screenshotName), 2); // takes the sceenshot, the "2" is for the scaled resolution, you can put this to 600 but it will take really long to scale the image up
            Debug.Log(folderPath + screenshotName); // You get instant feedback in the console
            isShutterPressed = true;
        }
    }

    void InstantiateImage(int imgNum)
    {
        var go = Instantiate(images[imgNum]);
        go.transform.SetParent(grid.gameObject.transform);
    }

    void ConvertChar2Morse(char c)
    {
        switch (c)
        {
            case 'A':
            case 'イ':
            case 'ィ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("・-");
                break;
            case 'ロ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("・-・-");
                break;
            case 'B':
            case 'ハ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("-・・・");
                break;
            case 'C':
            case 'ニ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("-・-・");
                break;
            case 'D':
            case 'ホ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("-・・");
                break;
            case 'E':
            case 'ヘ':
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・");
                break;
            case 'ト':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・・-・・");
                break;
            case 'F':
            case 'チ':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・・-・");
                break;
            case 'G':
            case 'リ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("--・");
                break;
            case 'H':
            case 'ヌ':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・・・・");
                break;
            case 'ル':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("-・--・");
                break;
            case 'I':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・・");
                break;
            case 'J':
            case 'ヲ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("・---");
                break;
            case 'K':
            case 'ワ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("-・-");
                break;
            case 'L':
            case 'カ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・-・・");
                break;
            case 'M':
            case 'ヨ':
            case 'ョ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("--");
                break;
            case 'N':
            case 'タ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("-・");
                break;
            case 'O':
            case 'レ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("---");
                break;
            case 'ソ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("---・");
                break;
            case 'P':
            case 'ツ':
            case 'ッ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・--・");
                break;
            case 'Q':
            case 'ネ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("--・-");
                break;
            case 'R':
            case 'ナ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・-・");
                break;
            case 'S':
            case 'ラ':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・・・");
                break;
            case 'T':
            case 'ム':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("-");
                break;
            case 'U':
            case 'ウ':
            case 'ゥ':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("・・-");
                break;
            case 'ノ':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("・・--");
                break;
            case 'オ':
            case 'ォ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・-・・・");
                break;
            case 'V':
            case 'ク':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("・・・-");
                break;
            case 'W':
            case 'ヤ':
            case 'ャ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("・--");
                break;
            case 'X':
            case 'マ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("-・・-");
                break;
            case 'Y':
            case 'ケ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("-・--");
                break;
            case 'Z':
            case 'フ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("--・・");
                break;

            case 'コ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("----");
                break;
            case 'エ':
            case 'ェ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("-・---");
                break;
            case 'テ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("・-・--");
                break;
            case 'ア':
            case 'ァ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("--・--");
                break;
            case 'サ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("-・-・-");
                break;
            case 'キ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("-・-・・");
                break;
            case 'ユ':
            case 'ュ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("-・・--");
                break;
            case 'メ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("-・・・-");
                break;
            case 'ミ':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("・・-・-");
                break;
            case 'シ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("--・-・");
                break;
            case 'ヒ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("--・・-");
                break;
            case 'モ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("-・・-・");
                break;
            case 'セ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・---・");
                break;
            case 'ス':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                //result.Add("---・-");
                break;
            case 'ン':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・-・-・");
                break;

            case 'ガ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・-・・ ・・");
                break;
            case 'ギ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("-・-・・ ・・");
                break;
            case 'グ':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・・・- ・・");
                break;
            case 'ゲ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("-・-- ・・");
                break;
            case 'ゴ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("---- ・・");
                break;

            case 'ザ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("-・-・- ・・");
                break;
            case 'ジ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("--・-・ ・・");
                break;
            case 'ズ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("---・- ・・");
                break;
            case 'ゼ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・---・ ・・");
                break;
            case 'ゾ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("---・ ・・");
                break;

            case 'ダ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("-・ ・・");
                break;
            case 'ヂ':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・・-・ ・・");
                break;
            case 'ヅ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・--・ ・・");
                break;
            case 'デ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・-・-- ・・");
                break;
            case 'ド':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・・-・・ ・・");
                break;

            case 'バ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("-・・・ ・・");
                break;
            case 'ビ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("--・・- ・・");
                break;
            case 'ブ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("--・・ ・・");
                break;
            case 'ベ':
                InstantiateImage(0);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("・ ・・");
                break;
            case 'ボ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(3);
                //result.Add("-・・ ・・");
                break;
            // スペース
            case ' ':
                InstantiateImage(3);
                InstantiateImage(3);
                break;
            case '/': 
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                break;
            /*
            case 'パ':
                result.Add("-・・・ ・・－－・");
                break;
            case 'ピ':
                result.Add("--・・- ・・－－・");
                break;
            case 'プ':
                result.Add("--・・ ・・－－・");
                break;
            case 'ペ':
                result.Add("・ ・・－－・");
                break;
            case 'ポ':
                result.Add("-・・ ・・－－・");
                break;
            case '1': return new List<char> { m.O, m._, m._, m._, m._ };
            case '2': return new List<char> { m.O, m.O, m._, m._, m._ };
            case '3': return new List<char> { m.O, m.O, m.O, m._, m._ };
            case '4': return new List<char> { m.O, m.O, m.O, m.O, m._ };
            case '5': return new List<char> { m.O, m.O, m.O, m.O, m.O };
            case '6': return new List<char> { m._, m.O, m.O, m.O, m.O };
            case '7': return new List<char> { m._, m._, m.O, m.O, m.O };
            case '8': return new List<char> { m._, m._, m._, m.O, m.O };
            case '9': return new List<char> { m._, m._, m._, m._, m.O };
            case '0': return new List<char> { m._, m._, m._, m._, m._ };
            //欧文記号
            case '.': return new List<char> { m.O, m._, m.O, m._, m.O, m._ };
            case ',': return new List<char> { m._, m._, m.O, m.O, m._, m._ };
            case '?': return new List<char> { m.O, m.O, m._, m._, m.O, m.O };
            case '!': return new List<char> { m._, m.O, m._, m.O, m._, m._ };
            case '-': return new List<char> { m._, m.O, m.O, m.O, m.O, m._ };
            case '/': return new List<char> { m._, m.O, m.O, m._, m.O };
            case '@': return new List<char> { m.O, m._, m._, m.O, m._, m.O };
            case '(': return new List<char> { m._, m.O, m._, m._, m.O };
            case ')': return new List<char> { m._, m.O, m._, m._, m.O, m._ };
            //和文記号
            case 'ー': return new List<char> { m.O, m._, m._, m.O, m._ };
            case '、': return new List<char> { m.O, m._, m.O, m._, m.O, m._ };
            */
        }
    }
}