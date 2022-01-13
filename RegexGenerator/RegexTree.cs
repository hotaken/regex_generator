using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexGenerator
{
    class RegexNode
    {
        public string template { get; set; }
        public bool isLeaf { get; set; }
        public int depth { get; set; }
        public List<RegexNode> list { get; set; }
        public RegexNode() { }
        public RegexNode(string template, bool isLeaf, int depth)
        {
            this.template = template;
            this.isLeaf = isLeaf;
            this.depth = depth;
        }
        public RegexNode(string template, bool isLeaf, int depth, List<RegexNode> list)
        {
            this.template = template;
            this.isLeaf = isLeaf;
            this.depth = depth;
            this.list = list;
        }
        public string GenerateRegexString()
        {
            string restring = template;
            if (isLeaf) return restring;

            List<int> pos = new List<int>();
            for (int i = 0; i < template.Length; i++)
                if (template[i] == '%')
                    pos.Add(i);
            for (int i = pos.Count - 1; i >= 0; i--)
            {
                restring = restring.Remove(pos[i], 1).Insert(pos[i], list[i].GenerateRegexString());
            }
            return restring;
        }
        public string GenerateRegexString(int curh, ref int h)
        {
            depth = curh;
            h = Math.Max(h, depth);
            
            string restring = template;
            if (isLeaf) return restring;

            List<int> pos = new List<int>();
            for (int i = 0; i < template.Length; i++)
                if (template[i] == '%')
                    pos.Add(i);
            for (int i = pos.Count - 1; i >= 0; i--)
            {
                restring = restring.Remove(pos[i], 1).Insert(pos[i], list[i].GenerateRegexString(curh + 1, ref h));
            }
            return restring;
        }
    }

    class RegexTree
    {
        Random rnd = new Random();
        public RegexNode Tree { get; set; }
        public int maxdepth { get; set; }
        public RegexTree() { }
        public RegexTree(RegexNode Tree, int maxdepth)
        {
            this.Tree = Tree;
            this.maxdepth = maxdepth;
        }
        public enum Create
        { byRandom, byDepth }
        public RegexNode CreateRegexTree(Create create, int maxdepth, int depth)
        {
            if (depth >= maxdepth) return LeafTemplates.getRandomLeafNode(depth);
            if (create == Create.byRandom)
            {
                int prob = rnd.Next(101);
                if ((depth != 0 && prob >= 101 - 50) || (depth == 0 && prob >= 86))
                    return LeafTemplates.getRandomLeafNode(depth);
            }

            var node = NodeTemplates.getRandomNode(depth);
            List<int> pos = new List<int>();
            for (int i = 0; i < node.template.Length; i++)
                if (node.template[i] == '%')
                    pos.Add(i);
            List<RegexNode> list = new List<RegexNode>();
            foreach (var ps in pos)
            {
                var new_node = CreateRegexTree(create: create, maxdepth: maxdepth, depth: depth + 1);
                list.Add(new_node);
            }
            node.list = list;
            return node;
        }

        public RegexTree(Create create, int maxdepth)
        {
            this.Tree = CreateRegexTree(create: create, maxdepth: maxdepth, depth: 0);
            this.maxdepth = maxdepth;
        }
        public string GenerateRegexString()
        {
            return Tree.GenerateRegexString();
        }
        public string GenerateRegexString(ref int h)
        {
            int hh = 0;
            int curh = 0;
            var node = Tree.GenerateRegexString(curh, ref hh);
            h = Math.Max(h, hh);
            maxdepth = h;
            return node;
        }
    }
}
