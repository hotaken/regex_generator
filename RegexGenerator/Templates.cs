using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexGenerator
{
    static class LeafTemplates
    {
        public static Random rnd = new Random();

        //private static List<string> symbolClassT = new List<string> { "\\d", "\\w", "\\s" };
        private static List<string> symbolClassT = new List<string> { "\\d", "\\s" };
        //private static List<string> numericT = new List<string>();
        //private static List<string> diapasonT = new List<string> { "a-z", "A-Z", "a-zA-z" };
        //private static List<string> letterT = new List<string>();
        //private static List<char> symbolT = new List<char>(@"!@#$%^&*()_+|\-={}[]:"";'<>?,./~".ToCharArray());
        private static List<char> symbolT = new List<char>(@"+()".ToCharArray());

        static LeafTemplates()
        {
            //for (int i = 0; i <= 9; i++)
            //    numericT.Add(i.ToString());
            //for (char i = 'a'; i <= 'z'; i++)
            //    letterT.Add(i.ToString());
            //for (char i = 'A'; i <= 'Z'; i++)
            //    letterT.Add(i.ToString());
        }

        private static string getRandomSymbolClass()
        {
            return symbolClassT[rnd.Next(symbolClassT.Count)];
        }

        //private static string getRandomNumeric()
        //{
        //    //return numericT[rnd.Next(numericT.Count)];
        //    return rnd.Next(10).ToString();
        //}

        //private static string getRandomDiapason()
        //{
        //    return diapasonT[rnd.Next(diapasonT.Count)];
        //}

        //private static string getRandomLetter()
        //{
        //    return letterT[rnd.Next(letterT.Count)];
        //}

        private static string getRandomSymbol()
        {
            return Regex.Escape(symbolT[rnd.Next(symbolT.Count)].ToString());
        }

        public static string getRandomLeaf()
        {
            int leafs_types_count = 2;
            int leaf_type = rnd.Next(leafs_types_count) + 1;
            switch (leaf_type)
            {
                case 1: return getRandomSymbolClass();
                //case 2: return getRandomNumeric();
                //case 2: return getRandomDiapason();
                //case 4: return getRandomLetter();
                case 2: return getRandomSymbol();
                default: return getRandomSymbolClass();
            }
        }

        public static RegexNode getRandomLeafNode(int depth)
        {
            string template = getRandomLeaf();
            var node = new RegexNode(template: template, isLeaf: true, depth: depth);
            return node;
        }
    }

    internal static class NodeTemplates
    {
        private static Random rnd = LeafTemplates.rnd;

        private static List<string> concatT = new List<string> { "%%" };
        private static List<string> diapasonT = new List<string> { "[%]", "[^%]" };
        private static List<string> quantifierT = new List<string> { "%?", "%+" };
        //private static List<string> quantifierT = new List<string> { "%?", "%+", "%*?", "%{%,%}" }; // for 4th - special processing(2 and 3 %s - must be numbers)
        //private static List<string> lookTokensT = new List<string> { "(?=%)", "(?!%)", "(?<=%)", "(?<!%)" }; // +ahead -ahead +behind -behind

        static string getRandomConcat()
        {
            return concatT[rnd.Next(concatT.Count)];
        }
        static string getRandomDiapason()
        {
            return diapasonT[rnd.Next(diapasonT.Count)];
        }
        static string getRandomQuantifier()
        {
            return quantifierT[rnd.Next(quantifierT.Count)];
        }
        //static string getRandomLookTokensT()
        //{
        //    return lookTokensT[rnd.Next(lookTokensT.Count)];
        //}

        public static RegexNode getRandomNode(int depth)
        {
            int node_types_count = 4;
            int node_type = rnd.Next(node_types_count - 1) + 1;
            string node_template;
            switch(node_type)
            {
                case 1: node_template = getRandomConcat();break;
                case 2: node_template = getRandomDiapason();break;
                case 3: node_template = getRandomQuantifier();break;
                //case 4: node_template = getRandomLookTokensT();break;
                default: node_template = getRandomConcat(); break;
            }
            // TODO: На данный момент  для выражения %{%,%} просто заменяем два последних % на числа 0-8,1-9
            //if (node_type == 3 && node_template == quantifierT[3])
            //{
            //    List<int> pos = new List<int>();
            //    for (int i = 0; i < node_template.Length; i++)
            //        if (node_template[i] == '%')
            //            pos.Add(i);
            //    int sec_conc = rnd.Next(8 + 1);
            //    int third_conc = rnd.Next(9) + 1;
            //    while (sec_conc > third_conc)
            //        third_conc = rnd.Next(9) + 1;
            //    node_template = node_template.Remove(pos[2], 1).Insert(pos[2], third_conc.ToString());
            //    node_template = node_template.Remove(pos[1], 1).Insert(pos[1], sec_conc.ToString());
            //}
            var node = new RegexNode(template: node_template, isLeaf: false, depth: depth);
            return node;
        }
    }
}