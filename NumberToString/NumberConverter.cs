using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToString
{
    

    public class NumberConverter
    {

        List<WordNumber> n;
        public NumberConverter()
        {
            n = new List<WordNumber>();
            n.Add(new WordNumber(0) { Name0 = "", Name10 = "", NameMiddle = "",Name10End="" });
            n.Add(new WordNumber(1) { Name0 = "нэг", Name10 = "арван", NameMiddle = "нэгэн", Name10End = "арав", Name3 = "нэг" });
            n.Add(new WordNumber(2) { Name0 = "хоёр", Name10 = "хорин", NameMiddle = "хоёр", Name10End = "хорь", Name3 = "хоёр" });
            n.Add(new WordNumber(3) { Name0 = "гурав", Name10 = "гучин", NameMiddle = "гурван", Name10End = "гуч", Name3 = "гурван" });
            n.Add(new WordNumber(4) { Name0 = "дөрөв", Name10 = "дөчин", NameMiddle = "дөрвөн", Name10End = "дөч", Name3 = "дөрвөн" });
            n.Add(new WordNumber(5) { Name0 = "тав", Name10 = "тавин", NameMiddle = "таван", Name10End = "тавь", Name3 = "таван" });
            n.Add(new WordNumber(6) { Name0 = "зургаа", Name10 = "жаран", NameMiddle = "зургаан", Name10End = "жар", Name3 = "зургаан" });
            n.Add(new WordNumber(7) { Name0 = "долоо", Name10 = "далан", NameMiddle = "долоон", Name10End = "дал", Name3 = "долоон" });
            n.Add(new WordNumber(8) { Name0 = "найм", Name10 = "наян", NameMiddle = "найман", Name10End = "ная", Name3 = "найман" });
            n.Add(new WordNumber(9) { Name0 = "ес", Name10 = "ерэн", NameMiddle = "есөн", Name10End = "ер", Name3 = "есөн" });

        }

        public string convert(long number, Boolean mustend = true)
        {
            List<string> l = new List<string>();
            string str = number.ToString();
            int index = 1;
            Boolean isFirst = true;
            Boolean levelFirst = true;
            if (number == 0)
            {
                return "тэг";
            }

            foreach (var item in str.Reverse())
            {
                int i = Convert.ToInt32(item.ToString());

                if (index % 3 == 1)
                    levelFirst = true;

                string word = n[i].ToString(index, isFirst, levelFirst, mustend);
                if (!string.IsNullOrEmpty(word))
                {
                    isFirst = false;
                    levelFirst = false;
                }

                l.Add(word);

                index++;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = l.Count - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(l[i]))
                {
                    sb.Append(l[i] + " ");
                }
            }
            return sb.ToString().Trim();
        }
        
    }

    public class WordNumber
    {
        private int local { get; set; }

        public WordNumber(int i)
        {
            local = i;
        }

        public string Name0 { get; set; }
        public string Name10 { get; set; }
        public string NameMiddle { get; set; }
        public string Name10End { get; set; }
        public string Name3 { get; set; }

        public string ToString(int index, Boolean isFirst, Boolean levelFirst, Boolean mustEnd)
        {

            string ext = "";
            if (local != 0)
            {
                if (index % 3 == 0)
                    ext = isFirst && mustEnd && (!levelFirst || index <= 3) ? " зуу" : " зуун";
                switch (index)
                {
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4:
                    case 5:
                    case 6:
                        if (levelFirst)
                            ext += isFirst && !mustEnd ? " мянган" : " мянга";
                        break;
                    case 7:
                    case 8:
                    case 9:
                        if (levelFirst)
                            ext += " сая";
                        break;
                    case 10:
                    case 11:
                    case 12:
                        if (levelFirst)
                            ext += " тэрбум";
                        break;
                    case 13:
                    case 14:
                    case 15:
                        if (levelFirst)
                            ext += " их наяд";
                        break;
                    case 16:
                    case 17:
                    case 18:
                        if (levelFirst)
                            ext += " гунамал";
                        break;
                    default:
                        break;
                }

            }

            if (index % 3 == 1)//Мянгат
                if (!isFirst)
                {
                    return Name3 + ext;
                }
                else
                {
                    if (!string.IsNullOrEmpty(ext.Trim()))
                        return (levelFirst && mustEnd ? Name3 : NameMiddle) + ext;
                    else
                        return (levelFirst && mustEnd ? Name0 : NameMiddle) + ext;
                }
            else if (index % 3 == 2)//Аравт
                if (!string.IsNullOrEmpty(ext.Trim()))
                {
                    return Name10 + ext;
                }
                else
                    return (levelFirst && mustEnd ? Name10End : Name10) + ext;
            if (index % 3 == 0)//нэгж
                return (local == 1 ? Name0 : NameMiddle) + ext;
            return "";
        }
    }
}
