using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Convert2Morse : MonoBehaviour
{
    public string input;
    public List<char> temp = new List<char>();
    //public List<string> result = new List<string>();
    //public Text t;
    public GameObject grid;
    public GameObject[] images;

    void Start()
    {
        input = "ユク カワ ノ ナガレ ハ タエズ シテ シカモモトノミズニアラズ ナガレニウカブウタカタハ カツキエカツムスビテ ヒサシクトドマリタルタメシナシ ヨノナカニアルヒトトスミカト マタカクノゴトシ" +
            "タマシキミヤコノウチニ ムネヲナラベイラカヲアラソエル タカキイヤシキヒトノスマイハ ヨヨヲヘテツキセヌモノナレド コレヲマコトカトタズヌレバ ムカシアリシイエハマレナリ アルイハコゾヤケテコトシツクレリ" +
            "アルイハオオイエホロビテコイエトナル スムヒトモコレニオナジ";
        
        // 文章を文字に分解
        temp.AddRange(input);
        
        // 文字を符号に変換
        for (int i = 0; i < temp.Count; i++)
            this.ConvertChar2Morse(temp[i]);

        // 変換後のコードを表示
        //t.text = string.Join(" ", result.ToArray());
    }

    void InstantiateImage(int imgNum)
    {
        GameObject go = Instantiate(images[imgNum]);
        go.transform.parent = grid.gameObject.transform;
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
                //result.Add("・-");
                break;
            case 'ロ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                //result.Add("・-・-");
                break;
            case 'B':
            case 'ハ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(0);
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
                //result.Add("-・-・");
                break;
            case 'D':
            case 'ホ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                //result.Add("-・・");
                break;
            case 'E':
            case 'ヘ':
                InstantiateImage(0);
                //result.Add("・");
                break;
            case 'ト':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(0);
                //result.Add("・・-・・");
                break;
            case 'F':
            case 'チ':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                //result.Add("・・-・");
                break;
            case 'G':
            case 'リ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                //result.Add("--・");
                break;
            case 'H':
            case 'ヌ':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(0);
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
                //result.Add("-・--・");
                break;
            case 'I':
                InstantiateImage(0);
                InstantiateImage(0);
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
                //result.Add("--");
                break;
            case 'N':
            case 'タ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
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
                //result.Add("--・-");
                break;
            case 'R':
            case 'ナ':
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                //result.Add("・-・");
                break;
            case 'S':
            case 'ラ':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(0);
                //result.Add("・・・");
                break;
            case 'T':
            case 'ム':
                InstantiateImage(1);
                InstantiateImage(2);
                //result.Add("-");
                break;
            case 'U':
            case 'ウ':
            case 'ゥ':
                InstantiateImage(0);
                InstantiateImage(0);
                InstantiateImage(1);
                InstantiateImage(2);
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
                //result.Add("---・ ・・");
                break;

            case 'ダ':
                InstantiateImage(1);
                InstantiateImage(2);
                InstantiateImage(0);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
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
                //result.Add("--・・ ・・");
                break;
            case 'ベ':
                InstantiateImage(0);
                InstantiateImage(3);
                InstantiateImage(0);
                InstantiateImage(0);
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
                //result.Add("-・・ ・・");
                break;
            //スペース
            case ' ':
                InstantiateImage(3);
                InstantiateImage(3);
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
                case '゛': return new List<char> { m.O, m.O };
                    case '゜': return new List<char> { m.O, m.O, m._, m._, m.O };
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
                    
                    case ' ': return m.SPACE_BETWN_WORDS;
                    */
        }
    }
}